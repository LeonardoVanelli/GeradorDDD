using Gerador.Enun;
using Gerador.GeradorEntidade;
using Gerador.Geradores.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerador.CarregarDados
{
    class AtributosEmEntidade
    {
        public Tabela CarregaTabela(CDTabela tabela)
        {

            Tabela Gtabela = new Tabela();
            Gtabela.Nome = MontaNome(tabela.Nome);
            foreach (var campo in tabela.Campos)
            {
                Gtabela.Campos.Add(MontaCampo(campo.Atributos));
            }
            return Gtabela;
        }

        private string MontaNome(string linha)
        {
            var nome = linha.Substring(17, linha.Length - 17);
            return nome.Substring(0, nome.Length - 9);
        }

        private Campo MontaCampo(IList<string> campoPMontar)
        {
            Campo campoFim = new Campo();
            campoFim.IsOptional = true;
            foreach (var campo in campoPMontar)
            {
                if (campo.Length > 18)
                {
                    var campoPegaNome = campo.Trim();
                    if (campoPegaNome.Substring(campoPegaNome.Length - 13, 13) == "{ get; set; }")
                    {
                        var CampoComNomeETipo = MontaTipoNomeCampo(campoPegaNome);
                        campoFim.IsString = CampoComNomeETipo.IsString;
                        campoFim.IsBool = CampoComNomeETipo.IsBool;
                        campoFim.IsInt = CampoComNomeETipo.IsInt;
                        campoFim.IsDateTime = CampoComNomeETipo.IsDateTime;
                        campoFim.IsForeignKey = CampoComNomeETipo.IsForeignKey;
                        campoFim.Nome = CampoComNomeETipo.Nome;
                    }
                }


                switch (campo)
                {
                    case "[Required]":
                        campoFim.IsOptional = false;
                        break;
                    case "[Index(IsUnique = true)]":
                        campoFim.IsUnique = true;
                        break;
                }
                if (campo.Length > 19)
                {
                    if (campo.Substring(0, 13) == "[StringLength")
                    {
                        campo.Trim();
                        Regex length = new Regex(@"\[\w+\(\d+");
                        Match matchle = length.Match(campo);
                        campoFim.MaxLength = BuscaLength(matchle.Value);
                        Regex length1 = new Regex(@"=\d+");
                        Match matchle1 = length1.Match(campo);
                        if (matchle1.Success)
                            campoFim.MinLength = BuscaLength(matchle1.Value);
                    }
                    //else                                                          /*Esta com um erro por causa de acento e de caracteres especiais no regEx*/
                    //if (campo.Substring(0, 9) == "[Display(")
                    //{
                    //    Regex display = new Regex(@"""[\w|\s|-]+""");
                    //    Match match = display.Match(campo);
                    //    var value = match.Value;
                    //    campoFim.Display = match.Value.Substring(1, match.Value.Length - 2);
                    //}
                    else
                    if (campo.Substring(0, 19) == "[RegularExpression(")
                    {
                        Regex regex = new Regex(@"(""[\s\S]+(?=\b[a-z][)]|$))");
                        Match match = regex.Match(campo);
                        campoFim.RegularExpression = match.Value.Substring(1, match.Value.Length - 4);
                    }
                    else
                    if (campo.TrimStart().Substring(0, 16) == "[ForeignKeyView(")
                    {
                        var fk = AdicionaDadosForeignKey(campo);
                        campoFim.ForeignKey = fk;
                    }
                }
                if (campo.Length > 11)
                {
                    if (campo.TrimStart().Substring(0, 12) == "[VisivelView")
                    {
                        campoFim.VisivelTypes = AdicionaCampoVisivel(campo);
                    }
                }
            }

            return campoFim;
        }

        private ForeignKey AdicionaDadosForeignKey(string campo)
        {
            var a = "\"" + @"\" + "w" + "+" + "\"" + "," + "\"" + @"\" + "w" + "+" + "\"";
            Regex regex = new Regex(a);
            Match match = regex.Match(campo.Replace(" ", ""));

            var campos = match.Value.Split(',');
            ForeignKey fk = new ForeignKey();
            fk.Tabela = campos[0].Substring(1, campos[0].Length - 2);
            fk.CampoView = campos[1].Substring(1, campos[1].Length - 2);
            return fk;
        }

        private Campo MontaTipoNomeCampo(string campo)
        {
            var result = new Campo();
            var tipoNome = campo.Split(' ');

            if (tipoNome[2].Substring(tipoNome[2].Length - 3, 3) == "_Id")
                result.IsForeignKey = true;
            else
            {
                switch (tipoNome[1])
                {
                    case "string":
                        result.IsString = true;
                        break;
                    case "int":
                        result.IsInt = true;
                        break;
                    case "bool":
                        result.IsBool = true;
                        break;
                    case "DateTime":
                        result.IsDateTime = true;
                        break;
                }
            }
            result.Nome = tipoNome[2];
            return result;
        }

        private VisivelType AdicionaCampoVisivel(string campo)
        {
            VisivelType visivelType = VisivelType.Nenhum;
            foreach (var item in BuscaListCampos())
            {
                if (item.Count() > 0)
                {
                    switch (item)
                    {
                        case "Grid":
                            visivelType |= VisivelType.Grid;
                            break;
                        case "Form":
                            visivelType |= VisivelType.Form;
                            break;
                        case "Details":
                            visivelType |= VisivelType.Details;
                            break;
                        case "Edit":
                            visivelType |= VisivelType.Edit;
                            break;
                    }
                }
                else
                    visivelType = VisivelType.Todos;
            }
            return visivelType;

            IList<string> BuscaListCampos()
            {
                var campoSemEspaco = campo.Replace(" ", "");
                var listaSplit = "";
                Regex regex = new Regex(@"""[\w|,]+""");
                Match match = regex.Match(campoSemEspaco);
                if (match.Success)
                {
                    listaSplit = match.Value.Substring(1, match.Value.Length - 2);
                }
                return listaSplit.Split(',');
            }
        }

        private int BuscaLength(string campo)
        {
            Regex legth = new Regex(@"[^\d]");
            return Convert.ToInt32(legth.Replace(campo, ""));
        }
    }
}

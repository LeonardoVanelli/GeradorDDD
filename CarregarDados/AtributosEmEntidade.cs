using Gerador.GeradorEntidade;
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
        public void CarregaTabelas(CDTabelas tabelas)
        {
            foreach (var tabela in tabelas.Tabelas)
            {
                Tabela Gtabela = new Tabela();                
                Gtabela.Nome = MontaNome(tabela.Nome);
                foreach (var campo in tabela.Campos)
                {
                    MontaCampo(campo.Atributos);
                }
            }
        }
        private string MontaNome(string linha)
        {
            return linha.Substring(17, linha.Length-17);
        }

        private Campo MontaCampo(IList<string> campoPMontar)
        {
            Campo campoFim = new Campo();
            campoFim.IsOptional = true;
            foreach (var campo in campoPMontar)
            {                
                switch (campo)
                {
                    case "[Required]":
                        campoFim.IsOptional = false;
                        break;
                    case "[Index(IsUnique = true)]":
                        campoFim.IsUnique = true;
                        break;                    
                }        
                if (campo.Length > 15)
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
                    else
                    if (campo.Substring(0, 9) == "[Display(")
                    {
                        Regex display = new Regex(@"""[\w|\s]+""");
                        Match match = display.Match(campo);
                        var value = match.Value;
                        campoFim.Display = match.Value.Substring(1, match.Value.Length - 2);
                    }
                    else
                    if (campo.Substring(0, 19) == "[RegularExpression(")
                    {
                        Regex regex = new Regex(@"(""[\s\S]+(?=\b[a-z][)]|$))");
                        Match match = regex.Match(campo);
                        campoFim.RegularExpression = match.Value.Substring(1, match.Value.Length - 4);
                    }
                }                                
            }

            return null;
        }
        private int BuscaLength(string campo)
        {
            Regex legth = new Regex(@"[^\d]");
            return Convert.ToInt32(legth.Replace(campo, ""));
        }
    }
}

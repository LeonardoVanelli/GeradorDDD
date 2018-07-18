using Gerador.GeradorEntidade;
using Gerador.Geradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.CarregarDados
{
    class EntidadesEmAtributos : GeradorBase
    {
        IList<string> classe;

        public EntidadesEmAtributos(string caminho) : base(caminho)
        {
        }

        public void CarregaAtributo(Tabela tabela, string NomeTabela)
        {
            classe = new List<String>();

            classe.Add("using System;");
            classe.Add("using System.Collections.Generic;");
            classe.Add("using System.ComponentModel;");
            classe.Add("using System.ComponentModel.DataAnnotations;");
            classe.Add("using System.ComponentModel.DataAnnotations.Schema;");
            classe.Add("using System.Data.Entity.Spatial;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Domain.Entities");
            classe.Add("{");
            classe.Add("    public class " + NomeTabela);
            classe.Add("    {");
            classe.Add("        public int Id { get; set; }");
            MontaCampo(tabela);
            classe.Add("    }");
            classe.Add("}");

            var textoFinal = "";
            foreach (var item in classe)
            {
                textoFinal += item + "\n";
            }
        }

        private void MontaCampo(Tabela Tabela)
        {
            foreach (var campo in Tabela.Campos)
            {
                classe.Add("");
                if (!campo.IsOptional)                
                    classe.Add("        [Required]");
                if (campo.IsUnique)
                    classe.Add("        [Index(IsUnique = true)]");
                else if (campo.IsString)
                {
                    if (campo.MaxLength != 0)
                        classe.Add("        [MaxLength(" + campo.MaxLength + ")]");
                }
                MontaNomeCampo(campo);
            }
        }

        private void MontaNomeCampo(Campo campo)
        {
            string tipoCampo = "";
            if (campo.IsInt)
                tipoCampo = "int";
            else if (campo.IsString)
                tipoCampo = "string";
            else if (campo.IsDateTime)
                tipoCampo = "datetime";
            else if (campo.IsBool)
                tipoCampo = "bool";

            classe.Add($"       public " + tipoCampo + " " + campo.Nome + " { get; set; }");
        }
    }
}

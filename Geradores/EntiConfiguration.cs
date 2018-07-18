using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Config
{
    class EntiConfiguration : GeradorBase
    {
        public EntiConfiguration(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using System.Data.Entity.ModelConfiguration;");
            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Infra.Data.EntityConfig");
            classe.Add("{");
            classe.Add("    public class "+entidade+"Configuration : EntityTypeConfiguration<"+entidade+">");
            classe.Add("    {");
            classe.Add("        public "+entidade+"Configuration()");
            classe.Add("        {");
            classe.Add("            HasKey(x => x.Id);");
            classe.Add("        }");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, entidade + "Configuration", @"PrismaWEB.Infra.Data\EntityConfig");
        }
    }
}

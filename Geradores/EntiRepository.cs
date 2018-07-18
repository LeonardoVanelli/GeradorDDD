using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Repositories
{
    class EntiRepository : GeradorBase
    {
        public EntiRepository(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using ProjetoModeloDDD.Domain.Entities;");   
            classe.Add("using ProjetoModeloDDD.Domain.Interfaces.Repositories;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Infra.Data.Repositories");
            classe.Add("{");
            classe.Add("    public class "+entidade+"Repository : RepositoryBase<"+entidade+">, I"+entidade+"Repository");
            classe.Add("    {");
            classe.Add("");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, entidade + "Repository", @"PrismaWEB.Infra.Data\Repositories");
        }
    }
}

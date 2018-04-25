using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Interface
{
    class IEntiRepository : GeradorBase
    {
        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Domain.Interfaces.Repositories");
            classe.Add("{");
            classe.Add("    public interface I" + entidade + "Repository : IRepositoryBase<" + entidade + ">");
            classe.Add("    {");
            classe.Add("");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, "I" + entidade + "Repository", @"PrismaWEB.Domain\Interfaces\Repositories");
        }
    }
}

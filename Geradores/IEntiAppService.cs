using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Interface
{
    class IEntiAppService : GeradorBase
    {
        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Application.Interface");
            classe.Add("{");
            classe.Add("    public interface I" + entidade + "AppService : IAppServiceBase<" + entidade + ">");
            classe.Add("    {");
            classe.Add("");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, "I" + entidade + "AppService", @"PrismaWEB.Application\Interface");
        }
    }
}

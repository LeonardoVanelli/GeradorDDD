using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Interface
{
    class IEntiService : GeradorBase
    {
        public IEntiService(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Domain.Interfaces.Services");
            classe.Add("{");
            classe.Add("    public interface I" + entidade + "Service : IServiceBase<" + entidade + ">");
            classe.Add("    {");
            classe.Add("");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, "I" + entidade + "Service", @"PrismaWEB.Domain\Interfaces\Services");
        }
    }
}

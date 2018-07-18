using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Services
{
    class EntiAppService : GeradorBase
    {
        public EntiAppService(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("using ProjetoModeloDDD.Domain.Interfaces.Repositories;");
            classe.Add("using ProjetoModeloDDD.Domain.Interfaces.Services;");
            classe.Add("using ProjetoModeloDDD.Application.Interface;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Application");
            classe.Add("{");
            classe.Add("    public class " + entidade + "AppService : AppServiceBase<" + entidade + ">, I" + entidade + "AppService");
            classe.Add("    {");
            classe.Add("        private readonly I" + entidade + "Service _" + entidade + "Service;");
            classe.Add("");
            classe.Add("        public "+entidade+ "AppService(I" + entidade + "Service " + entidade + "Service)");
            classe.Add("            : base(" + entidade + "Service)");
            classe.Add("        {");
            classe.Add("            _" + entidade + "Service = " + entidade + "Service;");
            classe.Add("        }");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, entidade + "AppService", "PrismaWEB.Application");
        }
    }
}

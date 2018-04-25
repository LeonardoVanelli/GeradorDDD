using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores.Services
{
    class EntiService : GeradorBase
    {
        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();
                       
            classe.Add("using ProjetoModeloDDD.Domain.Entities;");
            classe.Add("using ProjetoModeloDDD.Domain.Interfaces.Repositories;");
            classe.Add("using ProjetoModeloDDD.Domain.Interfaces.Services;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.Domain.Services");
            classe.Add("{");
            classe.Add("    public class "+entidade+"Service : ServiceBase<"+entidade+">, I"+entidade+"Service");
            classe.Add("    {");
            classe.Add("        private readonly I"+entidade+"Repository _"+entidade+"Repository;");
            classe.Add("");
            classe.Add("        public "+entidade+"Service(I"+entidade+"Repository "+entidade+"Repository)");
            classe.Add("            : base("+entidade+"Repository)");
            classe.Add("        {");
            classe.Add("            _"+entidade+"Repository = "+entidade+"Repository;");
            classe.Add("        }");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, entidade + "Service", @"PrismaWEB.Domain\Services");
        }
    }
}

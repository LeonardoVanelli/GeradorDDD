using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerador.Geradores
{
    class AdicionaNinject : GeradorBase
    {
        public AdicionaNinject(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            var arquivo = BuscaArquivo();
            var gerado = MontaNovaClasse(arquivo, entidade);
            SalvarArquivo(gerado, "NinjectWebCommon", @"PrismaWEB.MVC\App_Start");
        }

        private string MontaNovaClasse(IList<string> arquivo, string entidade)
        {
            var NovoArquivo = new List<string>();
            var LinhaAnterior = "";
            var QtdAdicionar = 0;

            foreach (var linha in arquivo)
            {
                Regex regex = new Regex(@"kernel.Bind<\w+>\(\).To<\w+>\(\);");
                Match match = regex.Match(linha);
                if (match.Success)
                {
                    LinhaAnterior = linha;
                }
                if (LinhaAnterior != "" && (linha == "" || linha == "        }"))
                {
                    if (QtdAdicionar == 0)
                        NovoArquivo.Add($"            kernel.Bind<I{entidade}AppService>().To<{entidade}AppService>();");
                    else if (QtdAdicionar == 1)
                        NovoArquivo.Add($"            kernel.Bind<I{entidade}Service>().To<{entidade}Service>();");
                    else if (QtdAdicionar == 2)
                        NovoArquivo.Add($"            kernel.Bind<I{entidade}Repository>().To<{entidade}Repository>();");
                    QtdAdicionar++;
                }
                NovoArquivo.Add(linha);
            }
            return GerarArquivo(NovoArquivo);
        }

        private IList<string> BuscaArquivo()
        {
            string fileName = "NinjectWebCommon.cs";
            string sourcePath = Caminho + @"\PrismaWEB.MVC\App_Start\" + fileName;

            return System.IO.File.ReadAllLines(sourcePath).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerador.Geradores
{
    class AdicionaAutoMapper : GeradorBase
    {
        public AdicionaAutoMapper(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            var arquivo1 = BuscaArquivo("ViewModelToDomainMappingProfile.cs");
            var gerado1 = GerarIndividual(arquivo1, 
                                         entidade,
                                         $"            Mapper.CreateMap<{entidade}, {entidade}ViewModel>();");           
            
            SalvarArquivo(gerado1, "NinjectWebCommon", @"PrismaWEB.MVC\AutoMapper");

            var arquivo2 = BuscaArquivo("DomainToViewModelMappingProfile.cs");
            var gerado2 = GerarIndividual(arquivo2,
                                         entidade,
                                         $"            Mapper.CreateMap<{entidade}ViewModel, {entidade}>();");

            SalvarArquivo(gerado1, "ViewModelToDomainMappingProfile", @"PrismaWEB.MVC\AutoMapper");
            SalvarArquivo(gerado2, "DomainToViewModelMappingProfile", @"PrismaWEB.MVC\AutoMapper");
        }

        private string GerarIndividual(IList<string> arquivo, string entidade, string TextoAdicionar)
        {
            var NovoArquivo = new List<string>();
            var LinhaAnterior = "";
            var campoJaExiste = false;

            foreach (var linha in arquivo)
            {
                Regex regex = new Regex(@"Mapper.CreateMap<\w+, \w+>\(\);");
                Match match = regex.Match(linha);
                if (match.Success)
                {
                    if (linha == TextoAdicionar)
                    {
                        campoJaExiste = true;
                    }
                    LinhaAnterior = linha;
                }
                if (LinhaAnterior != "" && (linha == "" || linha == "        }") && !campoJaExiste)
                {
                    NovoArquivo.Add(TextoAdicionar);
                    LinhaAnterior = "";
                }
                NovoArquivo.Add(linha);
            }
            return GerarArquivo(NovoArquivo);
        }

        private IList<string> BuscaArquivo(string nome)
        {            
            string sourcePath = Caminho + @"\PrismaWEB.MVC\AutoMapper\" + nome;

            return System.IO.File.ReadAllLines(sourcePath).ToList();
        }
    }
}

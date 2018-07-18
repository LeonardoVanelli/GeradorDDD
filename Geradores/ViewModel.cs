using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores
{
    class ViewModel : GeradorBase
    {
        public ViewModel(string caminho) : base(caminho)
        {
        }

        public void Gerar(string entidade)
        {
            IList<string> classe = new List<String>();

            classe.Add("using System;");
            classe.Add("using System.Collections.Generic;");
            classe.Add("using System.ComponentModel;");
            classe.Add("using System.ComponentModel.DataAnnotations;");
            classe.Add("");
            classe.Add("namespace ProjetoModeloDDD.MVC.ViewModels");
            classe.Add("{");
            classe.Add("    public class "+entidade+"ViewModel");
            classe.Add("    {");
            classe.Add("        [Key]");
            classe.Add("        public int Id { get; set; }");
            classe.Add("    }");
            classe.Add("}");

            var gerado = GerarArquivo(classe);
            SalvarArquivo(gerado, entidade + "ViewModel", @"PrismaWEB.MVC\ViewModels");
        }     
    }
}

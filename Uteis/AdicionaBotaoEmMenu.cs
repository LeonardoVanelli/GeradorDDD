using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Uteis
{
    class AdicionaBotaoEmMenu : UteisBase
    {                                
        //public void Superior(string entidade)
        //{
        //    var arquivo = BuscaArquivo(@"C:\Prisma\WEB\PrismaWEB.MVC\Views\Shared", "_Layout.cshtml");
        //    var novoArquivo = new List<string>();
        //    var novaLinha = "                    <li>@Html.ActionLink(\"" + entidade + "s\", \"Index\", \"" + entidade + "s\")</li>";

        //    if (!VerificaSeJaExiste(arquivo, entidade))
        //    {
        //        foreach (var linha in arquivo)
        //        {
        //            novoArquivo.Add(linha);
        //            if (linha.Trim() == "<ul class=\"nav navbar-nav\">")
        //            {
        //                novoArquivo.Add(novaLinha);
        //            }
        //        }
        //        var gerado = MontaArquivo(novoArquivo);
        //        SalvarArquivo(gerado, "_Layout.cshtml", @"PrismaWEB.MVC\Views\Shared");
        //    }            
        //}

        //private bool VerificaSeJaExiste(IList<string> arquivo, string entidade)
        //{
        //    var novaLinha = "                    <li>@Html.ActionLink(\"" + entidade + "s\", \"Index\", \"" + entidade + "s\")</li>";
        //    foreach (var linha in arquivo)
        //    {
        //        if (linha.Trim() == novaLinha.Trim())
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Geradores
{
    public class GeradorBase
    {
        protected string GerarArquivo(IList<string> texto)
        {
            var textoFinal = "";
            foreach (var item in texto)
            {
                textoFinal += item + "\n";
            }
            return textoFinal;
        }

        protected void SalvarArquivo(string textoFinal, string nome, string caminho)
        {
            //StreamWriter salvar;
            //salvar = new StreamWriter($@"C:\Prisma\WEB\{caminho}\{nome}.cs");
            //salvar.WriteLine(textoFinal);
            //salvar.Close();
        }
    }
}

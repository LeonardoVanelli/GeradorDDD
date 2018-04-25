using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.Uteis
{
    class UteisBase
    {
        protected IList<string> BuscaArquivo(string caminhoArquivo, string nomeArquivo)
        {
            string fileName = nomeArquivo;
            string sourcePath = caminhoArquivo + @"\" + fileName;

            return System.IO.File.ReadAllLines(sourcePath).ToList();
        }

        protected string MontaArquivo(IList<string> texto)
        {
            var textoFinal = "";
            foreach (var item in texto)
            {
                textoFinal += item + "\n";
            }
            return textoFinal;
        }

        protected void SalvarArquivo(string textoFinal, string nomeArquivo, string caminhoArquivo)
        {
            StreamWriter salvar;
            salvar = new StreamWriter($@"C:\Prisma\WEB\{caminhoArquivo}\{nomeArquivo}");
            salvar.WriteLine(textoFinal);
            salvar.Close();
        }
    }
}

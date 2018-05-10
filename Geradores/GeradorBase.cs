using System.Collections.Generic;

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

using System.Collections.Generic;
using System.IO;
using Gerador.Forms;

namespace Gerador.Geradores
{
    public class GeradorBase
    {
        protected string Caminho { get; set; }

        public GeradorBase(string caminho)
        {
            Caminho = caminho;
        }

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
            StreamWriter salvar;          
            salvar = new StreamWriter(Caminho+$@"\{caminho}\{nome}.cs");
            salvar.WriteLine(textoFinal);
            salvar.Close();
        }
    }
}

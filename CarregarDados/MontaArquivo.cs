using Gerador.GeradorEntidade;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerador.CarregarDados
{
    class MontaArquivo
    {
        public string Caminho { get; set; }

        public MontaArquivo(string caminho)
        {
            Caminho = caminho;
        }

        public void BuscaAtributos()
        {
            var ver = System.IO.Directory.GetFiles(Caminho+@"\PrismaWEB.MVC\ViewModels");
            //For dos arquivos .cs     
            IList<Tabela> tabelas = new List<Tabela>();
            foreach (var item in ver)
            {                                
                StreamReader sr = new StreamReader(item);
                var tabela = MontaArquivoComStreamReader(sr);
                tabelas.Add(tabela);                
            }            
        }

        public Tabela MontaArquivoComStreamReader(StreamReader sr)
        {
            CDTabela tabela = new CDTabela();
            string linha;
            CDCampo campo = new CDCampo();
            while ((linha = sr.ReadLine()) != null)
            {
                Regex ReAtributos = new Regex(@"\[");
                Regex ReNomeETipo = new Regex(@"public [s|D|b|i]");
                Regex ReNomeTabela = new Regex(@"public c");

                Match matchAtributos = ReAtributos.Match(Convert.ToString(linha));
                Match matchNomeETipo = ReNomeETipo.Match(Convert.ToString(linha));
                Match matchNomeTabela = ReNomeTabela.Match(Convert.ToString(linha));

                if (matchNomeTabela.Success)
                {
                    tabela.Nome = linha;
                }
                else if (matchAtributos.Success || matchNomeETipo.Success)
                {
                    campo.Add(linha.TrimStart());
                    if (matchNomeETipo.Success)
                    {
                        tabela.Add(campo);
                        campo = new CDCampo();
                    }
                }
            }
            return new AtributosEmEntidade().CarregaTabela(tabela);            
        }
    }
}

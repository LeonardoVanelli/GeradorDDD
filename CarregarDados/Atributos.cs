using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gerador.CarregarDados
{
    class Atributos
    {
        public void BuscaAtributos()
        {
            var ver = System.IO.Directory.GetFiles(@"C:\Prisma\WEB\PrismaWEB.Domain\Entities");
            //For dos arquivos .cs     
            CDTabelas tabelas = new CDTabelas();
            CDTabela tabela = new CDTabela();
            foreach (var item in ver)
            {                                
                StreamReader lendo = new StreamReader(item);
                string linha;
                CDCampo campo = new CDCampo();
                while ((linha = lendo.ReadLine()) != null)
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
                    }else if (matchAtributos.Success || matchNomeETipo.Success)
                    {
                        campo.Add(linha.TrimStart());
                        if (matchNomeETipo.Success)
                        {
                            tabela.Add(campo);
                            campo = new CDCampo();
                        }
                    }
                }
                tabelas.Add(tabela);
                tabela = new CDTabela();
            }
            new AtributosEmEntidade().CarregaTabelas(tabelas);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.CarregarDados
{
    public class CDTabelas
    {
        public IList<CDTabela> Tabelas { get; set; }

        public CDTabelas()
        {
            this.Tabelas = new List<CDTabela>();
        }

        public void Add(CDTabela tabela)
        {
            this.Tabelas.Add(tabela);
        }
    }      

    public class CDTabela
    {
        public string Nome { get; set; }
        public IList<CDCampo> Campos { get; set; }

        public CDTabela()
        {
            this.Campos = new List<CDCampo>();
        }

        public void Add(CDCampo campo)
        {
            this.Campos.Add(campo);
        }
    }

    public class CDCampo
    {     
        public IList<string> Atributos { get; set; }

        public CDCampo()
        {
            this.Atributos = new List<string>();
        }

        public void Add(string atributos)
        {
            this.Atributos.Add(atributos);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.GeradorEntidade
{
    class Tabela
    {
        public string Nome { get; set; }
        public IList<Campo> Campos { get; set; }

        public Tabela()
        {
            Campos = new List<Campo>();
        }

        public void Add(String nome, IList<Campo> campo)
        {
            this.Nome = nome;
            this.Campos = campo;
        }
    }    
}

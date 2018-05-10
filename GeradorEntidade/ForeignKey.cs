using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador.GeradorEntidade
{
    class ForeignKey
    {
        public string Tabela { get; set; }
        public string CampoView { get; set; }


        public ForeignKey()
        {

        }

        public ForeignKey(string tabela, string campoView)
        {
            this.Tabela = tabela;
            if (!string.IsNullOrEmpty(campoView))
                this.CampoView = campoView;
            else
                this.CampoView = "Nome";
        }        
    }    
}

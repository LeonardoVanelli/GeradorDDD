using Gerador.CarregarDados;
using Gerador.GeradorEntidade;
using Gerador.Geradores.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador.Forms
{
    public partial class FormGerarView : Form
    {
        public string Caminho { get; set; }

        public FormGerarView(string caminho)
        {
            Caminho = caminho;
            InitializeComponent();
            var ListaNomeEntidades = BuscaNomeEntidades();
            MontaTreeView(ListaNomeEntidades);
        }

        private void MontaTreeView(IList<string> ListaNomeEntidades)
        {
            tvEntidades.Nodes.Add("Entidades");
            foreach (var nomeEntidade in ListaNomeEntidades)
            {
                tvEntidades.Nodes[0].Nodes.Add(nomeEntidade);
            }
        }

        private IList<string> BuscaNomeEntidades()
        {
            var files = Directory.GetFiles(Caminho + @"\PrismaWEB.MVC\ViewModels");
            var result = new List<string>();

            foreach (var file in files)
            {
                var nome = new DirectoryInfo(file).Name;                
                result.Add(nome.Substring(0, nome.Length -12));
            }
            return result;
        }

        private Tabela GerarTabela()
        {
            var NomeEntidadeSelecionada = tvEntidades.SelectedNode.Text;
            try
            {
                if (NomeEntidadeSelecionada == "Entidades")                
                    throw new Exception("Selecione um Item para gerar a view");
                StreamReader entidade = new StreamReader(Caminho + @"\PrismaWEB.MVC\ViewModels\"+ NomeEntidadeSelecionada + "ViewModel.cs");
                return new MontaArquivo(Caminho).MontaArquivoComStreamReader(entidade);                                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);                
            }
            return null;                      
        }

        private void btnGerarCreate_Click(object sender, EventArgs e)
        {
            var tabela = GerarTabela();
            if (tabela != null)
                new Create(Caminho).Gerar(tabela);
        }

        private void btnGerarIndex_Click(object sender, EventArgs e)
        {
            var tabela = GerarTabela();
            if (tabela != null)
                new Index(Caminho).Gerar(tabela);
        }

        private void btnGerarEdit_Click(object sender, EventArgs e)
        {
            var tabela = GerarTabela();
            if (tabela != null)
            {
                new Edit(Caminho).Gerar(tabela);
            }
        }

        private void btnGerarTodos_Click(object sender, EventArgs e)
        {
            var tabela = GerarTabela();
            if (tabela != null)
            {
                new Index(Caminho).Gerar(tabela);
                new Edit(Caminho).Gerar(tabela);                
                new Create(Caminho).Gerar(tabela);
            }
        }

        private void tvEntidades_AfterSelect(object sender, TreeViewEventArgs e)
        {                        
            foreach (TreeNode item in tvEntidades.Nodes[0].Nodes)
            {
                if (item.Equals(e.Node))
                    e.Node.BackColor = Color.LightGray;
                else
                    item.BackColor = Color.White;
            }            
        }
    }
}

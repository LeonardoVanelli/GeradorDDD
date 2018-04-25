using Gerador.CarregarDados;
using Gerador.GeradorEntidade;
using Gerador.Geradores;
using Gerador.Geradores.Config;
using Gerador.Geradores.Interface;
using Gerador.Geradores.Repositories;
using Gerador.Geradores.Services;
using Gerador.Uteis;
using ProjetoModeloDDD.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador
{
    public partial class Form1 : Form
    {
        public string Caminho { get; set; }
        public object Campos { get; private set; }
        IList<Campo> campos = new List<Campo>();        
        private int ValueCampoEdidanto { get; set; }
        Tabela TabelaCompleta = new Tabela();

        public Form1()
        {
            InitializeComponent();
            ValueCampoEdidanto = -1;
            cbGeral.SetItemChecked(1, true);            
        }


        private void BtnGerar_Click(object sender, EventArgs e)
        {            
            var entidade = tbNomeEntidade.Text;
            if (!string.IsNullOrEmpty(entidade))
            {
                if (MessageBox.Show($"Deseja gerar a entidade {entidade}?", 
                    "Confirmar",                     
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    new EntiAppService().Gerar(entidade);
                    new EntiConfiguration().Gerar(entidade);
                    new EntiRepository().Gerar(entidade);
                    new EntiService().Gerar(entidade);
                    new IEntiAppService().Gerar(entidade);
                    new IEntiRepository().Gerar(entidade);
                    new IEntiService().Gerar(entidade);
                    new ViewModel().Gerar(entidade);
                    new EntiController().Gerar(entidade);
                    new AdicionaNinject().Gerar(entidade);
                    new AdicionaAutoMapper().Gerar(entidade);
                    if (cbGerarEntidade.Checked)
                        new EntidadesEmAtributos().CarregaAtributo(TabelaCompleta, entidade);
                    MessageBox.Show("Gerado com Sucesso", "Infromação");
                    AdicionaBotaoMenu();
                }                
            } else
                MessageBox.Show("Nome é obrigatório", "Infromação");
        }

        private void AdicionaBotaoMenu()
        {
            var entidade = tbNomeEntidade.Text;
            if (cbMenuSuperior.Checked)
                new AdicionaBotaoEmMenu().Superior(entidade);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Atributos().BuscaAtributos();
        }

        private void btnGerarEntidade_Click(object sender, EventArgs e)
        {                                    
            CriaCampo();
            AtualizaTreeView();
            LimpaCampos();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Novo Campo")
            {                
                LimpaCampos();
                ValueCampoEdidanto = -1;
            }
            else
            {
                if (TabelaCompleta.Campos.Count > 0)
                {
                    var campo = TabelaCompleta.Campos[e.Node.Index];
                    ValueCampoEdidanto = e.Node.Index;
                    PreencheView(campo);
                }
            }
        }

        private void AtualizaTreeView()
        {
            treeView1.Nodes[0].Nodes.Clear();
            foreach (var campo in TabelaCompleta.Campos)
            {                
                if (treeView1.Nodes[0].Nodes.Count == 0 )
                {
                    treeView1.Nodes[0].Nodes.Add(tbNomeEntidade.Text);
                }
                treeView1.Nodes[0].Nodes[0].Nodes.Add(campo.Nome);
            }
            treeView1.Nodes[0].Nodes[0].Nodes.Add("Novo Campo");
        }

        private void tbIntegerMinValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PreencheView(Campo campo)
        {
            //geral
            tbNomeCampo.Text = campo.Nome;
            tbDisplay.Text = campo.Display;
            cbGeral.SetItemChecked(0, campo.IsOptional);
            cbGeral.SetItemChecked(1, campo.IsVisivel);
            tbStringErroMsg.Text = campo.MensagemErro;
            //integer
            tbIntegerMaxValue.Text = Convert.ToString(campo.MaxValue);
            tbIntegerMinValue.Text = Convert.ToString(campo.MinValue);
            //string
            tbMaxLength.Text = Convert.ToString(campo.MaxLength);
            tbMinLength.Text = Convert.ToString(campo.MinLength);
            cbStringCpf.Checked = campo.IsCpf;
            cbStringEmail.Checked = campo.IsEmail;
            cbStringDataType.SelectedIndex = campo.DataType == null ? -1 : campo.DataType.Id;
            tbStringRegex.Text = campo.RegularExpression;
            //Bool
            cbBoolVerdadeiro.Checked = campo.IsVerdadeiro;

            //tabControl1.SelectedTab = campo.
        }

        private void LimpaCampos()
        {
            //geral
            tbNomeCampo.Text = string.Empty;
            tbDisplay.Text = string.Empty;
            cbGeral.SetItemChecked(0, false);
            cbGeral.SetItemChecked(1, true);
            tbStringErroMsg.Text = string.Empty;
            //integer
            tbIntegerMaxValue.Text = string.Empty; 
            tbIntegerMinValue.Text = string.Empty;
            //string
            tbMaxLength.Text = string.Empty;
            tbMinLength.Text = string.Empty;
            cbStringCpf.Checked = false;
            cbStringEmail.Checked = false;
            cbStringDataType.SelectedIndex = 1;
            tbStringRegex.Text = string.Empty;
            //Bool
            cbBoolVerdadeiro.Checked = false;

            tabControl1.SelectedIndex = 0;
        }

        private void CriaCampo()
        {            
            var campo = new Campo();

            if (ValueCampoEdidanto != -1)
                campo = TabelaCompleta.Campos[ValueCampoEdidanto];                        

            //geral
            campo.Nome = tbNomeCampo.Text;
            campo.Display = tbDisplay.Text;
            campo.IsOptional = cbGeral.GetItemChecked(0);
            campo.IsVisivel = cbGeral.GetItemChecked(1);
            campo.IsUnique = cbGeral.GetItemChecked(2);
            campo.MensagemErro = tbStringErroMsg.Text;
            //integer
            campo.MaxValue = tbIntegerMaxValue.Text != "" ? Convert.ToInt32(tbIntegerMaxValue.Text) : 0;
            campo.MinValue = tbIntegerMinValue.Text != "" ? Convert.ToInt32(tbIntegerMinValue.Text) : 0;
            //string
            campo.MaxLength = tbMaxLength.Text != "" ? Convert.ToInt16(tbMaxLength.Text) : 0;
            campo.MinLength = tbMinLength.Text != "" ? Convert.ToInt16(tbMinLength.Text) : 0;
            campo.IsCpf = cbStringCpf.Checked;
            campo.IsEmail = cbStringEmail.Checked;
            campo.DataType = TipoDataType.GetById(cbStringDataType.SelectedIndex);
            campo.RegularExpression = tbStringRegex.Text;
            //Bool
            campo.IsVerdadeiro = cbBoolVerdadeiro.Checked;

            switch (tabControl1.SelectedTab.Text)
            {
                case "Integer":
                    campo.IsInt = true;
                    break;
                case "String":
                    campo.IsString = true;
                    break;
                case "DateTime":
                    if (cbHora.Checked)
                        campo.IsDateTime = true;
                    campo.IsDate = true;
                    break;
                case "Bool":
                    campo.IsBool = true;
                    break;
            }

            campo.ValidaCampos();

            if (ValueCampoEdidanto != -1)
                TabelaCompleta.Campos[ValueCampoEdidanto] = campo; 
            else
                TabelaCompleta.Campos.Add(campo);
        }

        private void btnConectionBanco_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrismaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string sql = @"SELECT c.* from INFORMATION_SCHEMA.columns c
                            INNER JOIN INFORMATION_SCHEMA.tables t ON t.table_name = c.table_name
                            WHERE t.table_type = 'BASE TABLE'
                              AND C.TABLE_NAME = 'PESSOA'
                            ORDER BY t.table_name";

            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader leitor = cmd.ExecuteReader();
            
            while (leitor.Read())
            {
                var Nome = leitor["TABLE_NAME"].ToString();
                var NomeCOLUNA = leitor["COLUMN_NAME"].ToString();
                var IS_NULLABLE = leitor["IS_NULLABLE"].ToString();
                var DATA_TYPE = leitor["DATA_TYPE"].ToString();
                var character_maximum_length = leitor["character_maximum_length"].ToString();                
            }
            conn.Close();
        }

        private void tpString_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbStringDataType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TbMaxLength_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
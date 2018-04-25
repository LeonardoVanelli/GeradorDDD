namespace Gerador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Novo Campo");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tabela", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.BtnGerar = new System.Windows.Forms.Button();
            this.tbNomeCampo = new System.Windows.Forms.TextBox();
            this.fbdCaminhoSalvar = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGerarEntidade = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConectionBanco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Label();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpInteger = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIntegerMaxValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIntegerMinValue = new System.Windows.Forms.TextBox();
            this.tpString = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStringDataType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbStringErroMsg = new System.Windows.Forms.TextBox();
            this.tbStringRegex = new System.Windows.Forms.TextBox();
            this.cbStringCpf = new System.Windows.Forms.CheckBox();
            this.cbStringEmail = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMinLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxLength = new System.Windows.Forms.TextBox();
            this.tpDateTime = new System.Windows.Forms.TabPage();
            this.cbHora = new System.Windows.Forms.CheckBox();
            this.tpBool = new System.Windows.Forms.TabPage();
            this.cbBoolVerdadeiro = new System.Windows.Forms.CheckBox();
            this.tbNomeEntidade = new System.Windows.Forms.TextBox();
            this.cbGeral = new System.Windows.Forms.CheckedListBox();
            this.cbGerarEntidade = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbMenuSuperior = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpInteger.SuspendLayout();
            this.tpString.SuspendLayout();
            this.tpDateTime.SuspendLayout();
            this.tpBool.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGerar
            // 
            this.BtnGerar.Location = new System.Drawing.Point(669, 3);
            this.BtnGerar.Name = "BtnGerar";
            this.BtnGerar.Size = new System.Drawing.Size(139, 29);
            this.BtnGerar.TabIndex = 0;
            this.BtnGerar.Text = "Gerar";
            this.BtnGerar.UseVisualStyleBackColor = true;
            this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
            // 
            // tbNomeCampo
            // 
            this.tbNomeCampo.Location = new System.Drawing.Point(220, 49);
            this.tbNomeCampo.Name = "tbNomeCampo";
            this.tbNomeCampo.Size = new System.Drawing.Size(137, 20);
            this.tbNomeCampo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGerarEntidade
            // 
            this.btnGerarEntidade.Location = new System.Drawing.Point(588, 12);
            this.btnGerarEntidade.Name = "btnGerarEntidade";
            this.btnGerarEntidade.Size = new System.Drawing.Size(75, 23);
            this.btnGerarEntidade.TabIndex = 7;
            this.btnGerarEntidade.Text = "Adicionar";
            this.btnGerarEntidade.UseVisualStyleBackColor = true;
            this.btnGerarEntidade.Click += new System.EventHandler(this.btnGerarEntidade_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Campos";
            treeNode1.Text = "Novo Campo";
            treeNode2.Name = "nTabela";
            treeNode2.Text = "Tabela";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(214, 424);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnConectionBanco);
            this.panel1.Controls.Add(this.BtnGerar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 35);
            this.panel1.TabIndex = 6;
            // 
            // btnConectionBanco
            // 
            this.btnConectionBanco.Location = new System.Drawing.Point(482, 6);
            this.btnConectionBanco.Name = "btnConectionBanco";
            this.btnConectionBanco.Size = new System.Drawing.Size(101, 23);
            this.btnConectionBanco.TabIndex = 4;
            this.btnConectionBanco.Text = "Banco";
            this.btnConectionBanco.UseVisualStyleBackColor = true;
            this.btnConectionBanco.Click += new System.EventHandler(this.btnConectionBanco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Location = new System.Drawing.Point(360, 33);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(41, 13);
            this.Display.TabIndex = 9;
            this.Display.Text = "Display";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(363, 49);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(137, 20);
            this.tbDisplay.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpInteger);
            this.tabControl1.Controls.Add(this.tpString);
            this.tabControl1.Controls.Add(this.tpDateTime);
            this.tabControl1.Controls.Add(this.tpBool);
            this.tabControl1.Location = new System.Drawing.Point(220, 130);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 289);
            this.tabControl1.TabIndex = 6;
            // 
            // tpInteger
            // 
            this.tpInteger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpInteger.Controls.Add(this.label3);
            this.tpInteger.Controls.Add(this.tbIntegerMaxValue);
            this.tpInteger.Controls.Add(this.label2);
            this.tpInteger.Controls.Add(this.tbIntegerMinValue);
            this.tpInteger.Location = new System.Drawing.Point(4, 22);
            this.tpInteger.Name = "tpInteger";
            this.tpInteger.Padding = new System.Windows.Forms.Padding(3);
            this.tpInteger.Size = new System.Drawing.Size(359, 263);
            this.tpInteger.TabIndex = 0;
            this.tpInteger.Text = "Integer";
            this.tpInteger.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "MinValue";
            // 
            // tbIntegerMaxValue
            // 
            this.tbIntegerMaxValue.Location = new System.Drawing.Point(6, 62);
            this.tbIntegerMaxValue.Name = "tbIntegerMaxValue";
            this.tbIntegerMaxValue.Size = new System.Drawing.Size(136, 20);
            this.tbIntegerMaxValue.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "MaxValue";
            // 
            // tbIntegerMinValue
            // 
            this.tbIntegerMinValue.Location = new System.Drawing.Point(6, 20);
            this.tbIntegerMinValue.Name = "tbIntegerMinValue";
            this.tbIntegerMinValue.Size = new System.Drawing.Size(136, 20);
            this.tbIntegerMinValue.TabIndex = 10;
            this.tbIntegerMinValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIntegerMinValue_KeyPress);
            // 
            // tpString
            // 
            this.tpString.Controls.Add(this.label7);
            this.tpString.Controls.Add(this.cbStringDataType);
            this.tpString.Controls.Add(this.label8);
            this.tpString.Controls.Add(this.label6);
            this.tpString.Controls.Add(this.tbStringErroMsg);
            this.tpString.Controls.Add(this.tbStringRegex);
            this.tpString.Controls.Add(this.cbStringCpf);
            this.tpString.Controls.Add(this.cbStringEmail);
            this.tpString.Controls.Add(this.label4);
            this.tpString.Controls.Add(this.tbMinLength);
            this.tpString.Controls.Add(this.label5);
            this.tpString.Controls.Add(this.tbMaxLength);
            this.tpString.Location = new System.Drawing.Point(4, 22);
            this.tpString.Name = "tpString";
            this.tpString.Padding = new System.Windows.Forms.Padding(3);
            this.tpString.Size = new System.Drawing.Size(359, 263);
            this.tpString.TabIndex = 2;
            this.tpString.Text = "String";
            this.tpString.UseVisualStyleBackColor = true;
            this.tpString.Click += new System.EventHandler(this.tpString_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "DataType";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cbStringDataType
            // 
            this.cbStringDataType.FormattingEnabled = true;
            this.cbStringDataType.Items.AddRange(new object[] {
            "Password",
            "Input"});
            this.cbStringDataType.Location = new System.Drawing.Point(156, 110);
            this.cbStringDataType.Name = "cbStringDataType";
            this.cbStringDataType.Size = new System.Drawing.Size(121, 21);
            this.cbStringDataType.TabIndex = 13;
            this.cbStringDataType.SelectedIndexChanged += new System.EventHandler(this.cbStringDataType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mensagem de erro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Regular Expression";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbStringErroMsg
            // 
            this.tbStringErroMsg.Location = new System.Drawing.Point(6, 229);
            this.tbStringErroMsg.Name = "tbStringErroMsg";
            this.tbStringErroMsg.Size = new System.Drawing.Size(344, 20);
            this.tbStringErroMsg.TabIndex = 5;
            // 
            // tbStringRegex
            // 
            this.tbStringRegex.Location = new System.Drawing.Point(6, 184);
            this.tbStringRegex.Name = "tbStringRegex";
            this.tbStringRegex.Size = new System.Drawing.Size(344, 20);
            this.tbStringRegex.TabIndex = 20;
            // 
            // cbStringCpf
            // 
            this.cbStringCpf.AutoSize = true;
            this.cbStringCpf.Location = new System.Drawing.Point(6, 29);
            this.cbStringCpf.Name = "cbStringCpf";
            this.cbStringCpf.Size = new System.Drawing.Size(46, 17);
            this.cbStringCpf.TabIndex = 19;
            this.cbStringCpf.Text = "CPF";
            this.cbStringCpf.UseVisualStyleBackColor = true;
            // 
            // cbStringEmail
            // 
            this.cbStringEmail.AutoSize = true;
            this.cbStringEmail.Location = new System.Drawing.Point(6, 6);
            this.cbStringEmail.Name = "cbStringEmail";
            this.cbStringEmail.Size = new System.Drawing.Size(54, 17);
            this.cbStringEmail.TabIndex = 18;
            this.cbStringEmail.Text = "E-mail";
            this.cbStringEmail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "MinValue";
            // 
            // tbMinLength
            // 
            this.tbMinLength.Location = new System.Drawing.Point(7, 110);
            this.tbMinLength.Name = "tbMinLength";
            this.tbMinLength.Size = new System.Drawing.Size(67, 20);
            this.tbMinLength.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "MaxValue";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbMaxLength
            // 
            this.tbMaxLength.Location = new System.Drawing.Point(80, 110);
            this.tbMaxLength.Name = "tbMaxLength";
            this.tbMaxLength.Size = new System.Drawing.Size(70, 20);
            this.tbMaxLength.TabIndex = 14;
            this.tbMaxLength.TextChanged += new System.EventHandler(this.TbMaxLength_TextChanged);
            // 
            // tpDateTime
            // 
            this.tpDateTime.Controls.Add(this.cbHora);
            this.tpDateTime.Location = new System.Drawing.Point(4, 22);
            this.tpDateTime.Name = "tpDateTime";
            this.tpDateTime.Padding = new System.Windows.Forms.Padding(3);
            this.tpDateTime.Size = new System.Drawing.Size(359, 263);
            this.tpDateTime.TabIndex = 1;
            this.tpDateTime.Text = "DateTime";
            this.tpDateTime.UseVisualStyleBackColor = true;
            // 
            // cbHora
            // 
            this.cbHora.AutoSize = true;
            this.cbHora.Location = new System.Drawing.Point(6, 24);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(49, 17);
            this.cbHora.TabIndex = 0;
            this.cbHora.Text = "Hora";
            this.cbHora.UseVisualStyleBackColor = true;
            // 
            // tpBool
            // 
            this.tpBool.Controls.Add(this.cbBoolVerdadeiro);
            this.tpBool.Location = new System.Drawing.Point(4, 22);
            this.tpBool.Name = "tpBool";
            this.tpBool.Size = new System.Drawing.Size(359, 263);
            this.tpBool.TabIndex = 3;
            this.tpBool.Text = "Bool";
            this.tpBool.UseVisualStyleBackColor = true;
            // 
            // cbBoolVerdadeiro
            // 
            this.cbBoolVerdadeiro.AutoSize = true;
            this.cbBoolVerdadeiro.Location = new System.Drawing.Point(3, 12);
            this.cbBoolVerdadeiro.Name = "cbBoolVerdadeiro";
            this.cbBoolVerdadeiro.Size = new System.Drawing.Size(77, 17);
            this.cbBoolVerdadeiro.TabIndex = 0;
            this.cbBoolVerdadeiro.Text = "Verdadeito";
            this.cbBoolVerdadeiro.UseVisualStyleBackColor = true;
            // 
            // tbNomeEntidade
            // 
            this.tbNomeEntidade.Location = new System.Drawing.Point(299, 6);
            this.tbNomeEntidade.Name = "tbNomeEntidade";
            this.tbNomeEntidade.Size = new System.Drawing.Size(137, 20);
            this.tbNomeEntidade.TabIndex = 1;
            // 
            // cbGeral
            // 
            this.cbGeral.CheckOnClick = true;
            this.cbGeral.FormattingEnabled = true;
            this.cbGeral.Items.AddRange(new object[] {
            "Opcional",
            "Visivel",
            "Unico"});
            this.cbGeral.Location = new System.Drawing.Point(220, 75);
            this.cbGeral.Name = "cbGeral";
            this.cbGeral.Size = new System.Drawing.Size(365, 49);
            this.cbGeral.TabIndex = 4;
            // 
            // cbGerarEntidade
            // 
            this.cbGerarEntidade.AutoSize = true;
            this.cbGerarEntidade.Location = new System.Drawing.Point(601, 394);
            this.cbGerarEntidade.Name = "cbGerarEntidade";
            this.cbGerarEntidade.Size = new System.Drawing.Size(103, 17);
            this.cbGerarEntidade.TabIndex = 25;
            this.cbGerarEntidade.Text = "Gerar Entidade?";
            this.cbGerarEntidade.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMenuSuperior);
            this.groupBox1.Location = new System.Drawing.Point(595, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 99);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar botão no menu";
            // 
            // cbMenuSuperior
            // 
            this.cbMenuSuperior.AutoSize = true;
            this.cbMenuSuperior.Location = new System.Drawing.Point(6, 19);
            this.cbMenuSuperior.Name = "cbMenuSuperior";
            this.cbMenuSuperior.Size = new System.Drawing.Size(65, 17);
            this.cbMenuSuperior.TabIndex = 26;
            this.cbMenuSuperior.Text = "Superior";
            this.cbMenuSuperior.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbGerarEntidade);
            this.Controls.Add(this.cbGeral);
            this.Controls.Add(this.tbNomeEntidade);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnGerarEntidade);
            this.Controls.Add(this.tbNomeCampo);
            this.Name = "Form1";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpInteger.ResumeLayout(false);
            this.tpInteger.PerformLayout();
            this.tpString.ResumeLayout(false);
            this.tpString.PerformLayout();
            this.tpDateTime.ResumeLayout(false);
            this.tpDateTime.PerformLayout();
            this.tpBool.ResumeLayout(false);
            this.tpBool.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGerar;
        private System.Windows.Forms.TextBox tbNomeCampo;
        private System.Windows.Forms.FolderBrowserDialog fbdCaminhoSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGerarEntidade;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpInteger;
        private System.Windows.Forms.TabPage tpDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIntegerMinValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIntegerMaxValue;
        private System.Windows.Forms.CheckBox cbHora;
        private System.Windows.Forms.TabPage tpString;
        private System.Windows.Forms.TabPage tpBool;
        private System.Windows.Forms.TextBox tbNomeEntidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMinLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxLength;
        private System.Windows.Forms.CheckBox cbStringCpf;
        private System.Windows.Forms.CheckBox cbStringEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbStringRegex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStringDataType;
        private System.Windows.Forms.CheckBox cbBoolVerdadeiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbStringErroMsg;
        private System.Windows.Forms.CheckedListBox cbGeral;
        private System.Windows.Forms.Button btnConectionBanco;
        private System.Windows.Forms.CheckBox cbGerarEntidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbMenuSuperior;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}


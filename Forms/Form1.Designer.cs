﻿namespace Gerador
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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Novo Campo");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Tabela", new System.Windows.Forms.TreeNode[] {
            treeNode3});
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tbFkCampo05 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbFkCampo04 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbFkCampo03 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbFkCampo02 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbFkCampo01 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFkTabela05 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbFkTabela04 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbFkTabela03 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbFkTabela02 = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.tbFkTabela01 = new System.Windows.Forms.TextBox();
            this.tbNomeEntidade = new System.Windows.Forms.TextBox();
            this.cbGeral = new System.Windows.Forms.CheckedListBox();
            this.cbGerarEntidade = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMenuSuperior = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vtsiGerarViews = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalizaPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpInteger.SuspendLayout();
            this.tpString.SuspendLayout();
            this.tpDateTime.SuspendLayout();
            this.tpBool.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tbNomeCampo.Location = new System.Drawing.Point(224, 89);
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
            this.btnGerarEntidade.Location = new System.Drawing.Point(601, 43);
            this.btnGerarEntidade.Name = "btnGerarEntidade";
            this.btnGerarEntidade.Size = new System.Drawing.Size(75, 23);
            this.btnGerarEntidade.TabIndex = 7;
            this.btnGerarEntidade.Text = "Adicionar";
            this.btnGerarEntidade.UseVisualStyleBackColor = true;
            this.btnGerarEntidade.Click += new System.EventHandler(this.btnGerarEntidade_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            treeNode3.Name = "Campos";
            treeNode3.Text = "Novo Campo";
            treeNode4.Name = "nTabela";
            treeNode4.Text = "Tabela";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(214, 397);
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
            this.label1.Location = new System.Drawing.Point(221, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Location = new System.Drawing.Point(364, 73);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(41, 13);
            this.Display.TabIndex = 9;
            this.Display.Text = "Display";
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(367, 89);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(220, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 249);
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
            this.tpInteger.Size = new System.Drawing.Size(359, 223);
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
            this.tpString.Size = new System.Drawing.Size(359, 223);
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
            this.tpDateTime.Size = new System.Drawing.Size(359, 223);
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
            this.tpBool.Size = new System.Drawing.Size(359, 223);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.tbFkCampo05);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.tbFkCampo04);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.tbFkCampo03);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.tbFkCampo02);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.tbFkCampo01);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbFkTabela05);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.tbFkTabela04);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbFkTabela03);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tbFkTabela02);
            this.tabPage1.Controls.Add(this.text);
            this.tabPage1.Controls.Add(this.tbFkTabela01);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(359, 223);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Tabela (Temporario)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(176, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Nome Campo view";
            // 
            // tbFkCampo05
            // 
            this.tbFkCampo05.Location = new System.Drawing.Point(179, 203);
            this.tbFkCampo05.Name = "tbFkCampo05";
            this.tbFkCampo05.Size = new System.Drawing.Size(137, 20);
            this.tbFkCampo05.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(176, 143);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Nome Campo view";
            // 
            // tbFkCampo04
            // 
            this.tbFkCampo04.Location = new System.Drawing.Point(179, 159);
            this.tbFkCampo04.Name = "tbFkCampo04";
            this.tbFkCampo04.Size = new System.Drawing.Size(137, 20);
            this.tbFkCampo04.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(176, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Nome Campo view";
            // 
            // tbFkCampo03
            // 
            this.tbFkCampo03.Location = new System.Drawing.Point(179, 118);
            this.tbFkCampo03.Name = "tbFkCampo03";
            this.tbFkCampo03.Size = new System.Drawing.Size(137, 20);
            this.tbFkCampo03.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(176, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Nome Campo view";
            // 
            // tbFkCampo02
            // 
            this.tbFkCampo02.Location = new System.Drawing.Point(179, 75);
            this.tbFkCampo02.Name = "tbFkCampo02";
            this.tbFkCampo02.Size = new System.Drawing.Size(137, 20);
            this.tbFkCampo02.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(176, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Nome Campo view";
            // 
            // tbFkCampo01
            // 
            this.tbFkCampo01.Location = new System.Drawing.Point(179, 34);
            this.tbFkCampo01.Name = "tbFkCampo01";
            this.tbFkCampo01.Size = new System.Drawing.Size(137, 20);
            this.tbFkCampo01.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Nome Tabela";
            // 
            // tbFkTabela05
            // 
            this.tbFkTabela05.Location = new System.Drawing.Point(14, 203);
            this.tbFkTabela05.Name = "tbFkTabela05";
            this.tbFkTabela05.Size = new System.Drawing.Size(137, 20);
            this.tbFkTabela05.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Nome Tabela";
            // 
            // tbFkTabela04
            // 
            this.tbFkTabela04.Location = new System.Drawing.Point(14, 159);
            this.tbFkTabela04.Name = "tbFkTabela04";
            this.tbFkTabela04.Size = new System.Drawing.Size(137, 20);
            this.tbFkTabela04.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Nome Tabela";
            // 
            // tbFkTabela03
            // 
            this.tbFkTabela03.Location = new System.Drawing.Point(14, 118);
            this.tbFkTabela03.Name = "tbFkTabela03";
            this.tbFkTabela03.Size = new System.Drawing.Size(137, 20);
            this.tbFkTabela03.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nome Tabela";
            // 
            // tbFkTabela02
            // 
            this.tbFkTabela02.Location = new System.Drawing.Point(14, 75);
            this.tbFkTabela02.Name = "tbFkTabela02";
            this.tbFkTabela02.Size = new System.Drawing.Size(137, 20);
            this.tbFkTabela02.TabIndex = 10;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(11, 18);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(71, 13);
            this.text.TabIndex = 9;
            this.text.Text = "Nome Tabela";
            // 
            // tbFkTabela01
            // 
            this.tbFkTabela01.Location = new System.Drawing.Point(14, 34);
            this.tbFkTabela01.Name = "tbFkTabela01";
            this.tbFkTabela01.Size = new System.Drawing.Size(137, 20);
            this.tbFkTabela01.TabIndex = 8;
            // 
            // tbNomeEntidade
            // 
            this.tbNomeEntidade.Location = new System.Drawing.Point(303, 46);
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
            this.cbGeral.Location = new System.Drawing.Point(220, 115);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vtsiGerarViews});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Gerar";
            // 
            // vtsiGerarViews
            // 
            this.vtsiGerarViews.Name = "vtsiGerarViews";
            this.vtsiGerarViews.Size = new System.Drawing.Size(104, 22);
            this.vtsiGerarViews.Text = "Views";
            this.vtsiGerarViews.Click += new System.EventHandler(this.vtsiGerarViews_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 460);
            this.Controls.Add(this.menuStrip1);
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
            this.MainMenuStrip = this.menuStrip1;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbFkCampo05;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbFkCampo04;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbFkCampo03;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbFkCampo02;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbFkCampo01;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFkTabela05;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbFkTabela04;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbFkTabela03;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbFkTabela02;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox tbFkTabela01;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vtsiGerarViews;
        private System.Windows.Forms.FolderBrowserDialog LocalizaPasta;
    }
}


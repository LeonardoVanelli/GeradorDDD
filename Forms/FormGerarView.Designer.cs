namespace Gerador.Forms
{
    partial class FormGerarView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvEntidades = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGerarTodos = new System.Windows.Forms.Button();
            this.btnGerarEdit = new System.Windows.Forms.Button();
            this.btnGerarDetails = new System.Windows.Forms.Button();
            this.btnGerarCreate = new System.Windows.Forms.Button();
            this.btnGerarIndex = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tvEntidades
            // 
            this.tvEntidades.CheckBoxes = true;
            this.tvEntidades.Location = new System.Drawing.Point(0, 27);
            this.tvEntidades.Name = "tvEntidades";
            this.tvEntidades.Size = new System.Drawing.Size(265, 422);
            this.tvEntidades.TabIndex = 1;
            this.tvEntidades.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvEntidades_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGerarTodos);
            this.panel1.Controls.Add(this.btnGerarEdit);
            this.panel1.Controls.Add(this.btnGerarDetails);
            this.panel1.Controls.Add(this.btnGerarCreate);
            this.panel1.Controls.Add(this.btnGerarIndex);
            this.panel1.Location = new System.Drawing.Point(271, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 174);
            this.panel1.TabIndex = 2;
            // 
            // btnGerarTodos
            // 
            this.btnGerarTodos.Location = new System.Drawing.Point(327, 3);
            this.btnGerarTodos.Name = "btnGerarTodos";
            this.btnGerarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnGerarTodos.TabIndex = 4;
            this.btnGerarTodos.Text = "Todos";
            this.btnGerarTodos.UseVisualStyleBackColor = true;
            this.btnGerarTodos.Click += new System.EventHandler(this.btnGerarTodos_Click);
            // 
            // btnGerarEdit
            // 
            this.btnGerarEdit.Location = new System.Drawing.Point(246, 3);
            this.btnGerarEdit.Name = "btnGerarEdit";
            this.btnGerarEdit.Size = new System.Drawing.Size(75, 23);
            this.btnGerarEdit.TabIndex = 3;
            this.btnGerarEdit.Text = "Edit";
            this.btnGerarEdit.UseVisualStyleBackColor = true;
            this.btnGerarEdit.Click += new System.EventHandler(this.btnGerarEdit_Click);
            // 
            // btnGerarDetails
            // 
            this.btnGerarDetails.Location = new System.Drawing.Point(165, 3);
            this.btnGerarDetails.Name = "btnGerarDetails";
            this.btnGerarDetails.Size = new System.Drawing.Size(75, 23);
            this.btnGerarDetails.TabIndex = 2;
            this.btnGerarDetails.Text = "Details";
            this.btnGerarDetails.UseVisualStyleBackColor = true;
            // 
            // btnGerarCreate
            // 
            this.btnGerarCreate.Location = new System.Drawing.Point(84, 3);
            this.btnGerarCreate.Name = "btnGerarCreate";
            this.btnGerarCreate.Size = new System.Drawing.Size(75, 23);
            this.btnGerarCreate.TabIndex = 1;
            this.btnGerarCreate.Text = "Create";
            this.btnGerarCreate.UseVisualStyleBackColor = true;
            this.btnGerarCreate.Click += new System.EventHandler(this.btnGerarCreate_Click);
            // 
            // btnGerarIndex
            // 
            this.btnGerarIndex.Location = new System.Drawing.Point(3, 3);
            this.btnGerarIndex.Name = "btnGerarIndex";
            this.btnGerarIndex.Size = new System.Drawing.Size(75, 23);
            this.btnGerarIndex.TabIndex = 0;
            this.btnGerarIndex.Text = "Index";
            this.btnGerarIndex.UseVisualStyleBackColor = true;
            this.btnGerarIndex.Click += new System.EventHandler(this.btnGerarIndex_Click);
            // 
            // FormGerarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvEntidades);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGerarView";
            this.Text = "FormGerarView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView tvEntidades;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerarTodos;
        private System.Windows.Forms.Button btnGerarEdit;
        private System.Windows.Forms.Button btnGerarDetails;
        private System.Windows.Forms.Button btnGerarCreate;
        private System.Windows.Forms.Button btnGerarIndex;
    }
}
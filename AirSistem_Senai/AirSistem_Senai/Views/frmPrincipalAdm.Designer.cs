namespace AirSistem_Senai.Views
{
    partial class frmPrincipalAdm
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
            this.listarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAviõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarAviãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarCompanhiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarRelatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarUsuáriosToolStripMenuItem,
            this.listarAviõesToolStripMenuItem,
            this.gerenciarAviãoToolStripMenuItem,
            this.gerenciarCompanhiaToolStripMenuItem,
            this.gerenciarRelatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(772, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listarUsuáriosToolStripMenuItem
            // 
            this.listarUsuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem});
            this.listarUsuáriosToolStripMenuItem.Name = "listarUsuáriosToolStripMenuItem";
            this.listarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listarUsuáriosToolStripMenuItem.Text = "Listar Usuários";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // listarAviõesToolStripMenuItem
            // 
            this.listarAviõesToolStripMenuItem.Name = "listarAviõesToolStripMenuItem";
            this.listarAviõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.listarAviõesToolStripMenuItem.Text = "Listar Aviões";
            // 
            // gerenciarAviãoToolStripMenuItem
            // 
            this.gerenciarAviãoToolStripMenuItem.Name = "gerenciarAviãoToolStripMenuItem";
            this.gerenciarAviãoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.gerenciarAviãoToolStripMenuItem.Text = "Gerenciar Avião";
            // 
            // gerenciarCompanhiaToolStripMenuItem
            // 
            this.gerenciarCompanhiaToolStripMenuItem.Name = "gerenciarCompanhiaToolStripMenuItem";
            this.gerenciarCompanhiaToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.gerenciarCompanhiaToolStripMenuItem.Text = "Gerenciar Companhia";
            // 
            // gerenciarRelatóriosToolStripMenuItem
            // 
            this.gerenciarRelatóriosToolStripMenuItem.Name = "gerenciarRelatóriosToolStripMenuItem";
            this.gerenciarRelatóriosToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gerenciarRelatóriosToolStripMenuItem.Text = "Gerenciar Relatórios";
            // 
            // frmPrincipalAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 410);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipalAdm";
            this.Text = "frmPrincipalAdm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAviõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarAviãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarCompanhiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarRelatóriosToolStripMenuItem;
    }
}
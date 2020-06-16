namespace AirSistem_Senai.Views
{
    partial class frmPrincipalUsuario
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
            this.btnListarAvioes = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarConpanhia = new System.Windows.Forms.Button();
            this.btnGerenciarRelatorios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarAvioes
            // 
            this.btnListarAvioes.Location = new System.Drawing.Point(191, 51);
            this.btnListarAvioes.Name = "btnListarAvioes";
            this.btnListarAvioes.Size = new System.Drawing.Size(142, 126);
            this.btnListarAvioes.TabIndex = 0;
            this.btnListarAvioes.Text = "Listar aviões";
            this.btnListarAvioes.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Location = new System.Drawing.Point(339, 51);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(142, 126);
            this.btnGerenciarAviao.TabIndex = 1;
            this.btnGerenciarAviao.Text = "Gerenciar avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarConpanhia
            // 
            this.btnGerenciarConpanhia.Location = new System.Drawing.Point(191, 183);
            this.btnGerenciarConpanhia.Name = "btnGerenciarConpanhia";
            this.btnGerenciarConpanhia.Size = new System.Drawing.Size(142, 126);
            this.btnGerenciarConpanhia.TabIndex = 2;
            this.btnGerenciarConpanhia.Text = "Gerenciar companhia";
            this.btnGerenciarConpanhia.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarRelatorios
            // 
            this.btnGerenciarRelatorios.Location = new System.Drawing.Point(339, 183);
            this.btnGerenciarRelatorios.Name = "btnGerenciarRelatorios";
            this.btnGerenciarRelatorios.Size = new System.Drawing.Size(142, 126);
            this.btnGerenciarRelatorios.TabIndex = 3;
            this.btnGerenciarRelatorios.Text = "Gerenciar relatórios";
            this.btnGerenciarRelatorios.UseVisualStyleBackColor = true;
            // 
            // frmPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 369);
            this.Controls.Add(this.btnGerenciarRelatorios);
            this.Controls.Add(this.btnGerenciarConpanhia);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Controls.Add(this.btnListarAvioes);
            this.Name = "frmPrincipalUsuario";
            this.Text = "Tela Principal-AirSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarAvioes;
        private System.Windows.Forms.Button btnGerenciarAviao;
        private System.Windows.Forms.Button btnGerenciarConpanhia;
        private System.Windows.Forms.Button btnGerenciarRelatorios;
    }
}
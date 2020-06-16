namespace AirSistem_Senai
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnNovoUsuário = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lbxIdioma = new System.Windows.Forms.ListBox();
            this.lblRelogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblAviso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(355, 293);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(436, 293);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnNovoUsuário
            // 
            this.btnNovoUsuário.Location = new System.Drawing.Point(518, 292);
            this.btnNovoUsuário.Name = "btnNovoUsuário";
            this.btnNovoUsuário.Size = new System.Drawing.Size(80, 23);
            this.btnNovoUsuário.TabIndex = 2;
            this.btnNovoUsuário.Text = "Novo Usuário";
            this.btnNovoUsuário.UseVisualStyleBackColor = true;
            this.btnNovoUsuário.Click += new System.EventHandler(this.btnNovoUsuário_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Location = new System.Drawing.Point(355, 239);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(38, 13);
            this.lblIdioma.TabIndex = 3;
            this.lblIdioma.Text = "Idioma";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(355, 176);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(355, 109);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuário";
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(358, 125);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(180, 20);
            this.tbxUsuario.TabIndex = 6;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(358, 192);
            this.tbxSenha.MaxLength = 16;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(180, 20);
            this.tbxSenha.TabIndex = 7;
            // 
            // lbxIdioma
            // 
            this.lbxIdioma.FormattingEnabled = true;
            this.lbxIdioma.Items.AddRange(new object[] {
            "Português  PT-BR",
            "Inglês"});
            this.lbxIdioma.Location = new System.Drawing.Point(358, 255);
            this.lbxIdioma.Name = "lbxIdioma";
            this.lbxIdioma.Size = new System.Drawing.Size(116, 17);
            this.lbxIdioma.TabIndex = 8;
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Location = new System.Drawing.Point(468, 26);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(70, 13);
            this.lblRelogio.TabIndex = 9;
            this.lblRelogio.Text = "13:54:13:999";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(172, 9);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(243, 13);
            this.lblAviso.TabIndex = 10;
            this.lblAviso.Text = "Usuário = \"adm\" para acessar como administrador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 119);
            this.label1.TabIndex = 11;
            this.label1.Text = "AS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirSistem_Senai.Properties.Resources.avião;
            this.pictureBox1.Location = new System.Drawing.Point(77, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 61);
            this.label2.TabIndex = 13;
            this.label2.Text = "AirSystem";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 327);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.lbxIdioma);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnNovoUsuário);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(626, 366);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(626, 366);
            this.Name = "frmLogin";
            this.Text = "Login-AirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnNovoUsuário;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.ListBox lbxIdioma;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}


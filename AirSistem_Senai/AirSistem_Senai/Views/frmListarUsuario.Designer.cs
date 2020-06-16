namespace AirSistem_Senai.Views
{
    partial class frmListarUsuario
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
            this.dgvListaUsuario = new System.Windows.Forms.DataGridView();
            this.lblContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.tbxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxNascimento = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblDadosUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaUsuario
            // 
            this.dgvListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaUsuario.Location = new System.Drawing.Point(13, 13);
            this.dgvListaUsuario.Name = "dgvListaUsuario";
            this.dgvListaUsuario.Size = new System.Drawing.Size(348, 383);
            this.dgvListaUsuario.TabIndex = 0;
            this.dgvListaUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaUsuario_CellClick);
            this.dgvListaUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListaUsuario_CellMouseClick);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(367, 383);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(35, 13);
            this.lblContador.TabIndex = 1;
            this.lblContador.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(53, 434);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(197, 20);
            this.tbxFiltro.TabIndex = 3;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(430, 437);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(543, 437);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(54, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(603, 437);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(684, 437);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(582, 379);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(177, 20);
            this.tbxConfirmarSenha.TabIndex = 9;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(582, 353);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(177, 20);
            this.tbxSenha.TabIndex = 10;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(582, 197);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(177, 20);
            this.tbxNome.TabIndex = 11;
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Location = new System.Drawing.Point(582, 223);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(177, 20);
            this.tbxSobrenome.TabIndex = 12;
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Location = new System.Drawing.Point(582, 249);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(177, 20);
            this.tbxEndereco.TabIndex = 13;
            // 
            // tbxNascimento
            // 
            this.tbxNascimento.Location = new System.Drawing.Point(582, 275);
            this.tbxNascimento.Name = "tbxNascimento";
            this.tbxNascimento.Size = new System.Drawing.Size(177, 20);
            this.tbxNascimento.TabIndex = 14;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(582, 301);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(177, 20);
            this.tbxNumero.TabIndex = 15;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Location = new System.Drawing.Point(582, 327);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(177, 20);
            this.tbxUsuario.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(591, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(591, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 109);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(480, 200);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(480, 226);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 21;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(480, 252);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 22;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(480, 278);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 23;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(480, 304);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 24;
            this.lblNumero.Text = "Número";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(480, 330);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 25;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(480, 356);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 26;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(480, 382);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarSenha.TabIndex = 27;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // lblDadosUsuario
            // 
            this.lblDadosUsuario.AutoSize = true;
            this.lblDadosUsuario.Location = new System.Drawing.Point(622, 13);
            this.lblDadosUsuario.Name = "lblDadosUsuario";
            this.lblDadosUsuario.Size = new System.Drawing.Size(92, 13);
            this.lblDadosUsuario.TabIndex = 28;
            this.lblDadosUsuario.Text = "Dados do Usuário";
            // 
            // frmListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 483);
            this.Controls.Add(this.lblDadosUsuario);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxNascimento);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxConfirmarSenha);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.dgvListaUsuario);
            this.Name = "frmListarUsuario";
            this.Text = "Listar usuários - AirSystem";
            this.Load += new System.EventHandler(this.frmListarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaUsuario;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox tbxConfirmarSenha;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxNascimento;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblDadosUsuario;
    }
}
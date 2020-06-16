namespace AirSistem_Senai.Views
{
    partial class frmCadastro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.fotopictureBox = new System.Windows.Forms.PictureBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblSenhaValida = new System.Windows.Forms.Label();
            this.lblSenhaCorreta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tbxNome
            // 
            this.tbxNome.AccessibleName = "Nome";
            this.tbxNome.Location = new System.Drawing.Point(107, 22);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(121, 20);
            this.tbxNome.TabIndex = 1;
            this.tbxNome.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxNome.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.AccessibleName = "Sobrenome";
            this.tbxSobrenome.Location = new System.Drawing.Point(234, 22);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(121, 20);
            this.tbxSobrenome.TabIndex = 2;
            this.tbxSobrenome.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxSobrenome.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // fotopictureBox
            // 
            this.fotopictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fotopictureBox.Location = new System.Drawing.Point(437, 22);
            this.fotopictureBox.Name = "fotopictureBox";
            this.fotopictureBox.Size = new System.Drawing.Size(157, 142);
            this.fotopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotopictureBox.TabIndex = 3;
            this.fotopictureBox.TabStop = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(437, 170);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(13, 69);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 5;
            this.lblEndereco.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(12, 113);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(63, 13);
            this.lblNascimento.TabIndex = 7;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 161);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(13, 215);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(16, 266);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(85, 13);
            this.lblConfirmarSenha.TabIndex = 10;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.AccessibleName = "Endereço";
            this.tbxEndereco.Location = new System.Drawing.Point(107, 66);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(196, 20);
            this.tbxEndereco.TabIndex = 11;
            this.tbxEndereco.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxEndereco.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.AccessibleName = "Usuário";
            this.tbxUsuario.Location = new System.Drawing.Point(107, 158);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(147, 20);
            this.tbxUsuario.TabIndex = 12;
            this.tbxUsuario.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxSenha
            // 
            this.tbxSenha.AccessibleName = "Senha";
            this.tbxSenha.Location = new System.Drawing.Point(107, 212);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(147, 20);
            this.tbxSenha.TabIndex = 13;
            this.tbxSenha.TextChanged += new System.EventHandler(this.tbxSenha_TextChanged);
            this.tbxSenha.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxSenha.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.AccessibleName = "Confirmar Senha";
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(107, 263);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.PasswordChar = '*';
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(147, 20);
            this.tbxConfirmarSenha.TabIndex = 14;
            this.tbxConfirmarSenha.TextChanged += new System.EventHandler(this.tbxConfirmarSenha_TextChanged);
            this.tbxConfirmarSenha.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxConfirmarSenha.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxNumero
            // 
            this.tbxNumero.AccessibleName = "Número";
            this.tbxNumero.Location = new System.Drawing.Point(309, 66);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(46, 20);
            this.tbxNumero.TabIndex = 15;
            this.tbxNumero.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxNumero.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(519, 170);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(107, 314);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lblSenhaValida
            // 
            this.lblSenhaValida.AutoSize = true;
            this.lblSenhaValida.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSenhaValida.Location = new System.Drawing.Point(260, 215);
            this.lblSenhaValida.Name = "lblSenhaValida";
            this.lblSenhaValida.Size = new System.Drawing.Size(70, 13);
            this.lblSenhaValida.TabIndex = 19;
            this.lblSenhaValida.Text = "Senha Válida";
            this.lblSenhaValida.Visible = false;
            // 
            // lblSenhaCorreta
            // 
            this.lblSenhaCorreta.AutoSize = true;
            this.lblSenhaCorreta.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSenhaCorreta.Location = new System.Drawing.Point(260, 266);
            this.lblSenhaCorreta.Name = "lblSenhaCorreta";
            this.lblSenhaCorreta.Size = new System.Drawing.Size(75, 13);
            this.lblSenhaCorreta.TabIndex = 20;
            this.lblSenhaCorreta.Text = "Senha Correta";
            this.lblSenhaCorreta.Visible = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 349);
            this.Controls.Add(this.lblSenhaCorreta);
            this.Controls.Add(this.lblSenhaValida);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.tbxNumero);
            this.Controls.Add(this.tbxConfirmarSenha);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.fotopictureBox);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(662, 388);
            this.MinimumSize = new System.Drawing.Size(662, 388);
            this.Name = "frmCadastro";
            this.Text = "Novo Usuário-Air System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastro_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotopictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.PictureBox fotopictureBox;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxConfirmarSenha;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblSenhaValida;
        private System.Windows.Forms.Label lblSenhaCorreta;
    }
}
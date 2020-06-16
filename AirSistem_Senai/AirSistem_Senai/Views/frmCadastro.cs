using AirSistem_Senai.Models;
using AirSistem_Senai.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSistem_Senai.Views
{
    public partial class frmCadastro : Form
    {
        Usuario usuario = new Usuario();

        public frmCadastro()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public frmCadastro(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            if( usuario != null)
            {
                tbxNome.Text = usuario.nome;
                tbxSobrenome.Text = usuario.sobrenome;
                tbxEndereco.Text = usuario.endereco;
                tbxNumero.Text = usuario.numero;
                tbxUsuario.Text = usuario.usuario;
                tbxSenha.Text = usuario.senha;
            }

            tbxNome.Text = "Digite seu " + tbxNome.AccessibleName;
            tbxSobrenome.Text = "Digite seu " + tbxSobrenome.AccessibleName;
            tbxEndereco.Text = "Digite seu " + tbxEndereco.AccessibleName;
            tbxNumero.Text = "N° ";
            tbxUsuario.Text = "Digite seu " + tbxUsuario.AccessibleName;
            tbxSenha.Text = "Digite seu " + tbxSenha.AccessibleName;
            tbxConfirmarSenha.Text = "Digite seu " + tbxConfirmarSenha.AccessibleName;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotopictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            fotopictureBox.Image = null;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!Utils.temCamposVazio(this))
            {
                UsuarioRepository repository = new UsuarioRepository();
                if (this.usuario == null)
                {
                    Usuario usuario = new Usuario
                    {
                        nome = tbxNome.Text,
                        sobrenome = tbxSobrenome.Text,
                        endereco = tbxEndereco.Text,
                        numero = tbxNumero.Text,
                        usuario = tbxUsuario.Text,
                        senha = tbxSenha.Text
                    };

                    repository.adicionar(usuario);

                    MessageBox.Show("Dados salvos.", "Aviso",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                this.Close();
             
            }
            else
            {
                MessageBox.Show("Todos os campos são obrigatórios.",
                                "Aviso", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

            }

        }

        bool isPasswordRight;
        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            this.usuario.senha = tbxSenha.Text;

            if (usuario.senha.Length >= 8)
            {
                string pattern = "[a-z]{1,}";

                if(Regex.IsMatch(usuario.senha, pattern))
                {
                    pattern = "[A-Z]{1,}";


                    if (Regex.IsMatch(usuario.senha, pattern))
                    {
                        pattern = "[0-9]{1,}";

                        if (Regex.IsMatch(usuario.senha, pattern))
                        {
                            isPasswordRight = Regex.IsMatch(tbxSenha.Text, pattern);
                            lblSenhaValida.Visible = true;
                        }
                    }
                }
            }
            else
            {
                lblSenhaValida.Visible = false;
            }

            

        }

        private void tbxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (tbxSenha.Text == tbxConfirmarSenha.Text)
            {
                lblSenhaCorreta.Visible = true;
            }
            else
            {
                lblSenhaCorreta.Visible = false;
            }
            
            
        }

        private void frmCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmarção",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Inputs_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if(txt != null)
            {
                txt.BackColor = Color.LightYellow;
                if(txt.Text== "Digite seu " + txt.AccessibleName)
                {
                    txt.Text = "" ;
                }
            }
            
                
            
        }

        private void Inputs_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.White;
                if (txt.Text == "")
                {
                    txt.Text = "Digite seu " + txt.AccessibleName;
                }
            }
        }

    }
}

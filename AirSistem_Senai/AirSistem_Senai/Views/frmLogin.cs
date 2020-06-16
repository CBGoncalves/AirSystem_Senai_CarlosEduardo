using AirSistem_Senai.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSistem_Senai
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text.Trim().Length == 0)
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Digite um usuário e uma senha", "Erro");
            }
            if (tbxUsuario.Text == "adm")
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmPrincipalAdm().ShowDialog();
            }
            if (tbxUsuario.Text.Trim().Length >= 1) 
            {
                MessageBox.Show("Bem Vindo", "Entrada");
                new frmPrincipalUsuario().ShowDialog();
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmarção",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnNovoUsuário_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        
        }


        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Confirmarção",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }
    }
}

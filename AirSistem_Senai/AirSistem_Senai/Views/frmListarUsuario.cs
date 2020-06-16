using AirSistem_Senai.Models;
using AirSistem_Senai.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSistem_Senai.Views
{
    public partial class frmListarUsuario : Form
    {
        UsuarioRepository repository = new UsuarioRepository();

        Usuario usuario = new Usuario();


        public frmListarUsuario()
        {
            InitializeComponent();
        }

        private void frmListarUsuario_Load(object sender, EventArgs e)
        {
            carregaLista();
        }

        private void carregaLista()
        {
            UsuarioRepository repository = new UsuarioRepository();
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = repository.buscarTodos();
            alterarContador();
        }

        private void alterarContador()
        {
            lblContador.Text = $"{dgvListaUsuario.RowCount} itens de {repository.buscarTodos().Count}";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            new frmCadastro().ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.usuario.nome = tbxNome.Text;
            this.usuario.sobrenome = tbxSobrenome.Text;
            this.usuario.endereco = tbxEndereco.Text;
            this.usuario.numero = tbxNumero.Text;
            this.usuario.usuario = tbxUsuario.Text;
            this.usuario.senha = tbxSenha.Text;

            repository.editar(usuario);
            carregaLista();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvListaUsuario.DataSource = null;

            dgvListaUsuario.DataSource = repository.buscarTodos().FindAll(x =>
                x.nome.ToUpper().Contains(tbxFiltro.Text.ToUpper())
                
            );
        }

        private void dgvListaUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];
            string nome = linha.Cells[1].Value.ToString();
            string sobrenome = linha.Cells[2].Value.ToString();
            string endereco = linha.Cells[3].Value.ToString();
            string numero = linha.Cells[4].Value.ToString();
            string username = linha.Cells[5].Value.ToString();
            string senha = linha.Cells[6].Value.ToString();
            int id = Convert.ToInt32(linha.Cells[0].Value.ToString());


            Usuario usuario = new Usuario
            {
                id = id,
                nome = nome,
                sobrenome = sobrenome,
                endereco = endereco,
                numero = numero,
                usuario = username,
                senha = senha,

            };

            
        }


        private void dgvListaUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dr = MessageBox.Show("Deseja excluir este usuário?", "Atenção"
                    , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

                    int id = Convert.ToInt32(linha.Cells[0].Value.ToString());

                    repository.deletar(id);

                    carregaLista();
                }
            }
        }
    }
}

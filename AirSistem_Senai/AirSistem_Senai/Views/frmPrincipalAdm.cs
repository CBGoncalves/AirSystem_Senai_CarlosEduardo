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
    public partial class frmPrincipalAdm : Form
    {
        public frmPrincipalAdm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarUsuario newMDIChild = new frmListarUsuario();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}

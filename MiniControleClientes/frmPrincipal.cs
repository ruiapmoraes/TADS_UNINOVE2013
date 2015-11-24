using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniControleClientes.Views;

namespace MiniControleClientes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClienteCadastro telaClienteCadastro = new frmClienteCadastro();
            telaClienteCadastro.MdiParent = this;
            telaClienteCadastro.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedorCadastro telaForCadastro = new frmFornecedorCadastro();
            telaForCadastro.MdiParent = this;
            telaForCadastro.Show();
        }
    }
}

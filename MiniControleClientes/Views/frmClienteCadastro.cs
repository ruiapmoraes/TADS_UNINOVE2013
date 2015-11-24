using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniControleClientes.Views
{
    public partial class frmClienteCadastro : Form
    {
        public frmClienteCadastro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão para criar um novo cadastro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        /// <summary>
        /// Limpar campos da tela
        /// </summary>
        private void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCEP.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }
    }
}

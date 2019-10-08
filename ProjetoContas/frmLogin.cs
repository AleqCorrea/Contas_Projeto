using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "ADM" && txtSenha.Text == "421")
            {
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logar()
        {
            if (txtLogin.Text == "ADM" && txtSenha.Text == "421")
            {
                frmPrincipal fp = new frmPrincipal();
                fp.Show();
            }
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }

        }

        private void txtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logar();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

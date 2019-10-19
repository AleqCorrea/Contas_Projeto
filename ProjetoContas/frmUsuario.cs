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
    public partial class frmUsuario : Form
    {
        public static int codigo;
        private void Habilita()
        {
            cd_usuarioTextBox.Enabled = false;
            nm_usuarioTextBox.Enabled = true;
            sg_nivelTextBox.Enabled = true;
            nm_loginTextBox.Enabled = true;
            ds_senhaTextBox.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;

        }
        private void Desabilita()
        {
            cd_usuarioTextBox.Enabled = true;
            nm_usuarioTextBox.Enabled = false;
            sg_nivelTextBox.Enabled = false;
            nm_loginTextBox.Enabled = false;
            ds_senhaTextBox.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true; ;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;

        }
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.contasDataSet.tbUsuario);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbUsuarioBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbUsuarioBindingSource.EndEdit();
            tbUsuarioTableAdapter.Update(this.contasDataSet.tbUsuario);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.MoveNext();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbUsuarioBindingSource.CancelEdit();
            Desabilita();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Habilita();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(tbUsuarioBindingSource.Count > 0)
            {
                tbUsuarioBindingSource.RemoveCurrent();
                tbUsuarioTableAdapter.Update(contasDataSet.tbUsuario);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            frnPesquisarUsuario fpu = new frnPesquisarUsuario();
            fpu.ShowDialog();

            if(codigo > 0)
            {
                reg = tbUsuarioBindingSource.Find("cd_usuario", codigo);
                tbUsuarioBindingSource.Position = reg;
            }
        }
    }
}

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
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.contasDataSet.tbCliente);

        }

        private void tbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmCliente.codigo = int.Parse(tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        private void Pesquisar()
        {
            if (txtNome.Text == "")
            {
                tbClienteTableAdapter.Fill(contasDataSet.tbCliente);
            }
            else
            {
                tbClienteTableAdapter.FillByNome(contasDataSet.tbCliente, "%" + txtNome.Text + "%");
            }
        }
    }
}

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
    public partial class frmPesquisarPagar : Form
    {
        public frmPesquisarPagar()
        {
            InitializeComponent();
        }

        private void tbContasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisarPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagarTableAdapter.Fill(this.contasDataSet.tbContasPagar);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void tbContasPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmContasPagar.codigo = int.Parse(tbContasPagarDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
        private void Pesquisar()
        {
            if (txtPesquisar.Text == "")
            {
                tbContasPagarTableAdapter.Fill(contasDataSet.tbContasPagar);
            }
            else
            {
                tbContasPagarTableAdapter.FillByData(contasDataSet.tbContasPagar, txtPesquisar.Text);
            }
        }
    }
}

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
    public partial class frmPesquisarReceber : Form
    {
        public frmPesquisarReceber()
        {
            InitializeComponent();
        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmPesquisarReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet.tbContasReceber);

        }
        private void Pesquisar()
        {
            if (txtPesquisar.Text == "")
            {
                tbContasReceberTableAdapter.Fill(contasDataSet.tbContasReceber);
            }
            else
            {
                tbContasReceberTableAdapter.FillByData(contasDataSet.tbContasReceber, txtPesquisar.Text);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void tbContasReceberDataGridView_DoubleClick(object sender, EventArgs e)
        {
            frmContasPagar.codigo = int.Parse(tbContasReceberDataGridView.CurrentRow.Cells[0].Value.ToString());
            Close();
        }
    }
}

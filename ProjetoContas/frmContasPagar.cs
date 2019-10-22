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
    public partial class frmContasPagar : Form
    {
        public static int codigo;

        private void Habilita()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            id_fornecedorTextBox.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            ds_obsTextBox.Enabled = true;
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
            cd_contaTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            vl_contaTextBox.Enabled = false;
            id_fornecedorTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            ds_obsTextBox.Enabled = false;
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
        public frmContasPagar()
        {
            InitializeComponent();
        }


        private void tbContasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void ContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasPagarTableAdapter.Fill(this.contasDataSet.tbContasPagar);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbContasPagarBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbContasPagarBindingSource.EndEdit();
            tbContasPagarTableAdapter.Update(this.contasDataSet.tbContasPagar);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.MoveNext();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbContasPagarBindingSource.CancelEdit();
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
            if (tbContasPagarBindingSource.Count > 0)
            {
                tbContasPagarBindingSource.RemoveCurrent();
                tbContasPagarTableAdapter.Update(contasDataSet.tbContasPagar);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;

            Graphics objImpressao = e.Graphics;
            strDados = "FICHA DE USUÁRIO \n" + (char)10;
            strDados = strDados + "Codigo:" + cd_contaTextBox.Text + (char)10;
            strDados = strDados + "Data de Emissão:" + dt_emissaoDateTimePicker.Text + (char)10;
            strDados = strDados + "Data de Vencimento:" + dt_vencimentoDateTimePicker.Text + (char)10;
            strDados = strDados + "Valor da Conta:" + vl_contaTextBox.Text + (char)10;
            strDados = strDados + "Fornecedor:" + id_fornecedorTextBox.Text + (char)10;
            strDados = strDados + "Data do Pagamento:" + dt_pagamentoDateTimePicker.Text + (char)10;
            strDados = strDados + "Valor do Pagamento: " + vl_pagoTextBox.Text + (char)10;
            strDados = strDados + "Observaçoes: " + ds_obsTextBox.Text + (char)10;

            objImpressao.DrawString(strDados, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 50);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int reg;
            codigo = 0;
            frmPesquisarPagar fpu = new frmPesquisarPagar();
            fpu.ShowDialog();

            if (codigo > 0)
            {
                reg = tbContasPagarBindingSource.Find("cd_conta", codigo);
                tbContasPagarBindingSource.Position = reg;
            }
        }
    }
}

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
    public partial class frmContasReceber : Form
    {
        private void Habilita()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_contaTextBox.Enabled = true;
            id_clienteTextBox.Enabled = true;
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
            id_clienteTextBox.Enabled = false;
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
        public frmContasReceber()
        {
            InitializeComponent();
        }

        private void tbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void tbContasReceberBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.contasDataSet);

        }

        private void frmContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'contasDataSet.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.contasDataSet.tbContasReceber);

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Habilita();
            tbContasReceberBindingSource.AddNew();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Desabilita();
            Validate();
            tbContasReceberBindingSource.EndEdit();
            tbContasReceberTableAdapter.Update(this.contasDataSet.tbContasReceber);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.MoveNext();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbContasReceberBindingSource.CancelEdit();
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
            if (tbContasReceberBindingSource.Count > 0)
            {
                tbContasReceberBindingSource.RemoveCurrent();
                tbContasReceberTableAdapter.Update(contasDataSet.tbContasReceber);
            }
        }
    }
}

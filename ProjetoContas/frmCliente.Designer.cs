namespace ProjetoContas
{
    partial class frmCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_clienteLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label ds_telefoneLabel;
            System.Windows.Forms.Label ds_emailLabel;
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.contasDataSet = new ProjetoContas.contasDataSet();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbClienteTableAdapter = new ProjetoContas.contasDataSetTableAdapters.tbClienteTableAdapter();
            this.tableAdapterManager = new ProjetoContas.contasDataSetTableAdapters.TableAdapterManager();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepTextBox = new System.Windows.Forms.TextBox();
            this.ds_telefoneTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            cd_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            ds_telefoneLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_clienteLabel.Location = new System.Drawing.Point(62, 15);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(51, 18);
            cd_clienteLabel.TabIndex = 42;
            cd_clienteLabel.Text = "Código";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_clienteLabel.Location = new System.Drawing.Point(62, 41);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(44, 18);
            nm_clienteLabel.TabIndex = 44;
            nm_clienteLabel.Text = "Nome";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_enderecoLabel.Location = new System.Drawing.Point(62, 67);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(67, 18);
            ds_enderecoLabel.TabIndex = 46;
            ds_enderecoLabel.Text = "Endereço";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_cidadeLabel.Location = new System.Drawing.Point(62, 93);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(51, 18);
            nm_cidadeLabel.TabIndex = 48;
            nm_cidadeLabel.Text = "Cidade";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nm_bairroLabel.Location = new System.Drawing.Point(62, 119);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(50, 18);
            nm_bairroLabel.TabIndex = 50;
            nm_bairroLabel.Text = "Bairro";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sg_estadoLabel.Location = new System.Drawing.Point(62, 145);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(52, 18);
            sg_estadoLabel.TabIndex = 52;
            sg_estadoLabel.Text = "Estado";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cd_cepLabel.Location = new System.Drawing.Point(62, 171);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(38, 18);
            cd_cepLabel.TabIndex = 54;
            cd_cepLabel.Text = "CEP";
            // 
            // ds_telefoneLabel
            // 
            ds_telefoneLabel.AutoSize = true;
            ds_telefoneLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_telefoneLabel.Location = new System.Drawing.Point(62, 197);
            ds_telefoneLabel.Name = "ds_telefoneLabel";
            ds_telefoneLabel.Size = new System.Drawing.Size(63, 18);
            ds_telefoneLabel.TabIndex = 56;
            ds_telefoneLabel.Text = "Telefone";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_emailLabel.Location = new System.Drawing.Point(62, 223);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(48, 18);
            ds_emailLabel.TabIndex = 58;
            ds_emailLabel.Text = "Email";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(236, 320);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 25);
            this.btnSair.TabIndex = 41;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(84, 320);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 25);
            this.btnImprimir.TabIndex = 40;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(160, 320);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 25);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(8, 320);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(70, 25);
            this.btnPesquisar.TabIndex = 38;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(236, 289);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 25);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(160, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 25);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(84, 289);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(70, 25);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(8, 289);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(70, 25);
            this.btnNovo.TabIndex = 34;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(312, 289);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(70, 25);
            this.btnProximo.TabIndex = 33;
            this.btnProximo.Text = "Próximo ";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(312, 320);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(70, 25);
            this.btnAnterior.TabIndex = 32;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // contasDataSet
            // 
            this.contasDataSet.DataSetName = "contasDataSet";
            this.contasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.contasDataSet;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbContasPagarTableAdapter = null;
            this.tableAdapterManager.tbContasReceberTableAdapter = null;
            this.tableAdapterManager.tbFornecedorTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProjetoContas.contasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Location = new System.Drawing.Point(135, 12);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.ReadOnly = true;
            this.cd_clienteTextBox.Size = new System.Drawing.Size(39, 20);
            this.cd_clienteTextBox.TabIndex = 43;
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_cliente", true));
            this.nm_clienteTextBox.Location = new System.Drawing.Point(135, 38);
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(201, 20);
            this.nm_clienteTextBox.TabIndex = 45;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(135, 64);
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(201, 20);
            this.ds_enderecoTextBox.TabIndex = 47;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(135, 90);
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(125, 20);
            this.nm_cidadeTextBox.TabIndex = 49;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Location = new System.Drawing.Point(135, 116);
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(125, 20);
            this.nm_bairroTextBox.TabIndex = 51;
            // 
            // sg_estadoTextBox
            // 
            this.sg_estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "sg_estado", true));
            this.sg_estadoTextBox.Location = new System.Drawing.Point(135, 142);
            this.sg_estadoTextBox.Name = "sg_estadoTextBox";
            this.sg_estadoTextBox.Size = new System.Drawing.Size(49, 20);
            this.sg_estadoTextBox.TabIndex = 53;
            // 
            // cd_cepTextBox
            // 
            this.cd_cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "cd_cep", true));
            this.cd_cepTextBox.Location = new System.Drawing.Point(135, 168);
            this.cd_cepTextBox.Name = "cd_cepTextBox";
            this.cd_cepTextBox.Size = new System.Drawing.Size(125, 20);
            this.cd_cepTextBox.TabIndex = 55;
            // 
            // ds_telefoneTextBox
            // 
            this.ds_telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_telefone", true));
            this.ds_telefoneTextBox.Location = new System.Drawing.Point(135, 194);
            this.ds_telefoneTextBox.Name = "ds_telefoneTextBox";
            this.ds_telefoneTextBox.Size = new System.Drawing.Size(125, 20);
            this.ds_telefoneTextBox.TabIndex = 57;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "ds_email", true));
            this.ds_emailTextBox.Location = new System.Drawing.Point(135, 220);
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(125, 20);
            this.ds_emailTextBox.TabIndex = 59;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 365);
            this.ControlBox = false;
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(this.sg_estadoTextBox);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(this.cd_cepTextBox);
            this.Controls.Add(ds_telefoneLabel);
            this.Controls.Add(this.ds_telefoneTextBox);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(this.ds_emailTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private contasDataSet contasDataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private contasDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private contasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.TextBox nm_clienteTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox sg_estadoTextBox;
        private System.Windows.Forms.TextBox cd_cepTextBox;
        private System.Windows.Forms.TextBox ds_telefoneTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
    }
}
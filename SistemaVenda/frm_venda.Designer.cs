namespace SistemaVenda
{
    partial class frm_venda
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
            System.Windows.Forms.Label codigoPessoaLabel;
            System.Windows.Forms.Label codigoVendaLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label codigoProdutoLabel;
            System.Windows.Forms.Label lbl_pgto;
            System.Windows.Forms.Label lbl_dataVencimento;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_venda));
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_Clientes = new System.Windows.Forms.ComboBox();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_NovaVenda = new System.Windows.Forms.Button();
            this.GB_NovaVenda = new System.Windows.Forms.GroupBox();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.DataVencimento = new System.Windows.Forms.DateTimePicker();
            this.contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CB_Pgto = new System.Windows.Forms.ComboBox();
            this.statusPagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_FinVenda = new System.Windows.Forms.Button();
            this.btn_FinPedido = new System.Windows.Forms.Button();
            this.txt_ValorPago = new System.Windows.Forms.TextBox();
            this.txt_Desconto = new System.Windows.Forms.TextBox();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.lbl_ValorTotal = new System.Windows.Forms.Label();
            this.lbl_Desconto = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.CB_Produtos = new System.Windows.Forms.ComboBox();
            this.itensVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DG_Vendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_Valor = new System.Windows.Forms.TextBox();
            this.txt_quant = new System.Windows.Forms.TextBox();
            this.txt_codVenda = new System.Windows.Forms.TextBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            codigoPessoaLabel = new System.Windows.Forms.Label();
            codigoVendaLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            codigoProdutoLabel = new System.Windows.Forms.Label();
            lbl_pgto = new System.Windows.Forms.Label();
            lbl_dataVencimento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            this.GB_NovaVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // codigoPessoaLabel
            // 
            codigoPessoaLabel.AutoSize = true;
            codigoPessoaLabel.Location = new System.Drawing.Point(17, 25);
            codigoPessoaLabel.Name = "codigoPessoaLabel";
            codigoPessoaLabel.Size = new System.Drawing.Size(42, 13);
            codigoPessoaLabel.TabIndex = 1;
            codigoPessoaLabel.Text = "Cliente:";
            // 
            // codigoVendaLabel
            // 
            codigoVendaLabel.AutoSize = true;
            codigoVendaLabel.Location = new System.Drawing.Point(7, 24);
            codigoVendaLabel.Name = "codigoVendaLabel";
            codigoVendaLabel.Size = new System.Drawing.Size(77, 13);
            codigoVendaLabel.TabIndex = 0;
            codigoVendaLabel.Text = "Codigo Venda:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(7, 73);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 4;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.Location = new System.Drawing.Point(7, 101);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(34, 13);
            valorLabel.TabIndex = 6;
            valorLabel.Text = "Valor:";
            // 
            // codigoProdutoLabel
            // 
            codigoProdutoLabel.AutoSize = true;
            codigoProdutoLabel.Location = new System.Drawing.Point(7, 49);
            codigoProdutoLabel.Name = "codigoProdutoLabel";
            codigoProdutoLabel.Size = new System.Drawing.Size(47, 13);
            codigoProdutoLabel.TabIndex = 8;
            codigoProdutoLabel.Text = "Produto:";
            // 
            // lbl_pgto
            // 
            lbl_pgto.AutoSize = true;
            lbl_pgto.Location = new System.Drawing.Point(600, 295);
            lbl_pgto.Name = "lbl_pgto";
            lbl_pgto.Size = new System.Drawing.Size(110, 13);
            lbl_pgto.TabIndex = 19;
            lbl_pgto.Text = "Forma de pagamento:";
            // 
            // lbl_dataVencimento
            // 
            lbl_dataVencimento.AutoSize = true;
            lbl_dataVencimento.Location = new System.Drawing.Point(600, 328);
            lbl_dataVencimento.Name = "lbl_dataVencimento";
            lbl_dataVencimento.Size = new System.Drawing.Size(92, 13);
            lbl_dataVencimento.TabIndex = 21;
            lbl_dataVencimento.Text = "Data Vencimento:";
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataSource = typeof(Sistema.DAL.Venda);
            // 
            // CB_Clientes
            // 
            this.CB_Clientes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vendaBindingSource, "CodigoPessoa", true));
            this.CB_Clientes.DataSource = this.pessoaBindingSource;
            this.CB_Clientes.DisplayMember = "Nome";
            this.CB_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Clientes.FormattingEnabled = true;
            this.CB_Clientes.Location = new System.Drawing.Point(65, 22);
            this.CB_Clientes.Name = "CB_Clientes";
            this.CB_Clientes.Size = new System.Drawing.Size(121, 21);
            this.CB_Clientes.TabIndex = 2;
            this.CB_Clientes.ValueMember = "CodigoPessoa";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Sistema.DAL.Pessoa);
            // 
            // btn_NovaVenda
            // 
            this.btn_NovaVenda.Location = new System.Drawing.Point(220, 22);
            this.btn_NovaVenda.Name = "btn_NovaVenda";
            this.btn_NovaVenda.Size = new System.Drawing.Size(75, 23);
            this.btn_NovaVenda.TabIndex = 3;
            this.btn_NovaVenda.Text = "Nova Venda";
            this.btn_NovaVenda.UseVisualStyleBackColor = true;
            this.btn_NovaVenda.Click += new System.EventHandler(this.btn_NovaVenda_Click);
            // 
            // GB_NovaVenda
            // 
            this.GB_NovaVenda.Controls.Add(this.btn_finalizar);
            this.GB_NovaVenda.Controls.Add(lbl_dataVencimento);
            this.GB_NovaVenda.Controls.Add(this.DataVencimento);
            this.GB_NovaVenda.Controls.Add(lbl_pgto);
            this.GB_NovaVenda.Controls.Add(this.CB_Pgto);
            this.GB_NovaVenda.Controls.Add(this.btn_Imprimir);
            this.GB_NovaVenda.Controls.Add(this.btn_FinVenda);
            this.GB_NovaVenda.Controls.Add(this.btn_FinPedido);
            this.GB_NovaVenda.Controls.Add(this.txt_ValorPago);
            this.GB_NovaVenda.Controls.Add(this.txt_Desconto);
            this.GB_NovaVenda.Controls.Add(this.txt_Valor);
            this.GB_NovaVenda.Controls.Add(this.lbl_ValorTotal);
            this.GB_NovaVenda.Controls.Add(this.lbl_Desconto);
            this.GB_NovaVenda.Controls.Add(this.lbl_valor);
            this.GB_NovaVenda.Controls.Add(this.btnNovoItem);
            this.GB_NovaVenda.Controls.Add(codigoProdutoLabel);
            this.GB_NovaVenda.Controls.Add(this.CB_Produtos);
            this.GB_NovaVenda.Controls.Add(this.DG_Vendas);
            this.GB_NovaVenda.Controls.Add(valorLabel);
            this.GB_NovaVenda.Controls.Add(this.txb_Valor);
            this.GB_NovaVenda.Controls.Add(quantidadeLabel);
            this.GB_NovaVenda.Controls.Add(this.txt_quant);
            this.GB_NovaVenda.Controls.Add(codigoVendaLabel);
            this.GB_NovaVenda.Controls.Add(this.txt_codVenda);
            this.GB_NovaVenda.Location = new System.Drawing.Point(12, 60);
            this.GB_NovaVenda.Name = "GB_NovaVenda";
            this.GB_NovaVenda.Size = new System.Drawing.Size(851, 392);
            this.GB_NovaVenda.TabIndex = 4;
            this.GB_NovaVenda.TabStop = false;
            this.GB_NovaVenda.Text = "Nova Venda";
            this.GB_NovaVenda.Visible = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Enabled = false;
            this.btn_finalizar.Location = new System.Drawing.Point(744, 352);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(91, 23);
            this.btn_finalizar.TabIndex = 23;
            this.btn_finalizar.Text = "Finalizar";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // DataVencimento
            // 
            this.DataVencimento.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasReceberBindingSource, "DataVencimento", true));
            this.DataVencimento.Enabled = false;
            this.DataVencimento.Location = new System.Drawing.Point(713, 324);
            this.DataVencimento.Name = "DataVencimento";
            this.DataVencimento.Size = new System.Drawing.Size(121, 20);
            this.DataVencimento.TabIndex = 22;
            // 
            // contasReceberBindingSource
            // 
            this.contasReceberBindingSource.DataSource = typeof(Sistema.DAL.ContasReceber);
            // 
            // CB_Pgto
            // 
            this.CB_Pgto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contasReceberBindingSource, "CodigoStatus", true));
            this.CB_Pgto.DataSource = this.statusPagamentoBindingSource;
            this.CB_Pgto.DisplayMember = "Status";
            this.CB_Pgto.Enabled = false;
            this.CB_Pgto.FormattingEnabled = true;
            this.CB_Pgto.Location = new System.Drawing.Point(713, 292);
            this.CB_Pgto.Name = "CB_Pgto";
            this.CB_Pgto.Size = new System.Drawing.Size(121, 21);
            this.CB_Pgto.TabIndex = 20;
            this.CB_Pgto.ValueMember = "CodigoStatus";
            this.CB_Pgto.SelectedIndexChanged += new System.EventHandler(this.CB_Pgto_SelectedIndexChanged);
            // 
            // statusPagamentoBindingSource
            // 
            this.statusPagamentoBindingSource.DataSource = typeof(Sistema.DAL.StatusPagamento);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Enabled = false;
            this.btn_Imprimir.Location = new System.Drawing.Point(1, 349);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(91, 23);
            this.btn_Imprimir.TabIndex = 19;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_FinVenda
            // 
            this.btn_FinVenda.Enabled = false;
            this.btn_FinVenda.Location = new System.Drawing.Point(1, 319);
            this.btn_FinVenda.Name = "btn_FinVenda";
            this.btn_FinVenda.Size = new System.Drawing.Size(91, 23);
            this.btn_FinVenda.TabIndex = 18;
            this.btn_FinVenda.Text = "Finalizar Venda";
            this.btn_FinVenda.UseVisualStyleBackColor = true;
            this.btn_FinVenda.Click += new System.EventHandler(this.btn_FinVenda_Click);
            // 
            // btn_FinPedido
            // 
            this.btn_FinPedido.Location = new System.Drawing.Point(1, 290);
            this.btn_FinPedido.Name = "btn_FinPedido";
            this.btn_FinPedido.Size = new System.Drawing.Size(91, 23);
            this.btn_FinPedido.TabIndex = 17;
            this.btn_FinPedido.Text = "Finalizar Pedido";
            this.btn_FinPedido.UseVisualStyleBackColor = true;
            this.btn_FinPedido.Click += new System.EventHandler(this.btn_FinPedido_Click);
            // 
            // txt_ValorPago
            // 
            this.txt_ValorPago.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "ValorPago", true));
            this.txt_ValorPago.Location = new System.Drawing.Point(157, 352);
            this.txt_ValorPago.Name = "txt_ValorPago";
            this.txt_ValorPago.ReadOnly = true;
            this.txt_ValorPago.Size = new System.Drawing.Size(100, 20);
            this.txt_ValorPago.TabIndex = 16;
            // 
            // txt_Desconto
            // 
            this.txt_Desconto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Desconto", true));
            this.txt_Desconto.Location = new System.Drawing.Point(157, 321);
            this.txt_Desconto.Name = "txt_Desconto";
            this.txt_Desconto.ReadOnly = true;
            this.txt_Desconto.Size = new System.Drawing.Size(100, 20);
            this.txt_Desconto.TabIndex = 15;
            // 
            // txt_Valor
            // 
            this.txt_Valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "Valor", true));
            this.txt_Valor.Location = new System.Drawing.Point(157, 290);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.ReadOnly = true;
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 14;
            // 
            // lbl_ValorTotal
            // 
            this.lbl_ValorTotal.AutoSize = true;
            this.lbl_ValorTotal.Location = new System.Drawing.Point(98, 355);
            this.lbl_ValorTotal.Name = "lbl_ValorTotal";
            this.lbl_ValorTotal.Size = new System.Drawing.Size(57, 13);
            this.lbl_ValorTotal.TabIndex = 13;
            this.lbl_ValorTotal.Text = "Valor total:";
            // 
            // lbl_Desconto
            // 
            this.lbl_Desconto.AutoSize = true;
            this.lbl_Desconto.Location = new System.Drawing.Point(98, 324);
            this.lbl_Desconto.Name = "lbl_Desconto";
            this.lbl_Desconto.Size = new System.Drawing.Size(56, 13);
            this.lbl_Desconto.TabIndex = 12;
            this.lbl_Desconto.Text = "Desconto:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(98, 293);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(34, 13);
            this.lbl_valor.TabIndex = 11;
            this.lbl_valor.Text = "Valor:";
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Location = new System.Drawing.Point(115, 143);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(75, 23);
            this.btnNovoItem.TabIndex = 10;
            this.btnNovoItem.Text = "Novo Item";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // CB_Produtos
            // 
            this.CB_Produtos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.itensVendaBindingSource, "CodigoProduto", true));
            this.CB_Produtos.DataSource = this.produtoBindingSource;
            this.CB_Produtos.DisplayMember = "Descricao";
            this.CB_Produtos.FormattingEnabled = true;
            this.CB_Produtos.Location = new System.Drawing.Point(90, 46);
            this.CB_Produtos.Name = "CB_Produtos";
            this.CB_Produtos.Size = new System.Drawing.Size(193, 21);
            this.CB_Produtos.TabIndex = 9;
            this.CB_Produtos.ValueMember = "Codigo";
            this.CB_Produtos.SelectedIndexChanged += new System.EventHandler(this.codigoProdutoComboBox_SelectedIndexChanged);
            // 
            // itensVendaBindingSource
            // 
            this.itensVendaBindingSource.DataSource = typeof(Sistema.DAL.ItensVenda);
            // 
            // produtoBindingSource
            // 
            this.produtoBindingSource.DataSource = typeof(Sistema.DAL.Produto);
            // 
            // DG_Vendas
            // 
            this.DG_Vendas.AllowUserToAddRows = false;
            this.DG_Vendas.AllowUserToDeleteRows = false;
            this.DG_Vendas.AutoGenerateColumns = false;
            this.DG_Vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.Column1});
            this.DG_Vendas.DataSource = this.itensVendaBindingSource;
            this.DG_Vendas.Location = new System.Drawing.Point(301, 19);
            this.DG_Vendas.Name = "DG_Vendas";
            this.DG_Vendas.ReadOnly = true;
            this.DG_Vendas.Size = new System.Drawing.Size(534, 241);
            this.DG_Vendas.TabIndex = 8;
            this.DG_Vendas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DG_Vendas_CellFormatting);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CodigoProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Quantidade";
            this.dataGridViewTextBoxColumn1.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Valor Total";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txb_Valor
            // 
            this.txb_Valor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.produtoBindingSource, "Valor", true));
            this.txb_Valor.Location = new System.Drawing.Point(90, 101);
            this.txb_Valor.Name = "txb_Valor";
            this.txb_Valor.ReadOnly = true;
            this.txb_Valor.Size = new System.Drawing.Size(100, 20);
            this.txb_Valor.TabIndex = 7;
            // 
            // txt_quant
            // 
            this.txt_quant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itensVendaBindingSource, "Quantidade", true));
            this.txt_quant.Location = new System.Drawing.Point(90, 73);
            this.txt_quant.Name = "txt_quant";
            this.txt_quant.Size = new System.Drawing.Size(100, 20);
            this.txt_quant.TabIndex = 5;
            // 
            // txt_codVenda
            // 
            this.txt_codVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendaBindingSource, "CodigoVenda", true));
            this.txt_codVenda.Location = new System.Drawing.Point(90, 21);
            this.txt_codVenda.Name = "txt_codVenda";
            this.txt_codVenda.ReadOnly = true;
            this.txt_codVenda.Size = new System.Drawing.Size(100, 20);
            this.txt_codVenda.TabIndex = 1;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(772, 22);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 452);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.GB_NovaVenda);
            this.Controls.Add(this.btn_NovaVenda);
            this.Controls.Add(codigoPessoaLabel);
            this.Controls.Add(this.CB_Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.frm_venda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            this.GB_NovaVenda.ResumeLayout(false);
            this.GB_NovaVenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusPagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itensVendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Vendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendaBindingSource;
        private System.Windows.Forms.ComboBox CB_Clientes;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.Button btn_NovaVenda;
        private System.Windows.Forms.GroupBox GB_NovaVenda;
        private System.Windows.Forms.TextBox txb_Valor;
        private System.Windows.Forms.BindingSource itensVendaBindingSource;
        private System.Windows.Forms.TextBox txt_quant;
        private System.Windows.Forms.TextBox txt_codVenda;
        private System.Windows.Forms.ComboBox CB_Produtos;
        private System.Windows.Forms.BindingSource produtoBindingSource;
        private System.Windows.Forms.DataGridView DG_Vendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btn_FinVenda;
        private System.Windows.Forms.Button btn_FinPedido;
        private System.Windows.Forms.TextBox txt_ValorPago;
        private System.Windows.Forms.TextBox txt_Desconto;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label lbl_ValorTotal;
        private System.Windows.Forms.Label lbl_Desconto;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.DateTimePicker DataVencimento;
        private System.Windows.Forms.BindingSource contasReceberBindingSource;
        private System.Windows.Forms.ComboBox CB_Pgto;
        private System.Windows.Forms.BindingSource statusPagamentoBindingSource;
        private System.Windows.Forms.Button btn_voltar;
    }
}
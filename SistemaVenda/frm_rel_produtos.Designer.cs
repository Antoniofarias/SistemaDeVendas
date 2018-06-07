namespace SistemaVenda
{
    partial class frm_rel_produtos
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tb_produtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_relatorios_produtos = new SistemaVenda.DS_relatorios_produtos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tb_produtoTableAdapter = new SistemaVenda.DS_relatorios_produtosTableAdapters.tb_produtoTableAdapter();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_relatorios_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_produtoBindingSource
            // 
            this.tb_produtoBindingSource.DataMember = "tb_produto";
            this.tb_produtoBindingSource.DataSource = this.DS_relatorios_produtos;
            // 
            // DS_relatorios_produtos
            // 
            this.DS_relatorios_produtos.DataSetName = "DS_relatorios_produtos";
            this.DS_relatorios_produtos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tb_produtoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaVenda.Relatórios.rel_produtos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 35);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(519, 415);
            this.reportViewer1.TabIndex = 0;
            // 
            // tb_produtoTableAdapter
            // 
            this.tb_produtoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(432, 6);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_rel_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rel_produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.frm_rel_produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_produtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_relatorios_produtos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tb_produtoBindingSource;
        private DS_relatorios_produtos DS_relatorios_produtos;
        private DS_relatorios_produtosTableAdapters.tb_produtoTableAdapter tb_produtoTableAdapter;
        private System.Windows.Forms.Button btn_voltar;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.DAL;

namespace SistemaVenda
{
    public partial class frm_venda : Form
    {
        public frm_venda()
        {
            InitializeComponent();
        }

        private void frm_venda_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
            this.vendaBindingSource.DataSource = DataContextFactory.DataContext.Vendas;
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.contasReceberBindingSource.DataSource = DataContextFactory.DataContext.ContasRecebers;
            this.statusPagamentoBindingSource.DataSource = DataContextFactory.DataContext.StatusPagamentos;

            this.vendaBindingSource.AddNew();
        }

        public Venda VendaCorrente
        {
            get
            {
                return (Venda)this.vendaBindingSource.Current;
            }
        }

        public ItensVenda ItemCorrente
        {
            get
            {
                return (ItensVenda)this.itensVendaBindingSource.Current;
            }
        }

        public ContasReceber ContaCorrente
        {
            get
            {
                return (ContasReceber)this.contasReceberBindingSource.Current;
            }
        }

        private void btn_NovaVenda_Click(object sender, EventArgs e)
        {
            this.vendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            GB_NovaVenda.Visible = true;
            btn_NovaVenda.Enabled = false;

            this.itensVendaBindingSource.DataSource = DataContextFactory.DataContext.ItensVendas.Where (x => x.CodigoProduto == this.VendaCorrente.CodigoVenda);
            NovoItem();
        }

        private void NovoItem()
        {
            this.itensVendaBindingSource.AddNew();
            this.ItemCorrente.CodigoVenda = this.VendaCorrente.CodigoVenda;
            this.ItemCorrente.Quantidade = 1;
            
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            this.itensVendaBindingSource.EndEdit();
            DG_Vendas.Refresh();
            DataContextFactory.DataContext.SubmitChanges();
            MostraSomaValores();
            NovoItem();
            CB_Clientes.Enabled = false;
        }

        private void DG_Vendas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 1)
                e.Value = ((Produto)e.Value).Descricao;
        }

        private void codigoProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Produtos.SelectedItem != null)
            {
                var pro = (Produto)CB_Produtos.SelectedItem;
                this.ItemCorrente.CodigoProduto = pro.Codigo;
                this.ItemCorrente.Valor = (decimal)pro.Valor;
            }
        }

        private void MostraSomaValores()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in DG_Vendas.Rows)
            {
                decimal v1 = Convert.ToDecimal(dg.Cells[2].Value);
                decimal v2 = Convert.ToDecimal(dg.Cells[3].Value);
                decimal subtotal = v1 * v2;
                dg.Cells[4].Value = subtotal;
                total = total + subtotal;
            }

            this.VendaCorrente.Valor = total;
        }

        private void btn_FinPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja finalizar o pedido", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.itensVendaBindingSource.CancelEdit();
                DataContextFactory.DataContext.SubmitChanges();
                this.VendaCorrente.Desconto = 0;
                btnNovoItem.Enabled = false;
                CB_Produtos.Enabled = false;
                txt_quant.Enabled = false;
                txt_Desconto.ReadOnly = false;
                txt_Desconto.Focus();
                btn_FinPedido.Enabled = false;
                btn_FinVenda.Enabled = true;
                txt_codVenda.Enabled = false;
                txt_Valor.Enabled = false;

            }
        }

        private void btn_FinVenda_Click(object sender, EventArgs e)
        {
            this.VendaCorrente.Desconto = Convert.ToDecimal(txt_Desconto.Text);
            this.VendaCorrente.ValorPago = (decimal)(this.VendaCorrente.Valor - this.VendaCorrente.Desconto);
            this.itensVendaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            txt_Desconto.Enabled = false;
            btn_FinVenda.Enabled = false;
            //btn_Imprimir.Enabled = true;
            CB_Pgto.Enabled = true;
            this.contasReceberBindingSource.AddNew();
            this.ContaCorrente.CodigoVenda = this.ContaCorrente.CodigoVenda;
            this.ContaCorrente.DataCompra = DateTime.Now;
            this.ContaCorrente.DataVencimento = DateTime.Now;
        }

        private void CB_Pgto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_Pgto.SelectedItem != null)
            {
                var status = (StatusPagamento)CB_Pgto.SelectedItem;
                if (status.CodigoStatus == 1)
                {
                    this.ContaCorrente.CodigoStatus = status.CodigoStatus;
                    this.ContaCorrente.DataCompra = DateTime.Now;
                    this.ContaCorrente.DataCompra = null;
                    btn_finalizar.Enabled = true;
                    DataVencimento.Enabled = false;
                }
                else if (status.CodigoStatus == 2)
                {
                    this.ContaCorrente.CodigoStatus = status.CodigoStatus;
                    this.ContaCorrente.DataVencimento = DateTime.Now;
                    DataVencimento.Enabled = true;
                    btn_finalizar.Enabled = true;

                }
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.contasReceberBindingSource.EndEdit();
            DataVencimento.Enabled = false;
            btn_finalizar.Enabled = false;
            CB_Pgto.Enabled = false;
            btn_Imprimir.Enabled = true;
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Venda finalizada!");
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            frm.Show();
            this.Close();
        }
    }
}

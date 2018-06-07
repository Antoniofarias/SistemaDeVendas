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
    public partial class frm_produtos : Form
    {
        public frm_produtos()
        {
            InitializeComponent();
        }

        private void frm_produtos_Load(object sender, EventArgs e)
        {
            this.produtoBindingSource.DataSource = DataContextFactory.DataContext.Produtos;
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

                this.produtoBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                DGV_cad_prod.Refresh();
                MessageBox.Show("Produto cadastrada com sucesso!");
            }
        }

            private bool valida()
        {
            if (txt_descricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo descrição é obrigatório!");
                txt_descricao.Focus();
                return false;
            }
            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                    this.produtoBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Produto excluido com sucesso!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.produtoBindingSource.CancelEdit();
        }

        private void DGV_cad_prod_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((Categoria)e.Value).Descricao;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            frm.Show();
            this.Close();

        }
    }
}

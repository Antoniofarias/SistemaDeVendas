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
    public partial class frm_cliente : Form
    {
        public frm_cliente()
        {
            InitializeComponent();
        }

        private void frm_cliente_Load(object sender, EventArgs e)
        {
            this.pessoaBindingSource.DataSource = DataContextFactory.DataContext.Pessoas;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            DGV_Clientes.Refresh();
            MessageBox.Show("Cliente cadastrado com sucesso!");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.pessoaBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Cliente excluido com sucesso!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.pessoaBindingSource.CancelEdit();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            frm.Show();
            this.Close();
        }
    }
}

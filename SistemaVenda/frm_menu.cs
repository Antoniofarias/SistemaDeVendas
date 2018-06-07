using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVenda
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
            this.Visible = false;
        }

        private void btnCadCat_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
            this.Visible = false;
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_produtos frm = new frm_produtos();
            frm.Show();
            this.Visible = false;
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_categorias frm = new frm_categorias();
            frm.Show();
            this.Visible = false;
        }

        private void produtosCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_consultaProdutos frm = new frm_consultaProdutos();
            frm.Show();
            this.Visible = false;
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
            this.Visible = false;
        }


        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_rel_produtos frm = new frm_rel_produtos();
            frm.Show();
            this.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_usuario frm = new frm_usuario();
            frm.Show();
            this.Visible = false;
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cliente frm = new frm_cliente();
            frm.Show();
            this.Visible = false;
        }

        private void frm_menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cad_user_Click(object sender, EventArgs e)
        {
            frm_usuario frm = new frm_usuario();
            frm.Show();
            this.Visible = false;
        }

        private void btn_cad_cli_Click(object sender, EventArgs e)
        {
            frm_cliente frm = new frm_cliente();
            frm.Show();
            this.Visible = false;
        }

        private void btn_cons_prod_Click(object sender, EventArgs e)
        {
            frm_consultaProdutos frm = new frm_consultaProdutos();
            frm.Show();
            this.Visible = false;
        }

        private void btn_venda_Click(object sender, EventArgs e)
        {
            frm_venda frm = new frm_venda();
            frm.Show();
            this.Visible = false;
        }

        private void btn_rel_Click(object sender, EventArgs e)
        {
            frm_rel_produtos frm = new frm_rel_produtos();
            frm.Show();
            this.Visible = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

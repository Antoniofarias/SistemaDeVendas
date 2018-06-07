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
    public partial class frm_rel_produtos : Form
    {
        public frm_rel_produtos()
        {
            InitializeComponent();
        }

        private void frm_rel_produtos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_relatorios_produtos.tb_produto' table. You can move, or remove it, as needed.
            this.tb_produtoTableAdapter.Fill(this.DS_relatorios_produtos.tb_produto);

            this.reportViewer1.RefreshReport();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            frm.Show();
            this.Close();
        }
    }
}

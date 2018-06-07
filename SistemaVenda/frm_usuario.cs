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
    public partial class frm_usuario : Form
    {
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            this.usuariosBindingSource.DataSource = DataContextFactory.DataContext.Usuarios;
            this.tipoUsuarioBindingSource.DataSource = DataContextFactory.DataContext.TipoUsuarios;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

                this.usuariosBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                DGV_cad_usuario.Refresh();
                MessageBox.Show("Usuário cadastrado com sucesso!");
            }

        }

        private bool valida()
        {
            if (txt_usuario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo nome é obrigatório!");
                txt_usuario.Focus();
                return false;
            }
            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.usuariosBindingSource.RemoveCurrent();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Usuário excluido com sucesso!");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.usuariosBindingSource.CancelEdit();
        }

        private void DGV_cad_usuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.ColumnIndex == 3)
                e.Value = ((TipoUsuario)e.Value).tipo;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            frm.Show();
            this.Close();
        }
    }

}
    

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
    public partial class frm_login : Form
    {
        public bool logado = false;

        public frm_login()
        {
            InitializeComponent();
        }

        private void EfetuarLogin()
        {
            var user = DataContextFactory.DataContext.Usuarios.Count(
                x => x.Usuario == txbUsuario.Text && x.Senha == txbSenha.Text);

            if (user > 0)
            {
                this.logado = true;
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EfetuarLogin();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
          
    }
} 

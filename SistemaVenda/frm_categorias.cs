﻿using System;
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
    public partial class frm_categorias : Form
    {
        public frm_categorias()
        {
            InitializeComponent();
        }

        private void frm_categorias_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.Categorias;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.valida())
            {

                this.categoriaBindingSource.EndEdit();
                DataContextFactory.DataContext.SubmitChanges();
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }
        }

            private bool valida ()
        {
            if (txt_categoria.Text.Trim() == string.Empty)
            {
                MessageBox.Show("O campo categoria é obrigatório!");
                txt_categoria.Focus();
                return false;
            }
            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.categoriaPossuiProduto(this.categoriaAtual))
                    MessageBox.Show("Você não pode excluir essa categoria, pois existe produtos nela");
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com sucesso!");
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        public Categoria categoriaAtual
        {
            get
            {
                return (Categoria)this.categoriaBindingSource.Current;
            }
        }

        private bool categoriaPossuiProduto(Categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.Produtos.Where(x => x.Codigo == categoria.Codigo);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_menu frm = new frm_menu();
            frm.Show();
            this.Close();
        }
    }
}

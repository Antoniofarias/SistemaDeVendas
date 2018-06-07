namespace SistemaVenda
{
    partial class frm_menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnCadCat = new System.Windows.Forms.Button();
            this.btn_cad_user = new System.Windows.Forms.Button();
            this.btn_cad_cli = new System.Windows.Forms.Button();
            this.btn_cons_prod = new System.Windows.Forms.Button();
            this.btn_venda = new System.Windows.Forms.Button();
            this.btn_rel = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(493, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.pessoasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pessoasToolStripMenuItem.Text = "Clientes";
            this.pessoasToolStripMenuItem.Click += new System.EventHandler(this.pessoasToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCategoriasToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // produtosCategoriasToolStripMenuItem
            // 
            this.produtosCategoriasToolStripMenuItem.Name = "produtosCategoriasToolStripMenuItem";
            this.produtosCategoriasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.produtosCategoriasToolStripMenuItem.Text = "Produtos / Categorias";
            this.produtosCategoriasToolStripMenuItem.Click += new System.EventHandler(this.produtosCategoriasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendaToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.vendaToolStripMenuItem.Text = "Venda";
            this.vendaToolStripMenuItem.Click += new System.EventHandler(this.vendaToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.Location = new System.Drawing.Point(24, 48);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(93, 77);
            this.btnCadProd.TabIndex = 1;
            this.btnCadProd.Text = "Cadastrar Produtos";
            this.btnCadProd.UseVisualStyleBackColor = true;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnCadCat
            // 
            this.btnCadCat.Location = new System.Drawing.Point(139, 48);
            this.btnCadCat.Name = "btnCadCat";
            this.btnCadCat.Size = new System.Drawing.Size(93, 77);
            this.btnCadCat.TabIndex = 2;
            this.btnCadCat.Text = "Cadastrar Categorias";
            this.btnCadCat.UseVisualStyleBackColor = true;
            this.btnCadCat.Click += new System.EventHandler(this.btnCadCat_Click);
            // 
            // btn_cad_user
            // 
            this.btn_cad_user.Location = new System.Drawing.Point(258, 48);
            this.btn_cad_user.Name = "btn_cad_user";
            this.btn_cad_user.Size = new System.Drawing.Size(93, 77);
            this.btn_cad_user.TabIndex = 3;
            this.btn_cad_user.Text = "Cadastrar Usuários";
            this.btn_cad_user.UseVisualStyleBackColor = true;
            this.btn_cad_user.Click += new System.EventHandler(this.btn_cad_user_Click);
            // 
            // btn_cad_cli
            // 
            this.btn_cad_cli.Location = new System.Drawing.Point(373, 48);
            this.btn_cad_cli.Name = "btn_cad_cli";
            this.btn_cad_cli.Size = new System.Drawing.Size(93, 77);
            this.btn_cad_cli.TabIndex = 4;
            this.btn_cad_cli.Text = "Cadastrar Clientes";
            this.btn_cad_cli.UseVisualStyleBackColor = true;
            this.btn_cad_cli.Click += new System.EventHandler(this.btn_cad_cli_Click);
            // 
            // btn_cons_prod
            // 
            this.btn_cons_prod.Location = new System.Drawing.Point(24, 158);
            this.btn_cons_prod.Name = "btn_cons_prod";
            this.btn_cons_prod.Size = new System.Drawing.Size(93, 77);
            this.btn_cons_prod.TabIndex = 5;
            this.btn_cons_prod.Text = "Consultar Produtos";
            this.btn_cons_prod.UseVisualStyleBackColor = true;
            this.btn_cons_prod.Click += new System.EventHandler(this.btn_cons_prod_Click);
            // 
            // btn_venda
            // 
            this.btn_venda.Location = new System.Drawing.Point(139, 158);
            this.btn_venda.Name = "btn_venda";
            this.btn_venda.Size = new System.Drawing.Size(93, 77);
            this.btn_venda.TabIndex = 6;
            this.btn_venda.Text = "Venda";
            this.btn_venda.UseVisualStyleBackColor = true;
            this.btn_venda.Click += new System.EventHandler(this.btn_venda_Click);
            // 
            // btn_rel
            // 
            this.btn_rel.Location = new System.Drawing.Point(258, 158);
            this.btn_rel.Name = "btn_rel";
            this.btn_rel.Size = new System.Drawing.Size(93, 77);
            this.btn_rel.TabIndex = 7;
            this.btn_rel.Text = "Relatórios";
            this.btn_rel.UseVisualStyleBackColor = true;
            this.btn_rel.Click += new System.EventHandler(this.btn_rel_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(373, 158);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(93, 77);
            this.btn_sair.TabIndex = 8;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 294);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_rel);
            this.Controls.Add(this.btn_venda);
            this.Controls.Add(this.btn_cons_prod);
            this.Controls.Add(this.btn_cad_cli);
            this.Controls.Add(this.btn_cad_user);
            this.Controls.Add(this.btnCadCat);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnCadCat;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.Button btn_cad_user;
        private System.Windows.Forms.Button btn_cad_cli;
        private System.Windows.Forms.Button btn_cons_prod;
        private System.Windows.Forms.Button btn_venda;
        private System.Windows.Forms.Button btn_rel;
        private System.Windows.Forms.Button btn_sair;
    }
}


namespace SistemaVenda
{
    partial class frm_usuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_usuario));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.CB_tipo = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_senha = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.DGV_cad_usuario = new System.Windows.Forms.DataGridView();
            this.codigoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cad_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(381, 82);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(267, 82);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 19;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(150, 82);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cadastrar.TabIndex = 18;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(37, 82);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // CB_tipo
            // 
            this.CB_tipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "tipo", true));
            this.CB_tipo.DataSource = this.tipoUsuarioBindingSource;
            this.CB_tipo.DisplayMember = "tipo";
            this.CB_tipo.FormattingEnabled = true;
            this.CB_tipo.Location = new System.Drawing.Point(381, 31);
            this.CB_tipo.Name = "CB_tipo";
            this.CB_tipo.Size = new System.Drawing.Size(95, 21);
            this.CB_tipo.TabIndex = 16;
            this.CB_tipo.ValueMember = "CodigoUsuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(Sistema.DAL.Usuarios);
            // 
            // tipoUsuarioBindingSource
            // 
            this.tipoUsuarioBindingSource.DataSource = typeof(Sistema.DAL.TipoUsuario);
            // 
            // txt_senha
            // 
            this.txt_senha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Senha", true));
            this.txt_senha.Location = new System.Drawing.Point(258, 31);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(67, 20);
            this.txt_senha.TabIndex = 15;
            // 
            // txt_usuario
            // 
            this.txt_usuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.txt_usuario.Location = new System.Drawing.Point(62, 30);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(129, 20);
            this.txt_usuario.TabIndex = 14;
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(344, 37);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(31, 13);
            this.lbl_tipo.TabIndex = 13;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_senha
            // 
            this.lbl_senha.AutoSize = true;
            this.lbl_senha.Location = new System.Drawing.Point(211, 34);
            this.lbl_senha.Name = "lbl_senha";
            this.lbl_senha.Size = new System.Drawing.Size(41, 13);
            this.lbl_senha.TabIndex = 12;
            this.lbl_senha.Text = "Senha:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(18, 33);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 11;
            this.lbl_nome.Text = "Nome:";
            // 
            // DGV_cad_usuario
            // 
            this.DGV_cad_usuario.AllowUserToAddRows = false;
            this.DGV_cad_usuario.AllowUserToDeleteRows = false;
            this.DGV_cad_usuario.AutoGenerateColumns = false;
            this.DGV_cad_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_cad_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoUsuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.tipoUsuarioDataGridViewTextBoxColumn});
            this.DGV_cad_usuario.DataSource = this.usuariosBindingSource;
            this.DGV_cad_usuario.Location = new System.Drawing.Point(21, 111);
            this.DGV_cad_usuario.Name = "DGV_cad_usuario";
            this.DGV_cad_usuario.ReadOnly = true;
            this.DGV_cad_usuario.Size = new System.Drawing.Size(455, 272);
            this.DGV_cad_usuario.TabIndex = 21;
            this.DGV_cad_usuario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGV_cad_usuario_CellFormatting);
            // 
            // codigoUsuarioDataGridViewTextBoxColumn
            // 
            this.codigoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "CodigoUsuario";
            this.codigoUsuarioDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codigoUsuarioDataGridViewTextBoxColumn.Name = "codigoUsuarioDataGridViewTextBoxColumn";
            this.codigoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoUsuarioDataGridViewTextBoxColumn.Width = 70;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 130;
            // 
            // senhaDataGridViewTextBoxColumn
            // 
            this.senhaDataGridViewTextBoxColumn.DataPropertyName = "Senha";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.senhaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.senhaDataGridViewTextBoxColumn.HeaderText = "Senha";
            this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
            this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.senhaDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoUsuarioDataGridViewTextBoxColumn
            // 
            this.tipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "TipoUsuario";
            this.tipoUsuarioDataGridViewTextBoxColumn.HeaderText = "Tipo de Usuário";
            this.tipoUsuarioDataGridViewTextBoxColumn.Name = "tipoUsuarioDataGridViewTextBoxColumn";
            this.tipoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoUsuarioDataGridViewTextBoxColumn.Width = 130;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(199, 389);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_voltar.TabIndex = 22;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 430);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.DGV_cad_usuario);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.CB_tipo);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.lbl_senha);
            this.Controls.Add(this.lbl_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_cad_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.ComboBox CB_tipo;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_senha;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.BindingSource tipoUsuarioBindingSource;
        private System.Windows.Forms.DataGridView DGV_cad_usuario;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_voltar;
    }
}
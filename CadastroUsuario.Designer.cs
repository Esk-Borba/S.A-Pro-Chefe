namespace PizzariaJulubom
{
    partial class CadastroUsuario
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.tblCadastros = new System.Windows.Forms.DataGridView();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.btnAlterar = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.tblCadastros)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(18, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(22, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Login";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(16, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Senha";
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.PeachPuff;
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Location = new System.Drawing.Point(69, 84);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(122, 20);
			this.txtNome.TabIndex = 3;
			this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
			// 
			// txtLogin
			// 
			this.txtLogin.BackColor = System.Drawing.Color.PeachPuff;
			this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtLogin.Location = new System.Drawing.Point(69, 127);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(122, 20);
			this.txtLogin.TabIndex = 4;
			this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
			// 
			// txtSenha
			// 
			this.txtSenha.BackColor = System.Drawing.Color.PeachPuff;
			this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSenha.Location = new System.Drawing.Point(69, 167);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(122, 20);
			this.txtSenha.TabIndex = 5;
			this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
			// 
			// tblCadastros
			// 
			this.tblCadastros.BackgroundColor = System.Drawing.Color.Tan;
			this.tblCadastros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblCadastros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.login,
            this.tipo_usuario});
			this.tblCadastros.Location = new System.Drawing.Point(205, 61);
			this.tblCadastros.Name = "tblCadastros";
			this.tblCadastros.RowHeadersWidth = 51;
			this.tblCadastros.Size = new System.Drawing.Size(390, 150);
			this.tblCadastros.TabIndex = 6;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Location = new System.Drawing.Point(205, 221);
			this.btnSalvar.Margin = new System.Windows.Forms.Padding(7);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(59, 44);
			this.btnSalvar.TabIndex = 7;
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
			this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVoltar.Location = new System.Drawing.Point(536, 215);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(59, 50);
			this.btnVoltar.TabIndex = 8;
			this.btnVoltar.UseVisualStyleBackColor = false;
			// 
			// cbTipoUsuario
			// 
			this.cbTipoUsuario.BackColor = System.Drawing.Color.PeachPuff;
			this.cbTipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbTipoUsuario.FormattingEnabled = true;
			this.cbTipoUsuario.Location = new System.Drawing.Point(69, 244);
			this.cbTipoUsuario.Name = "cbTipoUsuario";
			this.cbTipoUsuario.Size = new System.Drawing.Size(121, 21);
			this.cbTipoUsuario.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(18, 221);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Tipo do Usuário";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.Color.SaddleBrown;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.checkBox1.Location = new System.Drawing.Point(69, 193);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(114, 20);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.Text = "Mostrar Senha";
			this.checkBox1.UseVisualStyleBackColor = false;
			// 
			// btnAlterar
			// 
			this.btnAlterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar.BackgroundImage")));
			this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAlterar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnAlterar.FlatAppearance.BorderSize = 2;
			this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnAlterar.ForeColor = System.Drawing.Color.White;
			this.btnAlterar.Location = new System.Drawing.Point(333, 217);
			this.btnAlterar.Name = "btnAlterar";
			this.btnAlterar.Size = new System.Drawing.Size(67, 48);
			this.btnAlterar.TabIndex = 13;
			this.btnAlterar.UseVisualStyleBackColor = true;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
			this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnExcluir.FlatAppearance.BorderSize = 2;
			this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnExcluir.ForeColor = System.Drawing.Color.White;
			this.btnExcluir.Location = new System.Drawing.Point(406, 217);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(75, 48);
			this.btnExcluir.TabIndex = 14;
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.Button2_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label14.Location = new System.Drawing.Point(130, 12);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(312, 36);
			this.label14.TabIndex = 34;
			this.label14.Text = "Cadastro do Usuário";
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.Width = 30;
			// 
			// nome
			// 
			this.nome.HeaderText = "Nome";
			this.nome.MinimumWidth = 6;
			this.nome.Name = "nome";
			// 
			// login
			// 
			this.login.HeaderText = "Login";
			this.login.MinimumWidth = 6;
			this.login.Name = "login";
			this.login.Width = 90;
			// 
			// tipo_usuario
			// 
			this.tipo_usuario.HeaderText = "Tipo-Usuario";
			this.tipo_usuario.MinimumWidth = 6;
			this.tipo_usuario.Name = "tipo_usuario";
			// 
			// CadastroUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(620, 299);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnAlterar);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbTipoUsuario);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.tblCadastros);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CadastroUsuario";
			this.Text = "Cadastro do Usuário";
			((System.ComponentModel.ISupportInitialize)(this.tblCadastros)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.DataGridView tblCadastros;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbTipoUsuario;

        private System.Windows.Forms.Label label4;
   
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn login;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_usuario;
	}
}
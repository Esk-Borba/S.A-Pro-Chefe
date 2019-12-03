namespace PizzariaJulubom
{
    partial class NovoPedidoDelivery
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoPedidoDelivery));
			this.txtNome = new System.Windows.Forms.TextBox();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tblProdutos = new System.Windows.Forms.DataGridView();
			this.cbEntregador = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.lblFiltrar = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descrição = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.tblProdutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.BackColor = System.Drawing.Color.PeachPuff;
			this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtNome.ForeColor = System.Drawing.Color.Black;
			this.txtNome.Location = new System.Drawing.Point(100, 67);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(113, 20);
			this.txtNome.TabIndex = 0;
			// 
			// cbCategoria
			// 
			this.cbCategoria.BackColor = System.Drawing.Color.PeachPuff;
			this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cbCategoria.ForeColor = System.Drawing.Color.Black;
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(100, 152);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(113, 21);
			this.cbCategoria.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(49, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(32, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 5;
			this.label2.Text = "Telefone";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(27, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Categoria";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(16, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 16);
			this.label4.TabIndex = 7;
			this.label4.Text = "Quantidade";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tblProdutos
			// 
			this.tblProdutos.BackgroundColor = System.Drawing.Color.Tan;
			this.tblProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.descrição,
            this.preco});
			this.tblProdutos.Location = new System.Drawing.Point(297, 63);
			this.tblProdutos.Name = "tblProdutos";
			this.tblProdutos.Size = new System.Drawing.Size(368, 191);
			this.tblProdutos.TabIndex = 8;
			// 
			// cbEntregador
			// 
			this.cbEntregador.BackColor = System.Drawing.Color.PeachPuff;
			this.cbEntregador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbEntregador.FormattingEnabled = true;
			this.cbEntregador.Location = new System.Drawing.Point(100, 233);
			this.cbEntregador.Name = "cbEntregador";
			this.cbEntregador.Size = new System.Drawing.Size(113, 21);
			this.cbEntregador.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(19, 238);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 16);
			this.label6.TabIndex = 13;
			this.label6.Text = "Entregador";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
			this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnVoltar.Location = new System.Drawing.Point(597, 263);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(68, 53);
			this.btnVoltar.TabIndex = 26;
			this.btnVoltar.UseVisualStyleBackColor = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnSalvar.Location = new System.Drawing.Point(526, 263);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(65, 53);
			this.btnSalvar.TabIndex = 25;
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.BackgroundImage")));
			this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Location = new System.Drawing.Point(228, 138);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(63, 46);
			this.btnFiltrar.TabIndex = 27;
			this.btnFiltrar.UseVisualStyleBackColor = true;
			// 
			// lblFiltrar
			// 
			this.lblFiltrar.AutoSize = true;
			this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblFiltrar.Location = new System.Drawing.Point(240, 187);
			this.lblFiltrar.Name = "lblFiltrar";
			this.lblFiltrar.Size = new System.Drawing.Size(41, 16);
			this.lblFiltrar.TabIndex = 28;
			this.lblFiltrar.Text = "Filtrar";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label14.Location = new System.Drawing.Point(174, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(323, 36);
			this.label14.TabIndex = 35;
			this.label14.Text = "Novo Pedido Delivery";
			// 
			// txtTelefone
			// 
			this.txtTelefone.BackColor = System.Drawing.Color.PeachPuff;
			this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTelefone.Location = new System.Drawing.Point(100, 108);
			this.txtTelefone.Mask = "(00)00000-0000";
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(113, 20);
			this.txtTelefone.TabIndex = 36;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(294, 281);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(161, 16);
			this.label5.TabIndex = 37;
			this.label5.Text = "Total do Pedido Delivery:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(461, 281);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 16);
			this.label7.TabIndex = 39;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.Color.PeachPuff;
			this.numericUpDown1.Location = new System.Drawing.Point(100, 199);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(113, 20);
			this.numericUpDown1.TabIndex = 40;
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
			this.nome.Name = "nome";
			// 
			// descrição
			// 
			this.descrição.HeaderText = "Descrição";
			this.descrição.Name = "descrição";
			// 
			// preco
			// 
			this.preco.HeaderText = "Preço";
			this.preco.Name = "preco";
			this.preco.Width = 60;
			// 
			// NovoPedidoDelivery
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(677, 339);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.lblFiltrar);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbEntregador);
			this.Controls.Add(this.tblProdutos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.txtNome);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NovoPedidoDelivery";
			this.Text = "Novo pedido Delivery";
			((System.ComponentModel.ISupportInitialize)(this.tblProdutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView tblProdutos;
        private System.Windows.Forms.ComboBox cbEntregador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn descrição;
		private System.Windows.Forms.DataGridViewTextBoxColumn preco;
	}
}
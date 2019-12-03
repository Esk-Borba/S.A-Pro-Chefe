namespace PizzariaJulubom
{
    partial class PedidoCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoCliente));
			this.tblProdutos = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.btnFiltrar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.lblFiltrar = new System.Windows.Forms.Label();
			this.lblIncluir = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btnFinalizarMesa = new System.Windows.Forms.Button();
			this.btnOcuparMesa = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.tblProdutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// tblProdutos
			// 
			this.tblProdutos.BackgroundColor = System.Drawing.Color.Tan;
			this.tblProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome,
            this.descricao,
            this.preco});
			this.tblProdutos.Location = new System.Drawing.Point(28, 73);
			this.tblProdutos.Name = "tblProdutos";
			this.tblProdutos.RowHeadersWidth = 51;
			this.tblProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.tblProdutos.Size = new System.Drawing.Size(397, 270);
			this.tblProdutos.TabIndex = 0;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.MinimumWidth = 6;
			this.id.Name = "id";
			this.id.Width = 60;
			// 
			// nome
			// 
			this.nome.HeaderText = "Nome";
			this.nome.MinimumWidth = 6;
			this.nome.Name = "nome";
			// 
			// descricao
			// 
			this.descricao.HeaderText = "Descrição";
			this.descricao.MinimumWidth = 6;
			this.descricao.Name = "descricao";
			this.descricao.Width = 120;
			// 
			// preco
			// 
			this.preco.HeaderText = "Preço";
			this.preco.MinimumWidth = 6;
			this.preco.Name = "preco";
			this.preco.Width = 60;
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
			this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Location = new System.Drawing.Point(599, 314);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(63, 56);
			this.btnVoltar.TabIndex = 1;
			this.btnVoltar.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 16);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(445, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Categoria";
			// 
			// cbCategoria
			// 
			this.cbCategoria.BackColor = System.Drawing.Color.PeachPuff;
			this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Location = new System.Drawing.Point(448, 103);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(145, 21);
			this.cbCategoria.TabIndex = 5;
			// 
			// btnFiltrar
			// 
			this.btnFiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.BackgroundImage")));
			this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFiltrar.Location = new System.Drawing.Point(599, 78);
			this.btnFiltrar.Name = "btnFiltrar";
			this.btnFiltrar.Size = new System.Drawing.Size(63, 46);
			this.btnFiltrar.TabIndex = 6;
			this.btnFiltrar.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(445, 141);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Quantidade";
			// 
			// btnIncluir
			// 
			this.btnIncluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncluir.BackgroundImage")));
			this.btnIncluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnIncluir.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(448, 219);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(64, 50);
			this.btnIncluir.TabIndex = 10;
			this.btnIncluir.UseVisualStyleBackColor = true;
			// 
			// lblFiltrar
			// 
			this.lblFiltrar.AutoSize = true;
			this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblFiltrar.Location = new System.Drawing.Point(611, 127);
			this.lblFiltrar.Name = "lblFiltrar";
			this.lblFiltrar.Size = new System.Drawing.Size(41, 16);
			this.lblFiltrar.TabIndex = 12;
			this.lblFiltrar.Text = "Filtrar";
			// 
			// lblIncluir
			// 
			this.lblIncluir.AutoSize = true;
			this.lblIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.lblIncluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblIncluir.Location = new System.Drawing.Point(459, 272);
			this.lblIncluir.Name = "lblIncluir";
			this.lblIncluir.Size = new System.Drawing.Size(42, 16);
			this.lblIncluir.TabIndex = 14;
			this.lblIncluir.Text = "Incluir";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label14.Location = new System.Drawing.Point(226, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(199, 36);
			this.label14.TabIndex = 36;
			this.label14.Text = "Novo Pedido";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label17.Location = new System.Drawing.Point(541, 200);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(0, 16);
			this.label17.TabIndex = 43;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label16.Location = new System.Drawing.Point(445, 200);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(95, 16);
			this.label16.TabIndex = 42;
			this.label16.Text = "Total da Mesa";
			// 
			// btnFinalizarMesa
			// 
			this.btnFinalizarMesa.FlatAppearance.BorderSize = 2;
			this.btnFinalizarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinalizarMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnFinalizarMesa.ForeColor = System.Drawing.Color.White;
			this.btnFinalizarMesa.Location = new System.Drawing.Point(431, 339);
			this.btnFinalizarMesa.Name = "btnFinalizarMesa";
			this.btnFinalizarMesa.Size = new System.Drawing.Size(145, 31);
			this.btnFinalizarMesa.TabIndex = 44;
			this.btnFinalizarMesa.Text = "Desocupar Mesa";
			this.btnFinalizarMesa.UseVisualStyleBackColor = true;
			// 
			// btnOcuparMesa
			// 
			this.btnOcuparMesa.FlatAppearance.BorderSize = 2;
			this.btnOcuparMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOcuparMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btnOcuparMesa.ForeColor = System.Drawing.Color.White;
			this.btnOcuparMesa.Location = new System.Drawing.Point(431, 302);
			this.btnOcuparMesa.Name = "btnOcuparMesa";
			this.btnOcuparMesa.Size = new System.Drawing.Size(145, 31);
			this.btnOcuparMesa.TabIndex = 45;
			this.btnOcuparMesa.Text = "Ocupar Mesa";
			this.btnOcuparMesa.UseVisualStyleBackColor = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.Color.PeachPuff;
			this.numericUpDown1.Location = new System.Drawing.Point(448, 160);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(145, 20);
			this.numericUpDown1.TabIndex = 46;
			// 
			// PedidoCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(675, 382);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.btnOcuparMesa);
			this.Controls.Add(this.btnFinalizarMesa);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.lblIncluir);
			this.Controls.Add(this.lblFiltrar);
			this.Controls.Add(this.btnIncluir);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnFiltrar);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.tblProdutos);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PedidoCliente";
			this.Text = "Pedido da Mesa";
			((System.ComponentModel.ISupportInitialize)(this.tblProdutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProdutos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIncluir;

        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblIncluir;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn nome;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
		private System.Windows.Forms.DataGridViewTextBoxColumn preco;
		private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnFinalizarMesa;
        private System.Windows.Forms.Button btnOcuparMesa;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
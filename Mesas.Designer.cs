namespace PizzariaJulubom
{
    partial class Mesas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mesas));
			this.tblMesas = new System.Windows.Forms.DataGridView();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnVoltar = new System.Windows.Forms.Button();
			this.cbDisponibilidade = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numCapacidade = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.btnAlterar1 = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.disponibilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.tblMesas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCapacidade)).BeginInit();
			this.SuspendLayout();
			// 
			// tblMesas
			// 
			this.tblMesas.BackgroundColor = System.Drawing.Color.Peru;
			this.tblMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tblMesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.capacidade,
            this.disponibilidade,
            this.observacao});
			this.tblMesas.Location = new System.Drawing.Point(27, 56);
			this.tblMesas.Name = "tblMesas";
			this.tblMesas.Size = new System.Drawing.Size(464, 214);
			this.tblMesas.TabIndex = 0;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
			this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalvar.Location = new System.Drawing.Point(334, 347);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(65, 45);
			this.btnSalvar.TabIndex = 1;
			this.btnSalvar.UseVisualStyleBackColor = true;
			// 
			// btnVoltar
			// 
			this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
			this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVoltar.Location = new System.Drawing.Point(423, 346);
			this.btnVoltar.Name = "btnVoltar";
			this.btnVoltar.Size = new System.Drawing.Size(68, 47);
			this.btnVoltar.TabIndex = 2;
			this.btnVoltar.UseVisualStyleBackColor = true;
			// 
			// cbDisponibilidade
			// 
			this.cbDisponibilidade.BackColor = System.Drawing.Color.PeachPuff;
			this.cbDisponibilidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cbDisponibilidade.FormattingEnabled = true;
			this.cbDisponibilidade.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
			this.cbDisponibilidade.Location = new System.Drawing.Point(120, 317);
			this.cbDisponibilidade.Name = "cbDisponibilidade";
			this.cbDisponibilidade.Size = new System.Drawing.Size(184, 21);
			this.cbDisponibilidade.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(31, 291);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Capacidade";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(11, 321);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Disponibilidade";
			// 
			// numCapacidade
			// 
			this.numCapacidade.AutoSize = true;
			this.numCapacidade.BackColor = System.Drawing.Color.PeachPuff;
			this.numCapacidade.Location = new System.Drawing.Point(120, 286);
			this.numCapacidade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numCapacidade.Name = "numCapacidade";
			this.numCapacidade.Size = new System.Drawing.Size(184, 20);
			this.numCapacidade.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(31, 362);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 16);
			this.label3.TabIndex = 8;
			this.label3.Text = "Observação";
			// 
			// txtObservacao
			// 
			this.txtObservacao.BackColor = System.Drawing.Color.PeachPuff;
			this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtObservacao.Location = new System.Drawing.Point(120, 349);
			this.txtObservacao.Multiline = true;
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(184, 45);
			this.txtObservacao.TabIndex = 9;
			this.txtObservacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricao_KeyPress);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Kristen ITC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label14.Location = new System.Drawing.Point(105, 9);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(274, 36);
			this.label14.TabIndex = 34;
			this.label14.Text = "Cadastro de Mesa";
			// 
			// btnAlterar1
			// 
			this.btnAlterar1.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnAlterar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterar1.BackgroundImage")));
			this.btnAlterar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAlterar1.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnAlterar1.FlatAppearance.BorderSize = 2;
			this.btnAlterar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlterar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
			this.btnAlterar1.ForeColor = System.Drawing.Color.White;
			this.btnAlterar1.Location = new System.Drawing.Point(373, 286);
			this.btnAlterar1.Name = "btnAlterar1";
			this.btnAlterar1.Size = new System.Drawing.Size(65, 44);
			this.btnAlterar1.TabIndex = 35;
			this.btnAlterar1.UseVisualStyleBackColor = false;
			// 
			// id
			// 
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.Width = 30;
			// 
			// capacidade
			// 
			this.capacidade.HeaderText = "Capacidade";
			this.capacidade.Name = "capacidade";
			this.capacidade.Width = 80;
			// 
			// disponibilidade
			// 
			this.disponibilidade.HeaderText = "Disponibilidade";
			this.disponibilidade.Name = "disponibilidade";
			// 
			// observacao
			// 
			this.observacao.HeaderText = "Observação";
			this.observacao.Name = "observacao";
			this.observacao.Width = 170;
			// 
			// Mesas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SaddleBrown;
			this.ClientSize = new System.Drawing.Size(515, 406);
			this.Controls.Add(this.btnAlterar1);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numCapacidade);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbDisponibilidade);
			this.Controls.Add(this.btnVoltar);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.tblMesas);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Mesas";
			this.Text = "Cadastro de Mesa";
			((System.ComponentModel.ISupportInitialize)(this.tblMesas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCapacidade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblMesas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbDisponibilidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCapacidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnAlterar1;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn capacidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidade;
		private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
	}
}
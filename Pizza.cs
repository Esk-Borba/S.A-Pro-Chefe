using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaJulubom
{
    public partial class Pizza : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        List<categoria> categorias;
        public Pizza()
        {
            InitializeComponent();
            btnVoltar1.Click += voltar1;
            btnVoltar2.Click += voltar2;
            btnSalvar.Click += salvar1;
            btnSalvar2.Click += salvar2;
            categorias = bd.categoria.ToList();
            carregarTabela();
			btnAlterar.Click += alterar;
			btnExcluir.Click += excluir;
			tblIngredientes.RowHeaderMouseClick += carregarTxt;
		}

		private void carregarTxt(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtIngrediente.Text = tblIngredientes.Rows[e.RowIndex].Cells[1].Value.ToString();
			numericUpDown1.Value = Convert.ToDecimal(tblIngredientes.Rows[e.RowIndex].Cells[2].Value);			
			cbMedida.Text = tblIngredientes.Rows[e.RowIndex].Cells[3].Value.ToString();
		}

		private void excluir(object sender, EventArgs e)
		{
			int ingredienteExcluir = Convert.ToInt32(tblIngredientes.SelectedRows[0].Cells[0].Value);
			ingrediente ingre = new ingrediente();

			bd.ingrediente.ToList().ForEach(i =>
			{
				if (i.id == ingredienteExcluir)
				{
					ingre = i;
				}
			});
			bd.ingrediente.Remove(ingre);
			bd.SaveChanges();
			carregarTabela();
			txtIngrediente.Clear();
			cbMedida.Text = "";
			numericUpDown1.Value = 0;
			MessageBox.Show("Ingrediente excluído com sucesso");
		}

		private void alterar(object sender, EventArgs e)
		{
			string novoIngrediente = txtIngrediente.Text;
			decimal novaQuantidade = numericUpDown1.Value;
			string novaUnidade = cbMedida.Text;			
			int alterar = Convert.ToInt32(tblIngredientes.SelectedRows[0].Cells[0].Value);			
			ingrediente ingredienteNovo = new ingrediente();
			bd.ingrediente.ToList().ForEach(i =>
			{
				if (i.id == alterar)
				{
					i.nome = novoIngrediente;
					i.estoque = Convert.ToInt32(novaQuantidade);
					i.unidade = novaUnidade;					
					bd.SaveChanges();
				}

			});
			carregarTabela();
			txtIngrediente.Clear();
			cbMedida.Text = "";
			numericUpDown1.Value = 0;
			MessageBox.Show("Ingrediente alterado com sucesso");
		}

		private void salvar1(object sender, EventArgs e)
        {
            categoria selecionada = categorias.ElementAt(cbCategoria.SelectedIndex);
            produto produto = new produto();
            produto.nome = txtNome.Text;
            produto.descricao = txtDescricao.Text;
            produto.preco = Convert.ToDecimal(txtValor.Text);
            produto.id_categoria = selecionada.id;
            bd.produto.Add(produto);
            bd.SaveChanges();
            MessageBox.Show("Produto salvo com sucesso");
            carregarTabela();
            txtNome.Clear();
            txtValor.Clear();
            txtDescricao.Clear();
            cbCategoria.Text = "";
        }
        private void salvar2(object sender, EventArgs e)
        {
            ingrediente ingredientes = new ingrediente();
            ingredientes.nome = txtIngrediente.Text;
            ingredientes.estoque = Convert.ToInt16(numericUpDown1.Value);
			ingredientes.unidade = cbMedida.Text;
            bd.ingrediente.Add(ingredientes);
            bd.SaveChanges();
            carregarTabela();
            MessageBox.Show("Ingrediente salvo com sucesso");
            txtIngrediente.Clear();
			cbMedida.Text = "";
			numericUpDown1.Value = 0;
        }
        private void carregarTabela()
        {
			tblIngredientes.Rows.Clear();
			bd.ingrediente.ToList().ForEach(i =>
			{
				tblIngredientes.Rows.Add(i.id, i.nome, i.estoque, i.unidade);
			});			
        }
        private void voltar1(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
        private void voltar2(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
        private void voltar3(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
        private void CbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void txtIngrediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }

        }
        
    }
}

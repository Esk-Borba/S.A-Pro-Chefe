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
    public partial class Alteracoes : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();        
        public Alteracoes()
        {
            InitializeComponent();
            btnVoltar.Click += voltar;            
            btnExcluir.Click += excluir;
            btnAlterar.Click += alterar;		
			btnAlterar2.Click += alterar2;			
			btnExcluir2.Click += excluir2;
			btnVoltar2.Click += voltar2;
            carregarTabela();
			carregarTabela2();
			dgCliente.RowHeaderMouseClick += carregarTxt;
			dgProduto.RowHeaderMouseClick += carregarTxt2;
		}

		private void carregarTabela2()
		{
			dgProduto.Rows.Clear();
			bd.produto.ToList().ForEach(p =>
			{
				dgProduto.Rows.Add(p.id, p.nome, p.descricao, p.preco, p.id_categoria);
			});
		}		

		private void carregarTxt2(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtNome1.Text = dgProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtDescricao1.Text = dgProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtValor1.Text = dgProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
			label21.Text = dgProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
		}

		private void carregarTxt(object sender, DataGridViewCellMouseEventArgs e)
		{
			txtNome.Text = dgCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtTelefone.Text = dgCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtCPF.Text = dgCliente.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtCEP.Text = dgCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtLogradouro.Text = dgCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtNumero.Text = dgCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtComplemento.Text = dgCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
			txtBairro.Text = dgCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
			cbUF.Text = dgCliente.Rows[e.RowIndex].Cells[9].Value.ToString();
			txtCidade.Text = dgCliente.Rows[e.RowIndex].Cells[10].Value.ToString();
		}

		private void voltar2(object sender, EventArgs e)
		{
			new Menu().Show();
			this.Hide();
		}
	
		private void excluir2(object sender, EventArgs e)
		{
			int produtoExcluir = Convert.ToInt32(dgProduto.SelectedRows[0].Cells[0].Value);
			produto produto1 = new produto();
			bd.produto.ToList().ForEach(p =>
			{
				if (p.id == produtoExcluir)
				{
					produto1 = p;
				}
			});
			bd.produto.Remove(produto1);
			bd.SaveChanges();
			carregarTabela2();
            txtNome1.Clear();
            txtDescricao1.Clear();
            txtValor1.Clear();
            MessageBox.Show("Produto excluído com sucesso");
		}

		
		private void alterar2(object sender, EventArgs e)
		{
			string novoNome = txtNome1.Text;
			string novoDescricao = txtDescricao1.Text;
			string novoValor = txtValor1.Text;            
			int alterar = Convert.ToInt32(dgProduto.SelectedRows[0].Cells[0].Value);
			produto produtoNovo = new produto();
			bd.produto.ToList().ForEach(p =>
			{
				if (p.id == alterar)
				{
                    p.id = p.id;
					p.nome = novoNome;
					p.descricao = novoDescricao;
					p.preco = Convert.ToDecimal(novoValor);                   
                    p.id_categoria = p.id_categoria;                   
                    
					bd.SaveChanges();
				}

			});
			carregarTabela2();
			txtNome1.Clear();
			txtDescricao1.Clear();
			txtValor1.Clear();            
			MessageBox.Show("Produto alterado com sucesso");
		}

		
		private void alterar(object sender, EventArgs e)
        {
			string novoBairro = txtBairro.Text;
			string novoNome = txtNome.Text;
			string novoCep = txtCEP.Text;
			string novoCPF = txtCPF.Text;
			string novoUF = cbUF.Text;
			string novoCidade = txtCidade.Text;
			string novoNumero = txtNumero.Text;
			string novoLogradouro = txtLogradouro.Text;
			string novoTelefone = txtTelefone.Text;
			string novoComplemento = txtComplemento.Text;			
			int alterar = Convert.ToInt32(dgCliente.SelectedRows[0].Cells[0].Value);
			clientes clienteNovo = new clientes();
			bd.clientes.ToList().ForEach(c =>
			{
				if (c.id == alterar)
				{
                    c.id = c.id;
					c.nome = novoNome;
					c.telefone = novoTelefone;
					c.cpf = novoCPF;
					c.cep = novoCep;
					c.logradouro = novoLogradouro;
					c.numero = Convert.ToInt32(novoNumero);
					c.complemento = novoComplemento;
					c.bairro = novoBairro;
					c.uf = novoUF;
					c.cidade = novoCidade;
					bd.SaveChanges();
				}

			});
			carregarTabela();
			txtBairro.Clear();
			txtNome.Clear();
			txtCEP.Clear();
			txtCPF.Clear();
			cbUF.Text = "";
			txtCidade.Clear();
			txtNumero.Clear();
			txtLogradouro.Clear();
			txtTelefone.Clear();
			txtComplemento.Clear();
			MessageBox.Show("Cliente alterado com sucesso");
		}

        private void excluir(object sender, EventArgs e)
        {
            int clienteExcluir = Convert.ToInt32(dgCliente.SelectedRows[0].Cells[0].Value);
            clientes cliente = new clientes();                        
            bd.clientes.ToList().ForEach(c =>
            {
                if(c.id == clienteExcluir)
                {
                    cliente = c;
                }
            });
            bd.clientes.Remove(cliente);
            bd.SaveChanges();
            carregarTabela();
			txtBairro.Clear();
			txtNome.Clear();
			txtCEP.Clear();
			txtCPF.Clear();
			cbUF.Text = "";
			txtCidade.Clear();
			txtNumero.Clear();
			txtLogradouro.Clear();
			txtTelefone.Clear();
			txtComplemento.Clear();
			MessageBox.Show("Cliente excluído com sucesso");
        }

        private void carregarTabela()
        {
			dgCliente.Rows.Clear();
			bd.clientes.ToList().ForEach(c =>
			{
				dgCliente.Rows.Add(c.id, c.nome, c.telefone, c.cpf, c.cep, c.logradouro, c.numero, c.complemento, c.bairro, c.uf, c.cidade);
			});
		}        
        private void voltar(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltar2_Click(object sender, EventArgs e)
        {

        }

        private void Tb_cliente_Click(object sender, EventArgs e)
        {

        }

		private void Alteracoes_Load(object sender, EventArgs e)
		{

		}
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtNome1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtDescricao1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Somente é aceito números e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }

		private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

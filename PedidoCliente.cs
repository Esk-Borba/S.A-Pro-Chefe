using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaJulubom
{
	public partial class PedidoCliente : Form
	{
		pro_chefeEntities bd = new pro_chefeEntities();
		mesa selecionada;
		categoria pesquisada = new categoria();


		public PedidoCliente()
		{
			InitializeComponent();
		}
		public PedidoCliente(mesa mesaSelecionada)
		{
			this.selecionada = mesaSelecionada;
			InitializeComponent();
			btnVoltar.Click += voltar;
			btnIncluir.Click += incluir;
			carregarCategorias();
			carregarProdutos();
			btnFiltrar.Click += filtrar;
			label1.Text = $"Mesa: {selecionada.id}";
			btnFinalizarMesa.Click += finalizarMesa;
			btnOcuparMesa.Click += ocuparMesa;
			if (mesaSelecionada.disponibilidade == "Disponível")
			{
				btnFinalizarMesa.Hide();
			}
			if (mesaSelecionada.disponibilidade == "Indisponível")
			{
				btnOcuparMesa.Hide();
			}
		}

		private void carregarProdutos()
		{
			bd.produto.ToList().ForEach(u =>
			{
				tblProdutos.Rows.Add(u.id, u.nome, u.descricao, u.preco);
			});
		}

		private void ocuparMesa(object sender, EventArgs e)
		{
			if (selecionada.disponibilidade == "Disponível")
			{
				bd.mesa.ToList().ForEach(m =>
				{
					if (m.id == selecionada.id)
					{
						m.disponibilidade = "Indisponível";
					}
				});
				bd.SaveChanges();
				MessageBox.Show("A mesa foi declarada ocupada");
			}
		}

		private void finalizarMesa(object sender, EventArgs e)
		{
			{
				decimal total = 0;
				bd.valor_mesa.ToList().ForEach(v =>
				{
					if (v.id_mesa == selecionada.id)
					{
						total = v.valor;
					}
				});
				if (selecionada.disponibilidade == "Indisponível")
				{
					MessageBox.Show($"Valor a ser pago é : {total}");
					bd.mesa.ToList().ForEach(m =>
					{
						if (m.id == selecionada.id)
						{
							m.disponibilidade = "Disponível";
						}
					});
					bd.SaveChanges();
				}
				var valor = bd.valor_mesa.Where(v2 => v2.id_mesa.Equals(selecionada.id)).FirstOrDefault();
				bd.valor_mesa.Remove(valor);
				bd.SaveChanges();
			}
		}

		private void totalMesa()
		{

			bd.valor_mesa.ToList().ForEach(v =>
			{
				if (v.id_mesa == selecionada.id)
				{
					label17.Text = v.valor.ToString();
				}
			});

		}

		private void carregarCategorias()
		{

			cbCategoria.Items.Clear();
			bd.categoria.ToList().ForEach(u2 =>
			{
				cbCategoria.Items.Add(u2.nome);
			});
		}

		private void filtrar(object sender, EventArgs e)
		{
			if (cbCategoria.Text != "")
			{
				pesquisada = bd.categoria.Where(c => c.id.Equals(cbCategoria.SelectedIndex + 1)).FirstOrDefault();
				if (pesquisada != null)
				{
					tblProdutos.Rows.Clear();
					bd.produto.ToList().ForEach(m =>
					{
						if (m.id_categoria == pesquisada.id)
						{
							tblProdutos.Rows.Add(m.id, m.nome, m.descricao, m.preco);
						}

					});
					cbCategoria.Text = "";
				}
				else
				{
					MessageBox.Show("Produto não encontrado");
					cbCategoria.Text = "";
				}
			}
		}
		private void incluir(object sender, EventArgs e)
		{
			int idProduto = Convert.ToInt32(tblProdutos.SelectedRows[0].Cells[0].Value);
			decimal valorProduto = Convert.ToInt32(tblProdutos.SelectedRows[0].Cells[3].Value);
			produto produto = bd.produto.Find(idProduto);
			int quantidade2 = Convert.ToInt32(numericUpDown1.Text);
			pedido pedido = new pedido()
			{
				data = DateTime.Now,
				id_mesa = selecionada.id,
			};
			bd.pedido.Add(pedido);
			bd.SaveChanges();
			itens_pedido itens_Pedido = new itens_pedido()
			{
				id_pedido = pedido.id,
				id_produto = produto.id,
				quantidade = quantidade2
			};
			bd.itens_pedido.Add(itens_Pedido);
			bd.SaveChanges();
			decimal total = 0;
			bd.valor_mesa.ToList().ForEach(v =>
			{
				if (v.id_mesa == selecionada.id)
				{
					total = v.valor;
				};
			});
			total = total + (valorProduto * quantidade2);
			var valorMesa = bd.valor_mesa.Where(v => v.id_mesa.Equals(selecionada.id)).FirstOrDefault();
			if (valorMesa != null)
			{
				bd.valor_mesa.ToList().ForEach(v2 =>
				{
					if (v2.id_mesa == selecionada.id)
					{
						if (v2.valor != 0)
						{
							v2.valor = total;
							bd.SaveChanges();
						}
						if (v2.valor == 0)
						{
							v2.valor = total;
							bd.SaveChanges();
						}
					};
				});
			}
			if (valorMesa == null)
			{
				valor_mesa valorTotal = new valor_mesa();
				valorTotal.id_mesa = selecionada.id;
				valorTotal.valor = total;
				bd.valor_mesa.Add(valorTotal);
				bd.SaveChanges();
			};
			MessageBox.Show("Item inserido com sucesso");
			numericUpDown1.Value = 0;
			label17.Text = total.ToString();
		}
		private void voltar(object sender, EventArgs e)
		{
			new Menu().Show();
			this.Hide();
		}

	}

}


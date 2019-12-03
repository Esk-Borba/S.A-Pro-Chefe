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
    public partial class NovoPedidoDelivery : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        List<clientes> clientes;
        List<usuario> usuarios;
        public static decimal total = 0;
        public static decimal total2 = 0;
        private clientes cliente;
        categoria pesquisada = new categoria();
        public NovoPedidoDelivery()
        {
            InitializeComponent();
            carregarCombo();
            btnVoltar.Click += voltar;
            btnSalvar.Click += salvar;
        }
        public NovoPedidoDelivery(clientes cliente)
        {
            InitializeComponent();
            carregarCombo();
            carregarProdutos();
            carregarEntregador();
            this.cliente = cliente;
            usuarios = bd.usuario.ToList();
            txtNome.Text = this.cliente.nome;
            txtTelefone.Text = this.cliente.telefone;
            btnVoltar.Click += voltar;
            btnSalvar.Click += salvar;
            btnFiltrar.Click += filtrar;

        }

        private void totalDelivery()
        {
            total2 = Convert.ToDecimal(tblProdutos.SelectedRows[0].Cells[3].Value);
            int quantidade2 = Convert.ToInt32(numericUpDown1.Value);
            total = total+(total2 * quantidade2);
            label7.Text = total.ToString();
        }

        private void filtrar(object sender, EventArgs e)
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
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
        }
        private void carregarEntregador()
        {
            cbEntregador.Items.Clear();
            bd.usuario.ToList().ForEach(u2 =>
            {
                if (u2.tipo_usuario == 2)
                {
                    cbEntregador.Items.Add(u2.nome);
                }
            });
        }

        private void salvar(object sender, EventArgs e)
        {
            usuario selecionado2 = usuarios.ElementAt(cbEntregador.SelectedIndex);
            int idProduto = Convert.ToInt32(tblProdutos.SelectedRows[0].Cells[0].Value);
            produto produto = bd.produto.Find(idProduto);
            pedido pedido = new pedido()
            {
                data = DateTime.Now,
                delivery2 = true                            
            };
            bd.pedido.Add(pedido);
            bd.SaveChanges();
            delivery delivery = new delivery()
            {
                id_cliente = cliente.id,
                id_pedido = pedido.id,
                id_entregador = selecionado2.id,
                categoria = Convert.ToString(cbCategoria.SelectedItem),
                quantidade = Convert.ToInt32(numericUpDown1.Value)
            };
            bd.delivery.Add(delivery);
            bd.SaveChanges();
            MessageBox.Show("Pedido cadastrado com sucesso!");
            totalDelivery();
            cbCategoria.Text = "";
            cbEntregador.Text = "";
            numericUpDown1.Value = 0;
        }

        private void voltar(object sender, EventArgs e)
        {
            new Deliverys().Show();
            this.Hide();
        }

        private void carregarCombo()
        {
            cbCategoria.Items.Clear();
            bd.categoria.ToList().ForEach(c =>
            {
                cbCategoria.Items.Add(c.nome);
            });
        }
        private void carregarProdutos()
        {
            bd.produto.ToList().ForEach(u =>
            {
                tblProdutos.Rows.Add(u.id, u.nome, u.descricao, u.preco);
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaJulubom
{
    public partial class Deliverys : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        public static clientes cliente = new clientes();
        List<delivery> delivery2;
        List<delivery> delivery3;
        List<clientes> clientes;
        List<usuario> usuarios;
        public static delivery idCliente;
        public static string nome;
        public static string telefone;
        public static int idCliente2 = 0;

        public Deliverys()
        {
            InitializeComponent();
            btnPesquisar.Click += pesquisar;
            btnVoltar.Click += voltar;
            btnAdicionar.Click += adicionar;
            btnNovoPedido.Click += novoPedido;
            delivery2 = bd.delivery.ToList();
            delivery3 = bd.delivery.ToList();
            clientes = bd.clientes.ToList();
            usuarios = bd.usuario.ToList();
            txtTelefone.KeyPress += checkTecla;
            ckProcessados.Click += processados;
            btnFinalizarPedido.Click += finalizarPedido;
            btnCarregaFoto.Click += fotoCarrega1;
            pictureBox2.Image = Properties.Resources.cadastro;
        }

        private void fotoCarrega1(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Selecione uma imagem.";
            openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
            openFileDialog1.Title = "Open image file";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void finalizarPedido(object sender, EventArgs e)
        {
            int finalizado = Convert.ToInt32(tblPedidosEntrega.SelectedRows[0].Cells[2].Value);
            delivery2.ToList().ForEach(d =>
            {               
                    d.processado = true;
                    bd.SaveChanges();                
            });
            bd.SaveChanges();
            buscarDelivery(cliente);

        }

        private void adicionar(object sender, EventArgs e)
        {
            byte[] fotoArr;
            using (var ms = new MemoryStream())
            {
                pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
                fotoArr = ms.ToArray();
            };
            clientes novoCliente = new clientes()
            {
                nome = txtNome.Text,
                telefone = txtTelefone.Text,
                logradouro = txtLogradouro.Text,
                numero = Convert.ToInt32(txtNumero.Text),
                bairro = txtBairro.Text,
                complemento = txtComplemento.Text,
                cpf = txtCpf.Text,
                cep = txtCep.Text,
                uf = cbUF.Text,
                cidade = txtCidade.Text,
                foto = fotoArr
            };
            bd.clientes.Add(novoCliente);
            bd.SaveChanges();
			txtBairro.Clear();
			txtNome.Clear();
			txtCep.Clear();
			txtCpf.Clear();
			cbUF.Text = "";
			txtCidade.Clear();
			txtNumero.Clear();
			txtLogradouro.Clear();
			txtTelefone.Clear();
			txtComplemento.Clear();
			pictureBox2.Image = Properties.Resources.cadastro;
			MessageBox.Show("Cliente cadastrado com sucesso");
        }

        private void processados(object sender, EventArgs e)
        {
            string data = "";
            if (ckProcessados.Checked != false)
            {
                tblPedidosEntrega.Rows.Clear();
                idCliente = bd.delivery.Where(d => d.id_cliente.Equals(cliente.id)).FirstOrDefault();
                if (idCliente != null)
                {
                    string processado2 = "";
                    delivery3.ToList().ForEach(d =>
                    {
                        if (d.processado == true)
                        {
                            processado2 = "Sim";
                        }
                    });
                    delivery2.ToList().ForEach(u2 =>
                    {
                        bd.pedido.ToList().ForEach(p =>
                        {
                            if (p.id == u2.id_pedido)
                            {
                                data = p.data.ToString();
                            }
                        });
                        if (u2.processado == true && u2.id_cliente == cliente.id)
                        {
                            tblPedidosEntrega.Rows.Add(u2.id_cliente, u2.id_entregador, u2.id_pedido, processado2, data);
                        }
                    });
                }
            }
            if (ckProcessados.Checked != true)
            {
                tblPedidosEntrega.Rows.Clear();


                string processado = "";
                delivery3.ToList().ForEach(d =>
                {
                    if (d.processado == false)
                    {
                        processado = "Não";
                    }
                });

                delivery2.ToList().ForEach(u2 =>
                {
                    bd.pedido.ToList().ForEach(p =>
                    {
                        if (p.id == u2.id_pedido)
                        {
                            data = p.data.ToString();
                        }
                    });
                    if (!u2.processado && u2.id_cliente == cliente.id)
                    {
                        tblPedidosEntrega.Rows.Add(u2.id_cliente, u2.id_entregador, u2.id_pedido, processado, data);
                    }
                });
            }

        }

        private void novoPedido(object sender, EventArgs e)
        {
            new NovoPedidoDelivery(cliente).Show();
            this.Hide();
        }

        private void checkTecla(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pesquisar(sender, e);
            }
        }

        private void voltar(object sender, EventArgs e)
        {
            if (Inicio.logado.tipo_usuario == 1)
            {
                new Menu().Show();
                this.Hide();
            }
            else
            {
                new Inicio().Show();
                this.Hide();
            }

        }
        private void pesquisar(object sender, EventArgs e)
        {
            tblPedidosEntrega.Rows.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtLogradouro.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCpf.Clear();
            cbUF.Text = "";
            pictureBox2.Image = Properties.Resources.cadastro;
            cliente = bd.clientes.Where(c => c.telefone.Equals(txtTelefone.Text)).FirstOrDefault();
            if (cliente != null)
            {
                txtNome.Text = cliente.nome;
                txtNumero.Text = Convert.ToString(cliente.numero);
                txtBairro.Text = cliente.bairro;
                txtLogradouro.Text = cliente.logradouro;
                txtComplemento.Text = cliente.complemento;
                txtCpf.Text = cliente.cpf;
                txtCep.Text = cliente.cep;
                cbUF.Text = cliente.uf;
                txtCidade.Text = cliente.cidade;
                nome = txtNome.Text;
                telefone = txtTelefone.Text;
                if (cliente.foto != null)
                {
                    using (var ms = new MemoryStream(cliente.foto))
                    {
                        pictureBox2.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox2.Image = Properties.Resources.cadastro;
                }
                buscarDelivery(cliente);
            }
            else
            {
                MessageBox.Show("Telefone não encontrado");
            }
        }

        private void buscarDelivery(clientes cliente)
        {
            tblPedidosEntrega.Rows.Clear();
            idCliente = bd.delivery.Where(d => d.id_cliente.Equals(cliente.id)).FirstOrDefault();
            string data = "";
            string hora = "";
            if (idCliente != null)
            {
                string processado = "";
                string nomeCliente = "";
                string nomeEntregador = "";
                delivery3.ToList().ForEach(d =>
                {
                    if (d.processado == false)
                    {
                        processado = "Não";
                    }
                });
                delivery2.ToList().ForEach(u2 =>
                {
                    clientes.ToList().ForEach(c =>
                    {
                        if (c.id == u2.id_cliente)
                        {
                            nomeCliente = c.nome;
                        }
                    });
                    usuarios.ToList().ForEach(u =>
                    {
                        if (u.id == u2.id_entregador)
                        {
                            nomeEntregador = u.nome;
                        }
                    });
                    bd.pedido.ToList().ForEach(p =>
                    {
                        if (p.id == u2.id_pedido)
                        {
                            hora = p.hora.ToString();
                            data = p.data.ToString();
                        }
                    });
                    if (!u2.processado && u2.id_cliente == cliente.id)
                    {
                        tblPedidosEntrega.Rows.Add(u2.id_cliente, u2.id_entregador, u2.id_pedido, processado, data);
                    }
                });
            }
        }
        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Enter)
            {
                MessageBox.Show("Somente é aceito números e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }

        }
        private void txtComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
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
        private void txtUf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
            }
        }
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Somente é aceito números e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Back)
            {
                MessageBox.Show("Somente é aceito números e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space)
            {
                MessageBox.Show("Somente é aceito números e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void TxtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deliverys_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaJulubom
{
    public partial class CadastroCliente : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        public CadastroCliente()
        {
            InitializeComponent();
            btnVoltar.Click += voltar;
            btnSalvar.Click += salvarCliente;
			btnCarregarFoto.Click += fotCarrega;
			pictureBox1.Image = Properties.Resources.cadastro;
		}

		private void fotCarrega(object sender, EventArgs e)
		{
			openFileDialog1.FileName = "Selecione uma imagem.";
			openFileDialog1.Filter = "png|*.png| jpg|*.jpg| jpeg|*.jpeg";
			openFileDialog1.Title = "Open image file";
			DialogResult dr = openFileDialog1.ShowDialog();
			if (dr == DialogResult.OK)
			{
				pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
			}
		}

		private void salvarCliente(object sender, EventArgs e)
        {
			byte[] fotoArr;
			using (var ms = new MemoryStream())
			{
				pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
				fotoArr = ms.ToArray();
			};

			clientes cliente = new clientes();
            cliente.nome = txtNome.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.cpf = txtCPF.Text;
            cliente.cep = txtCEP.Text;
            cliente.logradouro = txtLogradouro.Text;
            cliente.numero = Convert.ToInt16(txtNumero.Text);
            cliente.complemento = txtComplemento.Text;
            cliente.bairro = txtBairro.Text;
            cliente.uf =cbUF.Text;
            cliente.cidade = txtCidade.Text;
			cliente.foto = fotoArr;
            bd.clientes.Add(cliente);
            bd.SaveChanges();
            MessageBox.Show("Cliente salvo com sucesso");
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
			pictureBox1.Image = Properties.Resources.cadastro;
		}

        private void voltar(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
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
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
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
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
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
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
            }
        }
       
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space)
            {
                MessageBox.Show("Somente é aceito números e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Space)
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

    }
}

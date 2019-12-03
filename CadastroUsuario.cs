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
    public partial class CadastroUsuario : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        List<tipo_usuario> usuarios2;
        public CadastroUsuario()
        {
            InitializeComponent();
            txtSenha.UseSystemPasswordChar = true;
            btnSalvar.Click += salvarCadastro;
            btnVoltar.Click += voltar;
            usuarios2 = bd.tipo_usuario.ToList();
            txtSenha.KeyPress += salvarCadastro2;
            checkBox1.Click += mostrar;
            btnAlterar.Click += alterar;
			btnExcluir.Click += excluir;
            carregarTabela();
            carregarCombo();
            tblCadastros.RowHeaderMouseClick += carregarTXT;
        }

		private void excluir(object sender, EventArgs e)
		{
			int usuarioExcluir = Convert.ToInt32(tblCadastros.SelectedRows[0].Cells[0].Value);
			usuario usuario2 = new usuario();			
			
			bd.usuario.ToList().ForEach(u =>
			{
				if (u.id == usuarioExcluir)
				{
					usuario2 = u;
				}
			});
			bd.usuario.Remove(usuario2);
			bd.SaveChanges();
			carregarTabela();
			txtLogin.Clear();
			txtNome.Clear();
			txtSenha.Clear();
			cbTipoUsuario.Text = "";
			MessageBox.Show("Usuário excluído com sucesso");
		}

		private void carregarTXT(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNome.Text = tblCadastros.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLogin.Text = tblCadastros.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbTipoUsuario.Text = tblCadastros.Rows[e.RowIndex].Cells[3].Value.ToString();
            bd.usuario.ToList().ForEach(u =>
            {
                if (u.id == Convert.ToInt32(tblCadastros.SelectedRows[0].Cells[0].Value))
                {
                    txtSenha.Text = u.senha;
                }
            });
        }

        private void alterar(object sender, EventArgs e)
        {

            string novoNome = txtNome.Text;
            string novoLogin = txtLogin.Text;
            string novaSenha = txtSenha.Text;
            string novoTipoUsuario = cbTipoUsuario.Text;
            int alterar = Convert.ToInt32(tblCadastros.SelectedRows[0].Cells[0].Value);
            int tipoUsuario = 0;
            usuario usuarioNovo = new usuario();
            bd.usuario.ToList().ForEach(u =>
            {
                if (u.id == alterar)
                {                    
                    u.nome = novoNome;
                    u.login = novoLogin;
                    u.senha = novaSenha;
                    if (u.tipo_usuario == 1)
                    {
                        tipoUsuario = 1;
                    }
                    if (u.tipo_usuario == 2)
                    {
                        tipoUsuario = 2;
                    }
                    u.tipo_usuario = tipoUsuario;

                    bd.SaveChanges();
                }

            });
            carregarTabela();
			txtLogin.Clear();
			txtNome.Clear();
			txtSenha.Clear();
			cbTipoUsuario.Text = "";
			MessageBox.Show("Usuário alterado com sucesso");
		}

        private void mostrar(object sender, EventArgs e)
        {
            if (checkBox1.Checked != false)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
        private void carregarCombo()
        {
            cbTipoUsuario.Items.Clear();
            bd.tipo_usuario.ToList().ForEach(u2 =>
            {
                if (u2.id != 3)
                {
                    cbTipoUsuario.Items.Add(u2.nome);
                }
            });
        }

        private void salvarCadastro2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                salvarCadastro(sender, e);
            }
        }
        private void voltar(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void salvarCadastro(object sender, EventArgs e)
        {
            tipo_usuario selecionado = usuarios2.ElementAt(cbTipoUsuario.SelectedIndex);
            usuario novo = new usuario()
            {
                nome = txtNome.Text,
                login = txtLogin.Text,
                senha = txtSenha.Text,
                tipo_usuario = selecionado.id
            };
            bd.usuario.Add(novo);
            bd.SaveChanges();
            carregarTabela();
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
            cbTipoUsuario.Text = "";
			MessageBox.Show("Usuário salvo com sucesso");
		}
        private void carregarTabela()
        {
            string tipoUso = "";
            string tipoUso2 = "";
            bd.tipo_usuario.ToList().ForEach(u3 =>
            {
                if (u3.id == 1)
                {
                    tipoUso = u3.nome;
                }
                if (u3.id == 2)
                {
                    tipoUso2 = u3.nome;
                }
            });

            tblCadastros.Rows.Clear();
            bd.usuario.ToList().ForEach(u =>
            {

                if (u.tipo_usuario != 3)
                {
                    if (u.tipo_usuario == 1)
                    {
                        tblCadastros.Rows.Add(u.id, u.nome, u.login, tipoUso);
                    }
                    else
                    {
                        tblCadastros.Rows.Add(u.id, u.nome, u.login, tipoUso2);
                    }
                };
            });
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != (char)Keys.Space && e.KeyChar != (char)Keys.Enter && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Não são aceitos caracteres especiais");
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

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08)
            {
                e.Handled = true;
                MessageBox.Show("Não são aceitos caracteres especiais");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}

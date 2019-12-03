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
    public partial class Inicio : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        public static usuario logado = new usuario(); // vai aparecer o nome da pessoa em todas as telas
        public Inicio()
        {
            InitializeComponent();
            btnCadastrar.Click += cadastrar;
            btnEntrar.Click += entrar;
            btnSair.Click += sair;
            txtSenha.KeyPress += entrar2;
        }

        private void entrar2(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                entrar(sender, e);
            }
        }

        private void sair(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void entrar(object sender, EventArgs e)
        {
            logado = bd.usuario.Where(u => u.login.Equals(txtNome.Text) && u.senha.Equals(txtSenha.Text) && (u.tipo_usuario == 1 || u.tipo_usuario == 2)).FirstOrDefault();
            if (logado != null)
            {
				if (logado.tipo_usuario == 1)
				{
					new Menu().Show();
					this.Hide();
				}
				if(logado.tipo_usuario == 2)
				{
                    new Deliverys().Show();
                    this.Hide();
				}
            }
            else
            {
                MessageBox.Show("Usúario ou Senha incorretos");
                txtNome.Clear();
                txtSenha.Clear();
            }
        }
        private void cadastrar(object sender, EventArgs e)
        {
            new CadastroUsuario().Show();
            this.Hide();
        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Enter)
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            if (regex.IsMatch(e.KeyChar.ToString()) && e.KeyChar != 08 && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
                MessageBox.Show("Não são aceitos caracteres especiais");
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}

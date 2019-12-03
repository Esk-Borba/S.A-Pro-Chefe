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
    public partial class Menu : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        public Menu()
        {
            InitializeComponent();
            btnMesas.Click += mesas;
            btnPizza.Click += pizza;
            btnCliente.Click += cliente;
            btnAlteracoes.Click += alterar;
            btnDelivery.Click += delivery;
            btnSair2.Click += sair;
            btnSair.Click += sair2;
            montaMesas();
            montaMesas2();
            montaMesas3();
            montaMesas4();
        }

        private void sair2(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void montaMesas4()
        {
            bd.mesa.ToList().ForEach(m =>
            {
                if (m.disponibilidade == "Indisponível")
                {
                    Panel panel = new Panel();
                    panel.Width = 55;
                    panel.Height = 55;
                    panel.BackColor = Color.SaddleBrown;

                    Label nomeMesa = new Label();
                    nomeMesa.ForeColor = Color.White;
                    nomeMesa.Text = $" Mesa {m.id}";
                    panel.Controls.Add(nomeMesa);

                    PictureBox foto = new PictureBox();
                    foto.Image = Properties.Resources.iconfinder_architecture_interior_27_809104__1_;
                    foto.Click += selecionaMesa;
                    foto.Name = m.id.ToString();
                    panel.Controls.Add(foto);

                    flowLayoutPanel6.Controls.Add(panel);
                }
            });
        }

        private void montaMesas3()
        {
            bd.mesa.ToList().ForEach(m =>
            {
                if (m.disponibilidade == "Indisponível")
                {
                    Panel panel = new Panel();
                    panel.Width = 55;
                    panel.Height = 55;
                    panel.BackColor = Color.SaddleBrown;

                    Label nomeMesa = new Label();
                    nomeMesa.ForeColor = Color.White;
                    nomeMesa.Text = $" Mesa {m.id}";
                    panel.Controls.Add(nomeMesa);

                    PictureBox foto = new PictureBox();
                    foto.Image = Properties.Resources.iconfinder_architecture_interior_27_809104__1_;
                    foto.Click += selecionaMesa;
                    foto.Name = m.id.ToString();
                    panel.Controls.Add(foto);

                    flowLayoutPanel5.Controls.Add(panel);
                }
            });
        }

        private void alterar(object sender, EventArgs e)
        {
            new Alteracoes().Show();
            this.Hide();
        }

        private void delivery(object sender, EventArgs e)
        {
            new Deliverys().Show();
            this.Hide();
        }

        private void montaMesas()
        {
            bd.mesa.ToList().ForEach(m =>
            {
                if (m.disponibilidade == "Disponível")
                {
                    Panel panel = new Panel();
                    panel.Width = 55;
                    panel.Height = 55;
                    panel.BackColor = Color.SaddleBrown;

                    Label nomeMesa = new Label();
                    nomeMesa.ForeColor = Color.White;
                    nomeMesa.Text = $" Mesa {m.id}";
                    panel.Controls.Add(nomeMesa);

                    PictureBox foto = new PictureBox();
                    foto.Image = Properties.Resources.iconfinder_architecture_interior_27_809104__1_;
                    foto.Click += selecionaMesa;
                    foto.Name = m.id.ToString();
                    panel.Controls.Add(foto);

                    flowLayoutPanel2.Controls.Add(panel);
                }
            });
        }
        private void selecionaMesa(object sender, EventArgs e)
        {
            PictureBox mesaSelecionada = (PictureBox)sender;

            mesa mesa = bd.mesa.Find(Convert.ToInt32(mesaSelecionada.Name));

            new Pedidos(mesa).Show();
            this.Hide();
        }
        private void montaMesas2()
        {
            bd.mesa.ToList().ForEach(m2 =>
            {

                if (m2.disponibilidade == "Disponível")
                {
                    Panel panel = new Panel();
                    panel.Width = 55;
                    panel.Height = 55;
                    panel.BackColor = Color.SaddleBrown;

                    Label nomeMesa = new Label();
                    nomeMesa.ForeColor = Color.White;
                    nomeMesa.Text = $" Mesa {m2.id}";
                    panel.Controls.Add(nomeMesa);

                    PictureBox foto = new PictureBox();
                    foto.Image = Properties.Resources.iconfinder_architecture_interior_27_809104__1_;
                    foto.Click += selecionaMesa;
                    foto.Name = m2.id.ToString();
                    panel.Controls.Add(foto);

                    flowLayoutPanel4.Controls.Add(panel);
                }
            });
        }
        private void selecionaMesa2(object sender, EventArgs e)
        {
            PictureBox mesaSelecionada2 = (PictureBox)sender;

            mesa mesa = bd.mesa.Find(Convert.ToInt32(mesaSelecionada2.Name));

            new Pedidos(mesa).Show();
            this.Hide();
        }
        private void sair(object sender, EventArgs e)
        {
            new Inicio().Show();
            this.Hide();
        }

        private void pizza(object sender, EventArgs e)
        {
            new Pizza().Show();
            this.Hide();
        }

        private void cliente(object sender, EventArgs e)
        {
            new CadastroCliente().Show();
            this.Hide();
        }

        private void mesas(object sender, EventArgs e)
        {
            new Mesas().Show();
            this.Hide();
        }

        private void FlowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

    }
}

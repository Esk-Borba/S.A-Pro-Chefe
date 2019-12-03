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
    public partial class Pedidos : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        mesa mesaSelecionada;
        public Pedidos()
        {
            InitializeComponent();           
        }

        private void voltar(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        public Pedidos(mesa mesaSel)
        {
            InitializeComponent();
            this.mesaSelecionada = mesaSel;
            label4.Text += mesaSel.id;
            label5.Text += mesaSel.disponibilidade;
            label6.Text += mesaSel.capacidade + " pessoas";
            btnVoltar2.Click += voltar;
            btnPedidos.Click += pedidosCliente;
            TotalMesa();
        }

        private void TotalMesa()
        {
            double total = 0.0;

        }

        private void pedidosCliente(object sender, EventArgs e)
        { 
            new PedidoCliente(mesaSelecionada).Show();
            this.Hide();
        }

        private void BtnVoltar2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}

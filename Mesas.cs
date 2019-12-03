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
    public partial class Mesas : Form
    {
        pro_chefeEntities bd = new pro_chefeEntities();
        public Mesas()
        {
            InitializeComponent();
            btnSalvar.Click += salvar;
            btnVoltar.Click += sair;
			btnAlterar1.Click += alterar;			
            carregarTabela();
			tblMesas.RowHeaderMouseClick += carregarTxt1;
		}

		private void carregarTxt1(object sender, DataGridViewCellMouseEventArgs e)
		{
			numCapacidade.Text = tblMesas.Rows[e.RowIndex].Cells[1].Value.ToString();
			cbDisponibilidade.Text = tblMesas.Rows[e.RowIndex].Cells[2].Value.ToString();
			if (tblMesas.Rows[e.RowIndex].Cells[3].Value.ToString() == null)
			{
				txtObservacao.Text = "";
			}
			else
			{
			txtObservacao.Text = tblMesas.Rows[e.RowIndex].Cells[3].Value.ToString();
			}
		}

		private void alterar(object sender, EventArgs e)
		{
			string novaCapacidade = numCapacidade.Text;
			string novoDisponibilidade = cbDisponibilidade.Text;
			string novoObservacao = txtObservacao.Text;			
			int alterar = Convert.ToInt32(tblMesas.SelectedRows[0].Cells[0].Value);
			mesa mesaNova = new mesa();
			bd.mesa.ToList().ForEach(m =>
			{
				if (m.id == alterar)
				{
					m.capacidade = Convert.ToInt32(novaCapacidade);
					m.disponibilidade = novoDisponibilidade;
					m.observacao = novoObservacao;					
					bd.SaveChanges();
				}

			});
			carregarTabela();
			numCapacidade.Text = "";
			cbDisponibilidade.Text = "";
			txtObservacao.Clear();
			MessageBox.Show("Mesa alterada com sucesso");
		}

		private void sair(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void salvar(object sender, EventArgs e)
        {
            mesa novaMesa = new mesa()
            {
                capacidade = Convert.ToInt16(numCapacidade.Text),
                disponibilidade = cbDisponibilidade.Text,
                observacao = txtObservacao.Text
            };
            bd.mesa.Add(novaMesa);
            bd.SaveChanges();
            MessageBox.Show("Mesa salva com sucesso");
            carregarTabela();
            numCapacidade.Text = "";
            cbDisponibilidade.Text = "";
            txtObservacao.Clear();
        }
        public void carregarTabela()
        {
			tblMesas.Rows.Clear();
			bd.mesa.ToList().ForEach(m =>
            {
                tblMesas.Rows.Add(m.id, m.capacidade, m.disponibilidade, m.observacao);
            });
        }
        private void TxtCapacidade_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)))
            {
                MessageBox.Show("Somente é aceito letras e não são aceitos caracteres especiais");
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cartas_Arbitro : Form
    {
        int id_carta = 0;
        public Cartas_Arbitro()
        {
            InitializeComponent();
        }

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        private void btAdicionarCartas_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string facao = txtFacao.Text;
            string tipo = txtTipo.Text;
            int lealdade = Convert.ToInt32(txtLealdade.Text);
            int custo = Convert.ToInt32(txtLealdade.Text);
            string regras = txtRegras.Text;
            int ataque = Convert.ToInt32(NumericAtaque.Text);
            int defesa = Convert.ToInt32(NumericDefesa.Text);
            int imagem = 0;

            Card carta = new Card
            {
                Name = nome,
                Faction = facao,
                Type = tipo,
                Loyalty = lealdade,
                Cost = custo,
                RuleText = regras,
                Attack = ataque,
                Defense = defesa,
                Image = imagem
            };

            container.CardSet.Add(carta);
            container.SaveChanges();

            refresh_datagrid();
        }

        private void DataGridCartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = DataGridCartas.CurrentRow.Cells[1].Value.ToString();
            txtFacao.Text = DataGridCartas.CurrentRow.Cells[2].Value.ToString();
            txtTipo.Text = DataGridCartas.CurrentRow.Cells[3].Value.ToString();
            txtLealdade.Text = DataGridCartas.CurrentRow.Cells[4].Value.ToString();
            NumericDefesa.Text = DataGridCartas.CurrentRow.Cells[5].Value.ToString();
            txtcusto.Text = DataGridCartas.CurrentRow.Cells[6].Value.ToString();
            txtRegras.Text = DataGridCartas.CurrentRow.Cells[7].Value.ToString();
            NumericAtaque.Text = DataGridCartas.CurrentRow.Cells[8].Value.ToString();
            LinkLabelImagem.Text = DataGridCartas.CurrentRow.Cells[9].Value.ToString();


            id_carta = (int)DataGridCartas.CurrentRow.Cells[0].Value;
        }

        public void refresh_datagrid()
        {

            this.cardSetTableAdapter.Fill(this.baseDadosDataSet_Cards.CardSet);
            DataGridCartas.DataSource = cardSetBindingSource;

        }

        private void btAlterarCarta_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string facao = txtFacao.Text;
            string tipo = txtTipo.Text;
            int lealdade = Convert.ToInt32(txtLealdade.Text);
            int custo = Convert.ToInt32(txtLealdade.Text);
            string regras = txtRegras.Text;
            int ataque = Convert.ToInt32(NumericAtaque.Text);
            int defesa = Convert.ToInt32(NumericDefesa.Text);
            int imagem = 0;

            Card carta;

            carta = container.CardSet.Find(id_carta);
            carta.Name = nome;
            carta.Faction = facao;
            carta.Type = tipo;
            carta.Loyalty = lealdade;
            carta.Cost = custo;
            carta.RuleText = regras;
            carta.Attack = ataque;
            carta.Defense = defesa;
            carta.Image = imagem;

            container.Entry(carta).State = System.Data.Entity.EntityState.Modified;
            container.SaveChanges();

            MessageBox.Show("Alterado com sucesso!");

            refresh_datagrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Card carta = container.CardSet.Find(id_carta);

            container.CardSet.Remove(carta);

            container.SaveChanges();


            MessageBox.Show("Eliminado com sucesso!");

            refresh_datagrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {

                var query = container.CardSet.Where(carta => carta.Name.Contains(tbxpesquisa.Text));

                DataGridCartas.DataSource = query.ToList();
            }

            else
            {
                refresh_datagrid();
            }
        }



        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro();
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BAfrm = new Baralho_Arbitro();
            BAfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CAfrm = new Cartas_Arbitro();
            CAfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JArbfrm = new JogoArbitro();
            JArbfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou AOTfrm = new Arbitro_JogosOndeTou();
            AOTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro();
            Histfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void Cartas_Arbitro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet_Cards.CardSet' table. You can move, or remove it, as needed.
            this.cardSetTableAdapter.Fill(this.baseDadosDataSet_Cards.CardSet);

        }

        
    }
}

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
    public partial class Cartas_ADM : Form
    {
        /// <summary>
        /// Variavel gobal
        /// </summary>
        int id_carta = 0;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public Cartas_ADM()
        {
            InitializeComponent();
        }

        private void btAdicionarCartas_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string facao = txtFacao.Text;
            string tipo = txtTipo.Text;
            int lealdade = Convert.ToInt32(txtLealdade.Text);
            int custo = Convert.ToInt32(txtLealdade.Text);
            string regras = txtRegras.Text;
            int ataque = Convert.ToInt32(txtAtaque.Text);
            int defesa = Convert.ToInt32(txtDefesa.Text);
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

        private void Cartas_ADM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet.CardSet' table. You can move, or remove it, as needed.
            this.cardSetTableAdapter.Fill(this.baseDadosDataSet.CardSet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = DataGridCartas.CurrentRow.Cells[1].Value.ToString();
            txtFacao.Text = DataGridCartas.CurrentRow.Cells[2].Value.ToString();
            txtTipo.Text = DataGridCartas.CurrentRow.Cells[3].Value.ToString();
            txtLealdade.Text = DataGridCartas.CurrentRow.Cells[4].Value.ToString();
            txtDefesa.Text = DataGridCartas.CurrentRow.Cells[5].Value.ToString();
            txtcusto.Text = DataGridCartas.CurrentRow.Cells[6].Value.ToString();
            txtRegras.Text = DataGridCartas.CurrentRow.Cells[7].Value.ToString();
            txtAtaque.Text = DataGridCartas.CurrentRow.Cells[8].Value.ToString();
            txtImagem.Text = DataGridCartas.CurrentRow.Cells[9].Value.ToString();
            

            id_carta = (int)DataGridCartas.CurrentRow.Cells[0].Value;
        }

        public void refresh_datagrid()
        {
            this.cardSetTableAdapter.Fill(this.baseDadosDataSet.CardSet);
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
            int ataque = Convert.ToInt32(txtAtaque.Text);
            int defesa = Convert.ToInt32(txtDefesa.Text);
            int imagem = 0;

            // objeto já criado
            Card carta;

            MessageBox.Show(id_carta.ToString());
            //vai procurar o id da carta 
            carta = container.CardSet.Find(id_carta);
            MessageBox.Show(carta.Name);
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

        private void Cartas_ADM_Load(object sender, EventArgs e)
        {

        }
    }
}

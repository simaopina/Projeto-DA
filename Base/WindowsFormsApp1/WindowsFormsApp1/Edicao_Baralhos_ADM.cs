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
   
    public partial class Edicao_Baralhos_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        int id_baralho = 0;

        int id_cartas = 0;

        Card CartaSelecionada = null;

        public Edicao_Baralhos_ADM()
        {
            InitializeComponent();

             foreach(Deck baralho in container.DeckSet)
             {
                 cbxBaralho.Items.Add(baralho.Name);
             }


             foreach(Card cartas in container.CardSet)
            {
                listVCartas.Items.Add(cartas.Name);
            }
        }
        //Navegação

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarADMfrm = new Baralho_ADM();
            BarADMfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM Cfrm = new Cartas_ADM();
            Cfrm.Show();
            Close();
        }
   
        private void addJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addJofrm = new ADD_Jogador_ADM();
            addJofrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM Hadmfrm = new Home_ADM();
            Hadmfrm.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cbxBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void listVCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           

    


        }

        

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa Iefrm = new InserirEquipa();
            Iefrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Uadmfrm = new Utilizadores_ADM();
            Uadmfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores Gtjfrm = new GestaoTorneioJogadores();
            Gtjfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas Gtefrm = new GestaoTorneioEquipas();
            Gtefrm.Show();
            Close();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM Ebfrm = new Edicao_Baralhos_ADM();
            Ebfrm.Show();
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void gbxEdBaralhoADM_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string nome = dataGridCartas.CurrentRow.Cells[1].Value.ToString();
            string facao= dataGridCartas.CurrentRow.Cells[2].Value.ToString();
            string tipo = dataGridCartas.CurrentRow.Cells[3].Value.ToString();
            string lealdade = dataGridCartas.CurrentRow.Cells[4].Value.ToString();
            string custo = dataGridCartas.CurrentRow.Cells[5].Value.ToString();
            string regras = dataGridCartas.CurrentRow.Cells[6].Value.ToString();
            string ataque = dataGridCartas.CurrentRow.Cells[7].Value.ToString();
            string defesa = dataGridCartas.CurrentRow.Cells[8].Value.ToString();
            string imagem = dataGridCartas.CurrentRow.Cells[9].Value.ToString();
            

            id_cartas = (int)dataGridCartas.CurrentRow.Cells[0].Value;
            



            Info_Cartas_ADM Info_cartas_ADM = new Info_Cartas_ADM(nome, facao, tipo, lealdade, custo, regras, ataque, defesa, imagem);
            Info_cartas_ADM.Show*/

        }

        private void Edicao_Baralhos_ADM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosCartasEdição.CardSet' table. You can move, or remove it, as needed.
           // this.cardSetTableAdapter.Fill(this.baseDadosCartasEdição.CardSet);

        }

        private void listVCartas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

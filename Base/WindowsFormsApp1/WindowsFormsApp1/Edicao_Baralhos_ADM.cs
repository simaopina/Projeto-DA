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

        DiagramaEntidadesArcmageContainer dbAC;
        
        //Inicialização de Form
        public Edicao_Baralhos_ADM()
        {
            InitializeComponent();

            //iniciar "base de dados"
            dbAC = new DiagramaEntidadesArcmageContainer();

            carregar_Baralho();
            carregar_Carta();
            carregar_Carta_Baralho();

        }


        //Eventos
        private void listBoxBaralho_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            carregar_Carta_Baralho();
        }

        private void listBoxCartas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        //Funções
        private void carregar_Baralho()
        {
            List<Deck> baralhos = (from d in dbAC.DeckSet
                                   select d).ToList();

            listBoxBaralho.Items.Clear();
            listBoxBaralho.Items.AddRange(baralhos.ToArray());
        }

        private void carregar_Carta()
        {
            List<Card> cartas = (from c in dbAC.CardSet
                                 select c).ToList();

            listBoxCartas.Items.Clear();
            listBoxCartas.Items.AddRange(cartas.ToArray());
        }

        private void carregar_Carta_Baralho()
        {
            Deck deckSelecionado = (Deck)listBoxBaralho.SelectedItem;

            if (deckSelecionado != null)
            {
                listBoxCartasBaralho.Items.Clear();
                listBoxCartasBaralho.Items.AddRange(deckSelecionado.Deck_Card.ToArray());
            }
        }

        public void Adicionar()
        {
            Deck baralhos = (Deck)listBoxBaralho.SelectedItem;
            Card cartas = (Card)listBoxCartas.SelectedItem;

           // int quantidade_carta = Convert.ToInt32();

            if (baralhos != null && cartas != null)
            {
                Deck_Card novoBaralhoCarta = new Deck_Card();
                novoBaralhoCarta.Deck = baralhos;
                novoBaralhoCarta.Card = cartas;
                novoBaralhoCarta.Quantity = 1.ToString();
                dbAC.Deck_CardSet.Add(novoBaralhoCarta);
                dbAC.SaveChanges();
                carregar_Carta_Baralho();
            }
            else
            {
                MessageBox.Show("Tem que selecionar os registos!");
            }

        }

        public void Remover()
        {

            Deck_Card baralhos_cartas = (Deck_Card)listBoxCartasBaralho.SelectedItem;

            if (baralhos_cartas != null)
            {
                dbAC.Deck_CardSet.Remove(baralhos_cartas);
                dbAC.SaveChanges();
                carregar_Carta_Baralho();
            }
            else
            {
                MessageBox.Show("Tem que selecionar os registos!");
            }

        }


        //Botões
        private void btnAdicionarBaralho_Click(object sender, EventArgs e)
        {
            Adicionar();
            carregar_Carta_Baralho();

        }

        private void btnRemoverBaralho_Click(object sender, EventArgs e)
        {
             Remover();
        }




        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM Hadmfrm = new Home_ADM();
            Hadmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BAdmfrm = new Baralho_ADM();
            BAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EdBarAdmfrm = new Edicao_Baralhos_ADM();
            EdBarAdmfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cartas_ADM CarAdmfrm = new Cartas_ADM();
            CarAdmfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM Addjogfrm = new ADD_Jogador_ADM();
            Addjogfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InserirEquipa InsEqufrm = new InserirEquipa();
            InsEqufrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Utilizadores_ADM Utilfrm = new Utilizadores_ADM();
            Utilfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio CTornfrm = new CriarTorneio();
            CTornfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GesTorJogfrm = new GestaoTorneioJogadores();
            GesTorJogfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GesTorEqufrm = new GestaoTorneioEquipas();
            GesTorEqufrm.Show();
            Close();
        }

        private void listaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogos Jfrm = new Jogos();
            Jfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

    }
}

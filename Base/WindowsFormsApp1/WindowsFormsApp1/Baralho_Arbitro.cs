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
    public partial class Baralho_Arbitro : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public Baralho_Arbitro()
        {
            InitializeComponent();

            carregar_Baralho();
            carregar_Carta_Baralho();
            
        }

        private void carregar_Baralho()
        {
            List<Deck> baralhos = (from d in container.DeckSet
                                   select d).ToList();

            listBoxBaralho.Items.Clear();
            listBoxBaralho.Items.AddRange(baralhos.ToArray());
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

        public void vercartas()
        {

            Deck deckSelecionado = (Deck)listBoxBaralho.SelectedItem;

            Deck baralhos = (Deck)listBoxBaralho.SelectedItem;

            listBoxCartasBaralho.Items.Clear();

            List<Deck_Card> cartaembaralhos = (from d in container.Deck_CardSet
                                               select d).ToList();

            if (deckSelecionado != null)
            {
                listBoxCartasBaralho.Items.Clear();


                listBoxCartasBaralho.Items.AddRange(deckSelecionado.Deck_Card.ToArray());
            }
        }


        private void btnBaralhoGaianArbitro_Click(object sender, EventArgs e)
        {
            /*listVbaralho.LargeImageList = listaBaralhoArbitroGaianloveforlife;
            listVbaralho.Items.Clear();

            foreach (Card carta in container.CardSet)
            {
                ListViewItem item = new ListViewItem(carta.Name);
                //item.ImageIndex = carta.Image;
                listVbaralho.Items.Add(item);
            }*/
        }

        private void btnBaralhoUneasyADM_Click(object sender, EventArgs e)
        {
            /*listVbaralho.LargeImageList = listaBaralhoArbitroUneasyAlliance;
            listVbaralho.Items.Clear();

            foreach (Card carta in container.CardSet)
            {
                ListViewItem item = new ListViewItem(carta.Name);
               // item.ImageIndex = carta.Image;
                listVbaralho.Items.Add(item);
            }*/
        }

        private void Baralho_Arbitro_Load(object sender, EventArgs e)
        {

        }
        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro Hadmfrm = new Home_Arbitro();
            Hadmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro Barbfrm = new Baralho_Arbitro();
            Barbfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro Cartfrm = new Cartas_Arbitro();
            Cartfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JogoArfrm = new JogoArbitro();
            JogoArfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOTfrm = new Arbitro_JogosOndeTou();
            ArbOTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro(id);
            Histfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void listVbaralho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCartasBaralho.Items.Clear();
            vercartas();
            
        }
    }
}

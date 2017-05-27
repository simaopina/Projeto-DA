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

        Card CartaSelecionada;

        Deck BaralhoSelecionado;

        Deck_Card CartaEmBaralho;

        ListViewItem CartaList; 

        public Edicao_Baralhos_ADM()
        {
            InitializeComponent();

            foreach (Deck baralho in container.DeckSet)
             {
                 cbxBaralho.Items.Add(baralho.Name);
             }

       

            foreach (Card cartas in container.CardSet)
            { 
                ListViewItem CartaList = new ListViewItem(cartas.Name);
                CartaList.SubItems.Add(cartas.Faction);
                CartaList.SubItems.Add(cartas.Type);
                CartaList.SubItems.Add(Convert.ToString(cartas.Loyalty));
                CartaList.SubItems.Add(Convert.ToString(cartas.Cost));
                CartaList.SubItems.Add(cartas.RuleText);
                CartaList.SubItems.Add(Convert.ToString(cartas.Attack));
                CartaList.SubItems.Add(Convert.ToString(cartas.Defense));
                CartaList.SubItems.Add(cartas.Image);

                listVCartas.Items.Add(CartaList);
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
            string nome = BaralhoSelecionado.Name;

            Deck baralho = new Deck
            {
                Name = nome
            };

            baralho = container.DeckSet.Find(id_baralho);
            baralho.Name = nome;


            var query = container.Deck_CardSet.Where(CartaEmBaralho => CartaEmBaralho.DeckId.Equals(id_baralho));
            query.ToList();


            int id = CartaSelecionada.Id;

            Card cartas = new Card
            {
                Id = id
            };

            foreach(var id_card in query.ToList())
            {
                Card carta = container.CardSet.Find(id_cartas);

                container.Deck_CardSet.Add(id_card);
                
            }

            refreshlistvbaralhos();

            refreshlistvcartas();
            
           
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

       

        private void Edicao_Baralhos_ADM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosCartasEdição.CardSet' table. You can move, or remove it, as needed.
           // this.cardSetTableAdapter.Fill(this.baseDadosCartasEdição.CardSet);

        }

        private void listVCartas_SelectedIndexChanged_1(object sender, EventArgs e)
        {

           


        }

        private void btnAdicionarBaralho_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in this.listVCartas.SelectedItems)
            {
                var item = (selectedItem as ListViewItem);
                listVCartas.Items.Remove(item);
                this.listVBaralho.Items.Add(item);
            }


          
            container.DeckSet.Add(BaralhoSelecionado);
            container.SaveChanges();

        }

        public void refreshlistvcartas()
        {

            foreach (Card cartas in container.CardSet)
            {
                ListViewItem CartaList = new ListViewItem(cartas.Name);
                CartaList.SubItems.Add(cartas.Faction);
                CartaList.SubItems.Add(cartas.Type);
                CartaList.SubItems.Add(Convert.ToString(cartas.Loyalty));
                CartaList.SubItems.Add(Convert.ToString(cartas.Cost));
                CartaList.SubItems.Add(cartas.RuleText);
                CartaList.SubItems.Add(Convert.ToString(cartas.Attack));
                CartaList.SubItems.Add(Convert.ToString(cartas.Defense));
                CartaList.SubItems.Add(cartas.Image);

                listVCartas.Items.Add(CartaList);
            }


        }

        public void refreshlistvbaralhos()
        {

            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralho.Items.Add(baralho.Name);
            }
            
        }

        private void btnRemoverBaralho_Click(object sender, EventArgs e)
        {
            foreach (var selectedItem in this.listVBaralho.SelectedItems)
            {
                var item = (selectedItem as ListViewItem);
                listVBaralho.Items.Remove(item);
                this.listVCartas.Items.Add(item);
            }
        }
    }
    }


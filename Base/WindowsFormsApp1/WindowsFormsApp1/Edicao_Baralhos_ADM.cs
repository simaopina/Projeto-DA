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


            foreach (Deck_Card baralho in container.Deck_CardSet)
            {
                listVBaralho.Items.Add(baralho.CardId.ToString());
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

        //private void cbxBaralho_SelectedIndexChanged(object sender, EventArgs e)
       // {           

           /* string nome = Convert.ToString(cbxBaralho.SelectedItem);
                        
            Deck baralho;
            
            baralho = container.DeckSet.Find(id_baralho);*/
           

            /*var query = container.Deck_CardSet.Where(CartaEmBaralho => CartaEmBaralho.DeckId.Equals(id_baralho));
            query.ToList();

            Card cartas;

            foreach(var id_card in query.ToList())
            {
                Card carta = container.CardSet.Find(id_cartas);

            }

            Deck_Card cartaBaralho = new Deck_Card
            {
                CardId = id_cartas

            };

            container.Deck_CardSet.Add(id_cartas);*/

           // refreshlistvbaralhos();

            //refreshlistvcartas();
            
           
           //  }


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
            
	        string nome = Convert.ToString(cbxBaralho.SelectedItem);
                        
            Deck baralho;
            
            baralho = container.DeckSet.Find(id_baralho);

            refreshlistvbaralhos();


            foreach (var selectedItem in this.listVCartas.SelectedItems)
            {
                var item = (selectedItem as ListViewItem);
                listVCartas.Items.Remove(item);
                this.listVBaralho.Items.Add(item);
            }

         
            refreshlistvbaralhos();

        }

        public void refreshcmb()
        {

            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralho.Items.Add(baralho.Name);
            }
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
           
            foreach (Deck_Card baralho in container.Deck_CardSet)
            {
                listVBaralho.Items.Add(baralho.CardId.ToString());
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

        private void btnGuardarAlterações_Click(object sender, EventArgs e)
        {

            Card cartas;
            Deck_Card cartaBaralho;
            Deck BaralhoSelecionado;

            cartaBaralho = container.Deck_CardSet.Find(id_baralho);

            var id_cartas_antiga = 
                from ant in container.Deck_CardSet
                where ant.DeckId == id_baralho
                select ant;

            container.Deck_CardSet.RemoveRange(id_cartas_antiga.ToList<Deck_Card>());


            //var id_baralho = from id in container.Deck_CardSet where id.DeckId == id_baralho select id;

          

            foreach (ListViewItem item in listVBaralho.Items)
            {
                var procurar = container.CardSet.Where(nome => nome.Name.Equals(item.Text));
                cartas = procurar.ToList<Card>().First<Card>();

                cartaBaralho = new Deck_Card();
                cartaBaralho.DeckId = id_baralho;
                cartaBaralho.CardId = cartas.Id;

                container.Deck_CardSet.Add(cartaBaralho);
               
            }


            container.Entry(CartaSelecionada).State = System.Data.Entity.EntityState.Modified;
            container.SaveChanges();

            refreshlistvbaralhos();
           // refreshlistvcartas();
           // refreshcmb();


     
        }
    }
    }


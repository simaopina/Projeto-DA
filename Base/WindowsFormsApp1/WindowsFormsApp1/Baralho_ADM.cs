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
    public partial class Baralho_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        int id_baralho = 0;
        Deck deckselecionado = null;

        public Baralho_ADM()
        {
            InitializeComponent();

            refresh_listview();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();

            Hfrm.Show();
        }

        private void Baralho_ADM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosdeck.DeckSet' table. You can move, or remove it, as needed.
            this.deckSetTableAdapter.Fill(this.baseDadosdeck.DeckSet);

        }

        private void btnBaralhoGaianAMD_Click(object sender, EventArgs e)
        {
           

        }

        private void btnBaralhoUneasyADM_Click(object sender, EventArgs e)
        {
         //   ListVBaralhoADM.SmallImageList = ListaBaralhoUneasyAlliance;

        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM form = new Baralho_ADM();
            // Ao atribuirmos à propriedade FormPrincipal uma referência para o form atual (form MTADMMenu)
            // podemos usar, o form ArmaForm, os métodos públicos do form principal e aceder, através de métodos
            // próprios para o efeito (ex.: método AdicionarArma()), aos componentes existentes no form principal.
           
            form.Show();
        }

        private void ListVBaralhoADM_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Card carta in container.CardSet)
            {
                ListViewItem item = new ListViewItem(carta.Name);
                listVBaralhos.Items.Add(carta.Name);

            }
        }


     

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;

            Deck baralho = new Deck
            {

                Name = nome

            };

            container.DeckSet.Add(baralho);
            container.SaveChanges();
            refresh_listview();
            tbxNome.ResetText();
        }

        public void refresh_listview()
        {
            listVBaralhos.Items.Clear();
            List<Deck> Sdeck = container.DeckSet.ToList();

            foreach (Deck deck in Sdeck)
            {
                ListViewItem item = new ListViewItem(deck.Name);
                listVBaralhos.Items.Add(item);
            }
            

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVBaralhos.Items.Count];
                listVBaralhos.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxpesquisa.Text)).ToArray();

                listVBaralhos.Items.Clear();
                listVBaralhos.Items.AddRange(dados);

                if (listVBaralhos.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refresh_listview();
                    tbxpesquisa.ResetText();
                    tbxpesquisa.Focus();
                }
            }
            else
            {
                refresh_listview();
            }
        }






        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Name = deckselecionado.Name;

            var query = container.DeckSet.Where(deck => deck.Name.Equals(deckselecionado.Name));

            container.DeckSet.Remove(deckselecionado);

            container.SaveChanges();

            deckselecionado = null;

            MessageBox.Show("Torneio elimindado com sucesso!");

            tbxNome.ResetText();

            refresh_listview();

        }

        private void listVBaralhos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVBaralhos.SelectedItems != null)
            {
                string DeckU = listVBaralhos.SelectedItems[0].Text;
                deckselecionado = container.DeckSet.Where(deck => deck.Name.Equals(DeckU)).First();

                tbxNome.Text = deckselecionado.Name;

                refresh_listview();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string Nome = tbxNome.Text;

            List<Deck> deck = container.DeckSet.ToList();

            if(deckselecionado != null)
            {
                deckselecionado.Name = Nome;

                container.SaveChanges();

                MessageBox.Show("Alterado com sucesso!");

                refresh_listview();
                tbxNome.ResetText();
            }
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa Iepfrm = new InserirEquipa();
            Iepfrm.Show();
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

        private void torneioEquipasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas Gtefrm = new GestaoTorneioEquipas();
            Gtefrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBAdmfrm = new Edicao_Baralhos_ADM();
            EBAdmfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM CarAdmfrm = new Cartas_ADM();
            CarAdmfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addfrm = new ADD_Jogador_ADM();
            addfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InserirEquipa IEfrm = new InserirEquipa();
            IEfrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Utilizadores_ADM UAfrm = new Utilizadores_ADM();
            UAfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio CTfrm = new CriarTorneio();
            CTfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GTJfrm = new GestaoTorneioJogadores();
            GTJfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GTEfrm = new GestaoTorneioEquipas();
            GTEfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void listaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogos Jfrm = new Jogos();
            Jfrm.Show();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
             tbxNome.ResetText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
            Close();
        }
    }
}

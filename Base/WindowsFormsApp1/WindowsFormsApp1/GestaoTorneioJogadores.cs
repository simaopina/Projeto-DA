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
    public partial class GestaoTorneioJogadores : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        Player jogadorSelecionado = null;
        User userSelect = null;
        List<Player> Items = new List<Player>();
        List<Referee> Id = new List<Referee>();

        public GestaoTorneioJogadores()
        {
            InitializeComponent();

            foreach (Player jogador in container.PlayerSet)
            {
                ListViewItem jogadorList = new ListViewItem(Convert.ToString(jogador.Id));
                jogadorList.SubItems.Add(jogador.Name);

                listVJogador1.Items.Add(jogadorList);

            }

            foreach (Player jogador in container.PlayerSet)
            {
                ListViewItem jogadorList = new ListViewItem(Convert.ToString(jogador.Id));
                jogadorList.SubItems.Add(jogador.Name);

                listVJogador2.Items.Add(jogadorList);
            }

            foreach (Referee arbitro in container.UserSet.OfType<Referee>())
            {
                ListViewItem arbitroList = new ListViewItem(Convert.ToString(arbitro.Id));
                arbitroList.SubItems.Add(arbitro.Name);

                listVArbitro1.Items.Add(arbitroList);
            }

            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralhoJogador1.Items.Add(baralho.Id.ToString());
            }
            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralhoJogador2.Items.Add(baralho.Id.ToString());
            }
            foreach (Tournament torn in container.TournamentSet.OfType<StandadTournament>())
            {
                cbxTorneio.Items.Add(torn.Id.ToString());
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAfrm = new Home_ADM();
            HAfrm.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM barfrm = new Baralho_ADM();
            barfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home_ADM hmfrm = new Home_ADM();
            hmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM ebfrm = new Edicao_Baralhos_ADM();
            ebfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM ctfrm = new Cartas_ADM();
            ctfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addfrm = new ADD_Jogador_ADM();
            addfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa efrm = new InserirEquipa();
            efrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM ufrm = new Utilizadores_ADM();
            ufrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores gtfrm = new GestaoTorneioJogadores();
            gtfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas gtefrm = new GestaoTorneioEquipas();
            gtefrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home logfrm = new Home();
            logfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio tjsfrm = new CriarTorneio();
            tjsfrm.Show();
            Close();
        }

        private void btnPesquisarJogador1_Click(object sender, EventArgs e)
        {
            string overdose = listVJogador1.Items.ToString();
            validacao_pesquisar();
            if (tbxJogador1.Text.Length > 0)
            {

                //var query = container.PlayerSet.Where(pla => pla.Name.Contains(tbxJogador1.Text));

                if (overdose.StartsWith(tbxJogador1.Text) = true)
                {
                listVJogador1.Items.Clear();

                    listVJogador1.Items.AddRange(listVJogador1.Items.ToString().StartsWith(tbxJogador1.Text));
            }

                //dataGridJogador1.DataSource = query.ToList();
            }

            else
            {
                refresh_listview_Jogador1();
            }
        }

        private void btnPesquisarJogador2_Click(object sender, EventArgs e)
        {
            validacao_pesquisar();
            if (tbxJogador2.Text.Length > 0)
            {

                var query = container.PlayerSet.Where(pla => pla.Name.Contains(tbxJogador2.Text));

                //dataGridJogador2.DataSource = query.ToList();


            }

            else
            {
                refresh_listview_Jogador2();
            }
        }

        public void validacao_pesquisar()
        {
            if (tbxJogador1.Text == tbxJogador2.Text)
            {
                MessageBox.Show("Não poderá procurar esse jogador");
                tbxJogador1.Focus();
                refresh_listview_Jogador1();
            }
            else if(tbxJogador2.Text == tbxJogador1.Text)
            {
                MessageBox.Show("Não poderá procurar esse jogador");
                tbxJogador2.Focus();
                refresh_listview_Jogador2();
            }
        }


        private void GestaoTorneioJogadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet_Player.PlayerSet' table. You can move, or remove it, as needed.
            this.playerSetTableAdapter1.Fill(this.baseDadosDataSet_Player.PlayerSet);
            // TODO: This line of code loads data into the 'baseDadosDataSet_Referee.UserSet_Referee' table. You can move, or remove it, as needed.
            this.userSet_RefereeTableAdapter.Fill(this.baseDadosDataSet_Referee.UserSet_Referee);
            // TODO: This line of code loads data into the 'baseDadosDataSet4.PlayerSet' table. You can move, or remove it, as needed.
            this.playerSetTableAdapter.Fill(this.baseDadosDataSet4.PlayerSet);

        }

        private void btnPesquisarArbitro_Click(object sender, EventArgs e)
        {
            if (tbxArbitro.Text.Length > 0)
            {

                var query = container.UserSet.OfType<Referee>().Where(arb => arb.Name.Contains(tbxArbitro.Text));

                foreach (Referee refs in query.ToList())
                {

                    ListViewItem refereeList = new ListViewItem(Convert.ToString(refs.Id));
                    refereeList.SubItems.Add(refs.Name);

                    listVArbitro1.Items.Add(refereeList);
                }

                listVArbitro1.Items.Clear();

                listVArbitro1.Items.AddRange(Id.Where(i => string.IsNullOrEmpty(tbxArbitro.Text) || i.Name.StartsWith(tbxArbitro.Text)).Select(c => new ListViewItem(c.Name)).ToArray());

                //dataGridReferee.DataSource = query.ToList();
            }

            else
            {
                refresh_listview_Arbitro();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbxNumero.Text);
            DateTime data = datetimeData.Value;
            DateTime hora = datetimeHora.Value;
            string descricao = tbxDescricao.Text;
            int Player = Convert.ToInt32(listVJogador1.Items.ToString());
            int Player1 = Convert.ToInt32(listVJogador2.Items.ToString());
            int Referee = Convert.ToInt32(listVArbitro1.Items.ToString());
            int deck1 = Convert.ToInt32(cbxBaralhoJogador1.Text);
            int deck2 = Convert.ToInt32(cbxBaralhoJogador2.Text);
            int torneio = Convert.ToInt32(cbxTorneio.Text);

            StardadGame jogo = new StardadGame
            {
                PlayerId = Player,
                PlayerId1 = Player1,
                RefereeId = Referee,
                Hour = hora,
                Date = data,
                Number = numero,
                DeckIOneld = deck1,
                DeckITwold = deck2,
                Description = descricao,
                StandadTournamentId = torneio
            };
            container.GameSet.Add(jogo);
            container.SaveChanges();
            refresh_listview_Jogador1();
            refresh_listview_Jogador2();
            refresh_listview_Arbitro();
        }

        private void listVJogador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVJogador1.SelectedItems.Count > 0)
            {
                string jogador = listVJogador1.SelectedItems[0].Text;


                //jogadorSelecionado = container.PlayerSet.Where(play => play.Name.Equals(jogador)).First();
                jogadorSelecionado = container.PlayerSet.Where(pla => pla.Id.Equals(listVJogador1.SelectedItems.ToString())).First();


            }
            else
            {
                jogadorSelecionado = null;
            }
        }

        private void listVJogador2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVJogador2.SelectedItems.Count > 0)
            {
                string jogador = listVJogador2.SelectedItems[0].Text;


                jogadorSelecionado = container.PlayerSet.Where(play => play.Id.Equals(jogador)).First();

            }
            else
            {
                jogadorSelecionado = null;

            }
        }

        private void listVArbitro1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVArbitro1.SelectedItems.Count > 0)
            {
                string team = listVArbitro1.SelectedItems[0].Text;

                userSelect = container.UserSet.OfType<Referee>().Where(refe => refe.Id.Equals(listVArbitro1.SelectedItems.ToString())).First();

            }
            else
            {
                userSelect = null;
            }
        }

        public void refresh_listview_Jogador1()
        {
            listVJogador1.Items.Clear();



            foreach (Player pl1 in container.PlayerSet)
            {
                ListViewItem Jogador1List = new ListViewItem(Convert.ToString(pl1.Id));
                Jogador1List.SubItems.Add(pl1.Name);

                listVJogador1.Items.Add(Jogador1List);
            }

        }

        public void refresh_listview_Jogador2()
        {
            listVJogador2.Items.Clear();



            foreach (Player pl in container.PlayerSet)
            {

                ListViewItem Jogador2List = new ListViewItem(Convert.ToString(pl.Id));
                Jogador2List.SubItems.Add(pl.Name);

                listVJogador2.Items.Add(Jogador2List);
            }

        }

        public void refresh_listview_Arbitro()
        {
            listVArbitro1.Items.Clear();



            foreach (Referee refs in container.UserSet)
            {

                ListViewItem refereeList = new ListViewItem(Convert.ToString(refs.Id));
                refereeList.SubItems.Add(refs.Name);

                listVArbitro1.Items.Add(refereeList);
            }


        }
    }
}

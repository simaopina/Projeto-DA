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
    public partial class GestaoTorneioEquipas : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        Team teamSelecionado = null;
        User userSelect = null;

        public GestaoTorneioEquipas()
        {
            InitializeComponent();

            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralhoEquipa1.Items.Add(baralho.Name.ToString());
            }
            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralhoEquipa2.Items.Add(baralho.Name.ToString());
            }
            foreach (Tournament torn in container.TournamentSet.OfType<StandadTournament>())
            {
                cbxTorneio.Items.Add(torn.Name.ToString());
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

        private void btnPesquisarEquipa1_Click(object sender, EventArgs e)
        {
            if (tbxEquipa1.Text.Length > 0)
            {

                var query = container.TeamSet.Where(tea => tea.Name.Contains(tbxEquipa1.Text));

                //dataGridEquipa1.DataSource = query.ToList();
            }

            else
            {
                refresh_listview_Equipa1();
            }
        }

        private void btnPesquisarEquipa2_Click(object sender, EventArgs e)
        {
            if (tbxEquipa2.Text.Length > 0)
            {

                var query = container.TeamSet.Where(tea => tea.Name.Contains(tbxEquipa2.Text));

                //dataGridEquipa2.DataSource = query.ToList();
            }

            else
            {
                refresh_listview_Equipa2();
            }
        }

        public void validacao_pesquisar()
        {
            if (tbxEquipa1.Text == tbxEquipa2.Text)
            {
                MessageBox.Show("Não poderá procurar esse jogador");
                tbxEquipa1.Focus();
                refresh_listview_Equipa1();
            }
            else if (tbxEquipa2.Text == tbxEquipa1.Text)
            {
                MessageBox.Show("Não poderá procurar esse jogador");
                tbxEquipa2.Focus();
                refresh_listview_Equipa2();
            }
        }

        private void GestaoTorneioEquipas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet_Referee.UserSet_Referee' table. You can move, or remove it, as needed.
            this.userSet_RefereeTableAdapter.Fill(this.baseDadosDataSet_Referee.UserSet_Referee);
            // TODO: This line of code loads data into the 'baseDadosDataSetTeamSet.TeamSet' table. You can move, or remove it, as needed.
            this.teamSetTableAdapter.Fill(this.baseDadosDataSetTeamSet.TeamSet);

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(tbxNumero.Text);
            DateTime data = datetimeData.Value;
            DateTime hora = datetimeHora.Value;
            string descricao = tbxDescricao.Text;
            int TeamId = Convert.ToInt32(listVEquipa1.Items.ToString());
            int TeamId1 = Convert.ToInt32(listVEquipa1.Items.ToString());
            int Referee = Convert.ToInt32(listVArbitro.Items.ToString());
            int deck1 = Convert.ToInt32(cbxBaralhoEquipa1.Text);
            int deck2 = Convert.ToInt32(cbxBaralhoEquipa2.Text);
            int torneio = Convert.ToInt32(cbxTorneio.Text);

            TeamGame jogo = new TeamGame
            {
                TeamId = TeamId,
                TeamId1 = TeamId1,
                RefereeId = Referee,
                Hour = hora,
                Date = data,
                Number = numero,
                DeckIOneld = deck1,
                DeckITwold = deck2,
                Description = descricao,
                TeamTournamentId = torneio
            };
            container.GameSet.Add(jogo);
            container.SaveChanges();
            refresh_listview_Equipa1();
            refresh_listview_Equipa2();
            refresh_listview_Arbitro();


        }

        private void btnPesquisarArbitro_Click(object sender, EventArgs e)
        {
            if (tbxArbitro.Text.Length > 0)
            {

                var query = container.UserSet.OfType<Referee>().Where(arb => arb.Name.Contains(tbxArbitro.Text));

                //dataGridReferee.DataSource = query.ToList();
            }

            else
            {
                refresh_listview_Arbitro();
            }
        }

        private void listVEquipa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVEquipa1.SelectedItems.Count > 0)
            {
                string team = listVEquipa1.SelectedItems[0].Text;


                //jogadorSelecionado = container.PlayerSet.Where(play => play.Name.Equals(jogador)).First();
                teamSelecionado = container.TeamSet.Where(tea => tea.Id.Equals(listVEquipa1.SelectedItems.ToString())).First();

            }
            else
            {
                teamSelecionado = null;
            }
        }

        private void listVEquipa2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVEquipa2.SelectedItems.Count > 0)
            {
                string team = listVEquipa2.SelectedItems[0].Text;


                //jogadorSelecionado = container.PlayerSet.Where(play => play.Name.Equals(jogador)).First();
                teamSelecionado = container.TeamSet.Where(tea => tea.Id.Equals(listVEquipa2.SelectedItems.ToString())).First();

            }
            else
            {
                teamSelecionado = null;
            }
        }

        private void listVArbitro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVArbitro.SelectedItems.Count > 0)
            {
                string team = listVArbitro.SelectedItems[0].Text;

                
                userSelect = container.UserSet.OfType<Referee>().Where(refe => refe.Id.Equals(listVArbitro.SelectedItems.ToString())).First();

            }
            else
            {
                userSelect = null;
            }
        }

        public void refresh_listview_Equipa1()
        {
            listVEquipa1.Items.Clear();



            foreach (Player pl in container.PlayerSet)
            {
                listVEquipa1.Items.Add(pl.Id.ToString());
                listVEquipa1.Items.Add(pl.Name);
            }

        }

        public void refresh_listview_Equipa2()
        {
            listVEquipa2.Items.Clear();



            foreach (Player pl in container.PlayerSet)
            {
                listVEquipa2.Items.Add(pl.Id.ToString());
                listVEquipa2.Items.Add(pl.Name);
            }

        }

        public void refresh_listview_Arbitro()
        {
            listVArbitro.Items.Clear();



            foreach (Referee refs in container.UserSet)
            {
                listVArbitro.Items.Add(refs.Id.ToString());
                listVArbitro.Items.Add(refs.Name);
            }

        }
    }
}

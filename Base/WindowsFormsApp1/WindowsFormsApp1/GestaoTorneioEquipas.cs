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
        List<Player> Items = new List<Player>();
        List<Referee> Id = new List<Referee>();

        public GestaoTorneioEquipas()
        {
            InitializeComponent();

            foreach (Team team in container.TeamSet)
            {
                ListViewItem teamList = new ListViewItem(Convert.ToString(team.Name));

                listVEquipa1.Items.Add(teamList);

            }

            foreach (Team team in container.TeamSet)
            {
                ListViewItem teamList = new ListViewItem(Convert.ToString(team.Name));

                listVEquipa2.Items.Add(teamList);
            }

            foreach (Referee arbitro in container.UserSet.OfType<Referee>())
            {
                ListViewItem arbitroList = new ListViewItem(Convert.ToString(arbitro.Name));

                listVArbitro.Items.Add(arbitroList);
            }

            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralhoEquipa1.Items.Add(baralho.Id.ToString());
            }
            foreach (Deck baralho in container.DeckSet)
            {
                cbxBaralhoEquipa2.Items.Add(baralho.Id.ToString());
            }
            foreach (Tournament torn in container.TournamentSet.OfType<TeamTournament>())
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

        private void btnPesquisarEquipa1_Click(object sender, EventArgs e)
        {
            if (tbxEquipa1.Text.Length > 0)
            {

                ListViewItem[] dados1 = new ListViewItem[listVEquipa1.Items.Count];
                listVEquipa1.Items.CopyTo(dados1, 0);

                dados1 = dados1.Where(d => d.Text.Contains(tbxEquipa1.Text)).ToArray();

                listVEquipa1.Items.Clear();
                listVEquipa1.Items.AddRange(dados1);

                if (listVEquipa1.Items.Count < 1)
                {
                    MessageBox.Show("Não foi encontrado nenhum resultado");
                    refresh_listview_Equipa1();
                    tbxEquipa1.ResetText();
                    tbxEquipa1.Focus();
                }
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

                ListViewItem[] dados2 = new ListViewItem[listVEquipa2.Items.Count];
                listVEquipa2.Items.CopyTo(dados2, 0);

                dados2 = dados2.Where(d => d.Text.Contains(tbxEquipa2.Text)).ToArray();

                listVEquipa2.Items.Clear();
                listVEquipa2.Items.AddRange(dados2);

                if (listVEquipa2.Items.Count < 1)
                {
                    MessageBox.Show("Não foi encontrado nenhum resultado");
                    refresh_listview_Equipa2();
                    tbxEquipa2.ResetText();
                    tbxEquipa2.Focus();
                }
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
                MessageBox.Show("Não poderá procurar essa Equipa");
                tbxEquipa1.Focus();
                refresh_listview_Equipa1();
            }
            else if (tbxEquipa2.Text == tbxEquipa1.Text)
            {
                MessageBox.Show("Não poderá procurar essa Equipa");
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
            int TeamId = Convert.ToInt32(numericEquipa1.Value);
            int TeamId1 = Convert.ToInt32(numericEquipa2.Value);
            int Referee = Convert.ToInt32(numericArbitro.Value);
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
            limparCampos();

            MessageBox.Show("Inserido Com Sucesso!");

        }

        public void limparCampos()
        {
            numericEquipa1.ResetText();
            numericEquipa2.ResetText();
            numericArbitro.ResetText();
            cbxBaralhoEquipa1.ResetText();
            cbxBaralhoEquipa2.ResetText();
            cbxTorneio.ResetText();
        }

        private void btnPesquisarArbitro_Click(object sender, EventArgs e)
        {
            if (tbxArbitro.Text.Length > 0)
            {

                ListViewItem[] dados3 = new ListViewItem[listVArbitro.Items.Count];
                listVArbitro.Items.CopyTo(dados3, 0);

                dados3 = dados3.Where(d => d.Text.Contains(tbxArbitro.Text)).ToArray();

                listVArbitro.Items.Clear();
                listVArbitro.Items.AddRange(dados3);

                if (listVArbitro.Items.Count < 1)
                {
                    MessageBox.Show("Não foi encontrado nenhum resultado");
                    refresh_listview_Arbitro();
                    tbxArbitro.ResetText();
                    tbxArbitro.Focus();
                }
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

                teamSelecionado = container.TeamSet.Where(tea => tea.Name.Equals(team)).First();

                List<Team> equipa = container.TeamSet.ToList();

                numericEquipa1.Value = teamSelecionado.Id;

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

                teamSelecionado = container.TeamSet.Where(tea => tea.Name.Equals(team)).First();

                List<Team> equipa = container.TeamSet.ToList();

                numericEquipa2.Value = teamSelecionado.Id;
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
                string arb = listVArbitro.SelectedItems[0].Text;

                
                userSelect = container.UserSet.OfType<Referee>().Where(refe => refe.Name.Equals(arb)).First();

                List<Referee> refey = container.UserSet.OfType<Referee>().ToList();

                numericArbitro.Value = userSelect.Id;

            }
            else
            {
                userSelect = null;
            }
        }

        public void refresh_listview_Equipa1()
        {
            listVEquipa1.Items.Clear();



            foreach (Team pl in container.TeamSet)
            {
                ListViewItem Equipa1List = new ListViewItem(Convert.ToString(pl.Name));

                listVEquipa1.Items.Add(Equipa1List);
            }

        }

        public void refresh_listview_Equipa2()
        {
            listVEquipa2.Items.Clear();



            foreach (Team pl1 in container.TeamSet)
            {
                ListViewItem Equipa2List = new ListViewItem(Convert.ToString(pl1.Name));

                listVEquipa2.Items.Add(Equipa2List);
            }

        }

        public void refresh_listview_Arbitro()
        {
            listVArbitro.Items.Clear();



            foreach (Referee refs in container.UserSet.OfType<Referee>())
            {
                ListViewItem refereeList = new ListViewItem(Convert.ToString(refs.Name));

                listVArbitro.Items.Add(refereeList);
            }

        }
    }
}

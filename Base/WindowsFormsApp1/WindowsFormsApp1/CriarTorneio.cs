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
    public partial class CriarTorneio : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        //Declaração de Variaveis
        TeamTournament TTorneioSelected = null;

        StandadTournament SSTorneioSelected = null;

        //Inicialização do Form
        public CriarTorneio()
        {
            InitializeComponent();

            List<TeamTournament> listteamtorneio = container.TournamentSet.OfType<TeamTournament>().ToList();

            foreach (Tournament TeamT in listteamtorneio)
            {
                listVEquipas.Items.Add(TeamT.Name);
            }

            List<StandadTournament> liststandardtorneio = container.TournamentSet.OfType<StandadTournament>().ToList();

            foreach (Tournament StandT in liststandardtorneio)
            {
                listVStandard.Items.Add(StandT.Name);
            }
        }

        //Funções
        public void refresh_listViewStandard()
        {
            listVStandard.Items.Clear();
            List<StandadTournament> STorneio = container.TournamentSet.OfType<StandadTournament>().ToList();

            foreach (StandadTournament Storneio in STorneio)
            {
                ListViewItem item = new ListViewItem(Storneio.Name);
                listVStandard.Items.Add(item);
            }
        }

        public void refresh_listViewEquipas()
        {
            listVEquipas.Items.Clear();

            List<TeamTournament> TTorneio = container.TournamentSet.OfType<TeamTournament>().ToList();

            foreach (TeamTournament Ttorneio in TTorneio)
            {
                ListViewItem item = new ListViewItem(Ttorneio.Name);
                listVEquipas.Items.Add(item);
            }

        }

        //Eventos
        private void listVStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVStandard.SelectedItems != null)
            {           
                string STorneioU = listVStandard.SelectedItems[0].Text;
                SSTorneioSelected = container.TournamentSet.OfType<StandadTournament>().Where(user => user.Name.Equals(STorneioU)).First();

                List<Tournament> tournament = container.TournamentSet.ToList();
                    
                tbxNomeStandard.Text = SSTorneioSelected.Name;
                tbxDescricaoStandard.Text = SSTorneioSelected.Description;
                dateTimeDataStandard.Value = SSTorneioSelected.Date;

                refresh_listViewStandard();
            }
        }

        private void listVEquipas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVEquipas.SelectedItems != null)
            {     
                string TTorneioU = listVEquipas.SelectedItems[0].Text;
                TTorneioSelected = container.TournamentSet.OfType<TeamTournament>().Where(user => user.Name.Equals(TTorneioU)).First();

                List<Tournament> tournament = container.TournamentSet.ToList();

                tbxNomeEquipas.Text = TTorneioSelected.Name;
                tbxDescricao.Text = TTorneioSelected.Description;
                dateTEquipas.Value = TTorneioSelected.Date;

                refresh_listViewEquipas();
            }
        }


        //Botões
        //Invidivual
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNomeStandard.ResetText();
            dateTimeDataStandard.Value = DateTime.Now;
            tbxDescricaoStandard.ResetText();
        }
        
        private void btxPesquisarStand_Click(object sender, EventArgs e)
        {
            if (tbxPesquisarStand.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVStandard.Items.Count];
                listVStandard.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxPesquisarStand.Text)).ToArray();

                listVStandard.Items.Clear();
                listVStandard.Items.AddRange(dados);

                if (listVStandard.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refresh_listViewStandard();
                    tbxPesquisarStand.ResetText();
                    tbxPesquisarStand.Focus();
                }
            }
            else
            {
                refresh_listViewStandard();
            }
        }

        private void btnCancelarStand_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
            Close();
        }

        private void btnEliminarStandard_Click(object sender, EventArgs e)
        {
            string Name = SSTorneioSelected.Name;

            var query = container.TournamentSet.Where(torn => torn.Name.Equals(SSTorneioSelected.Name));

            container.TournamentSet.Remove(SSTorneioSelected);

            container.SaveChanges();

            SSTorneioSelected = null;

            MessageBox.Show("Torneio elimindado com sucesso!");

            refresh_listViewStandard();

            tbxNomeStandard.ResetText();
            tbxDescricaoStandard.ResetText();
            dateTimeDataStandard.Value = DateTime.Now;

        }

        private void btnAlterarStandard_Click(object sender, EventArgs e)
        {
            string Nome = tbxNomeStandard.Text;
            string Descricao = tbxDescricaoStandard.Text;
            DateTime data = dateTimeDataStandard.Value;

            List<StandadTournament> StandTorneio = container.TournamentSet.OfType<StandadTournament>().ToList();

            if (SSTorneioSelected != null)
            {
                SSTorneioSelected.Name = Nome;
                SSTorneioSelected.Description = Descricao;
                SSTorneioSelected.Date = data;

                container.SaveChanges();

                MessageBox.Show("Alterado com Sucesso!");

                refresh_listViewStandard();

                tbxNomeStandard.ResetText();
                tbxDescricaoStandard.ResetText();
                dateTimeDataStandard.Value = DateTime.Now;

            }
        }

        private void btnGuardarStandard_Click(object sender, EventArgs e)
        {
            string Nome = tbxNomeStandard.Text;
            string Descricao = tbxDescricaoStandard.Text;
            DateTime Data = dateTimeDataStandard.Value;

            StandadTournament tournament = new StandadTournament()
            {
                Name = Nome,
                Description = Descricao,
                Date = Data

            };
            container.TournamentSet.Add(tournament);
            container.SaveChanges();
            refresh_listViewStandard();
            MessageBox.Show("Torneio Inserido com sucesso");

            tbxNomeStandard.ResetText();
            tbxDescricaoStandard.ResetText();
            dateTimeDataStandard.Value = DateTime.Now;

        }


        //Team
        private void btnLimparTeams_Click(object sender, EventArgs e)
        {
            tbxNomeEquipas.ResetText();
            dateTEquipas.Value = DateTime.Now;
            tbxDescricao.ResetText();
        }

        private void btxPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxPesquisarTeam.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVEquipas.Items.Count];
                listVEquipas.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxPesquisarTeam.Text)).ToArray();

                listVEquipas.Items.Clear();
                listVEquipas.Items.AddRange(dados);

                if (listVEquipas.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refresh_listViewEquipas();
                    tbxPesquisarTeam.ResetText();
                    tbxPesquisarTeam.Focus();
                }
            }
            else
            {
                refresh_listViewEquipas();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
            Close();
        }

        private void btnEliminarEquipas_Click(object sender, EventArgs e)
        {
            string Name = TTorneioSelected.Name;

            var query = container.TournamentSet.Where(torn => torn.Name.Equals(TTorneioSelected.Name));

            container.TournamentSet.Remove(TTorneioSelected);

            container.SaveChanges();

            TTorneioSelected = null;

            MessageBox.Show("Torneio eliminado com sucesso!");

            refresh_listViewEquipas();

            tbxNomeEquipas.ResetText();
            tbxDescricao.ResetText();
            dateTEquipas.Value = DateTime.Now;
        }

        private void btnAlterarEquipas_Click(object sender, EventArgs e)
        {
            string Nome = tbxNomeEquipas.Text;
            string Descricao = tbxDescricao.Text;
            DateTime data = dateTEquipas.Value;

            List<TeamTournament> TeamTorneio = container.TournamentSet.OfType<TeamTournament>().ToList();

            if (TTorneioSelected != null)
            {
                TTorneioSelected.Name = Nome;
                TTorneioSelected.Description = Descricao;
                TTorneioSelected.Date = data;

                container.SaveChanges();

                MessageBox.Show("Alterado com sucesso!");

                refresh_listViewEquipas();

                tbxNomeEquipas.ResetText();
                tbxDescricao.ResetText();
                dateTEquipas.Value = DateTime.Now;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nome = tbxNomeEquipas.Text;
            string Descricao = tbxDescricao.Text;
            DateTime Data = dateTEquipas.Value;

            TeamTournament tournament = new TeamTournament()
            {
                Name = Nome,
                Description = Descricao,
                Date = Data

            };

            container.TournamentSet.Add(tournament);
            container.SaveChanges();
            refresh_listViewEquipas();
            MessageBox.Show("Torneio Inserido com sucesso");

            tbxNomeEquipas.ResetText();
            tbxDescricao.ResetText();
            dateTEquipas.Value = DateTime.Now;
        }


        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM Hfrm = new Home_ADM();
            Hfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BAdmfrm = new Baralho_ADM();
            BAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBAfrm = new Edicao_Baralhos_ADM();
            EBAfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM CAMfrm = new Cartas_ADM();
            CAMfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM ADDJogfrm = new ADD_Jogador_ADM();
            ADDJogfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa InsEqfrm = new InserirEquipa();
            InsEqfrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Utilizadores_ADM Utilfrm = new Utilizadores_ADM();
            Utilfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
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

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

        TeamTournament TTorneioSelected = null;

        StandadTournament SSTorneioSelected = null;

        public CriarTorneio()
        {
            InitializeComponent();

            List<TeamTournament> listteamtorneio = container.TournamentSet.OfType<TeamTournament>().ToList();

            foreach (TeamTournament TeamT in listteamtorneio)
            {
                listVEquipas.Items.Add(TeamT.Name);
            }

            List<StandadTournament> liststandardtorneio = container.TournamentSet.OfType<StandadTournament>().ToList();

            foreach (StandadTournament StandT in liststandardtorneio)
            {
                listVStandard.Items.Add(StandT.Name);
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
            MessageBox.Show("Torneio Inserido com sucesso");
            refresh_listViewStandard();

        }

        public void refresh_listViewStandard()
        {
            listVEquipas.Items.Clear();
            List<StandadTournament> STorneio = container.TournamentSet.OfType<StandadTournament>().ToList();

            foreach (StandadTournament Storneio in STorneio)
            {
                ListViewItem item = new ListViewItem(Storneio.Name);
                listVStandard.Items.Add(item);
            }
        }
        public void refresh_listViewEquipas()
        {
            listVStandard.Items.Clear();

            List<TeamTournament> TTorneio = container.TournamentSet.OfType<TeamTournament>().ToList();

            foreach (TeamTournament Ttorneio in TTorneio)
            {
                ListViewItem item = new ListViewItem(Ttorneio.Name);
                listVEquipas.Items.Add(item);
            }

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
            }
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
            }
        }

        private void listVStandard_SelectedIndexChanged(object sender, EventArgs e)
        {
            string STorneioU = listVStandard.SelectedItems[0].Text;
            SSTorneioSelected = container.TournamentSet.OfType<StandadTournament>().Where(user => user.Name.Equals(STorneioU)).First();

            List<Tournament> tournament = container.TournamentSet.ToList();

            tbxNomeStandard.Text = SSTorneioSelected.Name;
            tbxDescricaoStandard.Text = SSTorneioSelected.Description;
            dateTimeDataStandard.Value = SSTorneioSelected.Date;

            refresh_listViewStandard();
        }

        private void listVEquipas_SelectedIndexChanged(object sender, EventArgs e)
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
}

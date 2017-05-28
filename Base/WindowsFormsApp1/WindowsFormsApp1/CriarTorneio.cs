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

            List<TeamTournament> TTorneio = container.TournamentSet.OfType<TeamTournament>().ToList();

            

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
        public void refresh_listViewTorneio()
        {

        }
    }
}

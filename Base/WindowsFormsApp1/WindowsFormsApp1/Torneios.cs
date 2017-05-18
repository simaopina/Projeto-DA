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
    public partial class Torneios : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public Torneios()
        {
            InitializeComponent();
        }

        private void Torneios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet1.TournamentSet_StandadTournament' table. You can move, or remove it, as needed.
            //this.tournamentSet_StandadTournamentTableAdapter.Fill(this.baseDadosDataSet1.TournamentSet_StandadTournament);

            var query = from torneios in container.TournamentSet.OfType<StandadTournament>() select torneios;
            dataGridTorneiosSt.DataSource = query.ToList();
        }
        
        //navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void permissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Pfrm = new Permissoes_ADM();
            Pfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BADMfrm = new Baralho_ADM();
            BADMfrm.Show();
            Close();
        }

        private void edToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBarfrm = new Edicao_Baralhos_ADM();
            EBarfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM CADMfrm = new Cartas_ADM();
            CADMfrm.Show();
            Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJfrm = new ADD_Jogador_ADM();
            AddJfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            DateTime data = dateTimeTorneio.Value;
            string descricao = txtDescricao.Text;

            Tournament torneio = new Tournament
            {
                Name = nome,
                Date = data,
                Description = descricao
            }
        }

    }
}

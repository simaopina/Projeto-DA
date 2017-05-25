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
    public partial class ATorneioJogosStandard : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        int id_torneio = 0;

        public ATorneioJogosStandard()
        {
            InitializeComponent();

            foreach (StardadGame game in container.GameSet)
            {
                cbxTorneioEquipa.Items.Add(game.Date);
            }

            foreach (Tournament torneio in container.TournamentSet.OfType<TeamTournament>)
            {
                listVJogosEquipa.Items.Add(torneio.Name);
            }

            foreach (TeamGame Tgame in container.GameSet)
            {
                cbxTorneioStandard.Items.Add(Tgame.Date);
            }

            foreach (Tournament torneio in container.TournamentSet)
            {
                listVJogosEquipa.Items.Add(torneio.Name);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cbxBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listVCartas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAfrm = new Home_ADM();
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BAdmfrm = new Baralho_ADM();
            BAdmfrm.Show();
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
            Cartas_ADM CAdmfrm = new Cartas_ADM();
            CAdmfrm.Show();
            Close();
        }

        private void jogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJogfrm = new ADD_Jogador_ADM();
            AddJogfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa InEpfrm = new InserirEquipa();
            InEpfrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM UtAdmfrm = new Utilizadores_ADM();
            UtAdmfrm.Show();
            Close();
        }

        private void torneioIndiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void jogoIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GesJogafrm = new GestaoTorneioJogadores();
            GesJogafrm.Show();
            Close();
        }

        private void jogoTorneiioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GesEquipafrm = new GestaoTorneioEquipas();
            GesEquipafrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }
    }
}

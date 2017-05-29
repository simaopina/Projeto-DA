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
    public partial class Home_ADM : Form
    {

        public Home_ADM()
        {
            InitializeComponent();

        }

        //Menu
        private void btnEditCartas_Click(object sender, EventArgs e)
        {
            Cartas_ADM Cadmefrm = new Cartas_ADM();
            Cadmefrm.Show();
            Close();
        }

        private void btnCartas_Click(object sender, EventArgs e)
        {
            Cartas_ADM CAfrm = new Cartas_ADM();
            CAfrm.Show();
            Close();
        }

        private void btnBaralhos_Click(object sender, EventArgs e)
        {
            Baralho_ADM Badfrm = new Baralho_ADM();
            Badfrm.Show();
            Close();
        }

        private void btnEditBaralhos_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EditBarfrm = new Edicao_Baralhos_ADM();
            EditBarfrm.Show();
            Close();
        }

        private void btnJogador_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addjfrm = new ADD_Jogador_ADM();
            addjfrm.Show();
            Close();
        }

        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarAdmfrm = new Baralho_ADM();
            BarAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EditBarAdmfrm = new Edicao_Baralhos_ADM();
            EditBarAdmfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM CarADMfrm = new Cartas_ADM();
            CarADMfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJofrm = new ADD_Jogador_ADM();
            AddJofrm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATorneioJogosStandard Sefrm = new ATorneioJogosStandard();
            Sefrm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM uti = new Utilizadores_ADM();
            uti.Show();
            Close();
            
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Baralho_ADM BarAdmfrm = new Baralho_ADM();
            BarAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EdBarAdmfrm = new Edicao_Baralhos_ADM();
            EdBarAdmfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cartas_ADM CartAdmsfrm = new Cartas_ADM();
            CartAdmsfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJogfrm = new ADD_Jogador_ADM();
            AddJogfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa InsEquifrm = new InserirEquipa();
            InsEquifrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Utilfrm = new Utilizadores_ADM();
            Utilfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio CriarTornfrm = new CriarTorneio();
            CriarTornfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GesTornJogfrm = new GestaoTorneioJogadores();
            GesTornJogfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GesTornEqufrm = new GestaoTorneioEquipas();
            GesTornEqufrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void btnGestaoDeJogosST_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GTJfrm = new GestaoTorneioJogadores();
            GTJfrm.Show();
            Close();
        }

        private void btnGestaoDeJogosTeam_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GTEfrm = new GestaoTorneioEquipas();
            GTEfrm.Show();
            Close();
        }

        private void btnGestaoTorneios_Click(object sender, EventArgs e)
        {
            CriarTorneio CTornfrm = new CriarTorneio();
            CTornfrm.Show();
            Close();
        }
    }
}

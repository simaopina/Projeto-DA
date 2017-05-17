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

        private void btnPermissoes_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Perfrm = new Permissoes_ADM();
            Perfrm.Show();
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Perfrm = new Permissoes_ADM();
            Perfrm.Show();
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
    }
}

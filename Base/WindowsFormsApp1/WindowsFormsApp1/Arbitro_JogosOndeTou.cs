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
    public partial class Arbitro_JogosOndeTou : Form
    {


        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public Arbitro_JogosOndeTou()
        {
            InitializeComponent();

            List<Game> game = container.GameSet.ToList();

            foreach (Game games in game)
            {
                listVJogos.Items.Add(games.Description);
            }
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JArbfrm = new JogoArbitro();
            JArbfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HArbfrm = new Home_Arbitro();
            HArbfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BarArbfrm = new Baralho_Arbitro();
            BarArbfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CarArbfrm = new Cartas_Arbitro();
            CarArbfrm.Show();
            Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbJgToufrm = new Arbitro_JogosOndeTou();
            ArbJgToufrm.Show();
            Close();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro();
            Histfrm.Show();
            Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }
    }
}

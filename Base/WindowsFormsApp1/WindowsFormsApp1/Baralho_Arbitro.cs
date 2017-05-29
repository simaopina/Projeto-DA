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
    public partial class Baralho_Arbitro : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public Baralho_Arbitro()
        {
            InitializeComponent();
        }

        private void btnBaralhoGaianArbitro_Click(object sender, EventArgs e)
        {
            listVbaralhoArbitro.LargeImageList = listaBaralhoArbitroGaianloveforlife;
            listVbaralhoArbitro.Items.Clear();

            foreach (Card carta in container.CardSet)
            {
                ListViewItem item = new ListViewItem(carta.Name);
                //item.ImageIndex = carta.Image;
                listVbaralhoArbitro.Items.Add(item);
            }
        }

        private void btnBaralhoUneasyADM_Click(object sender, EventArgs e)
        {
            listVbaralhoArbitro.LargeImageList = listaBaralhoArbitroUneasyAlliance;
            listVbaralhoArbitro.Items.Clear();

            foreach (Card carta in container.CardSet)
            {
                ListViewItem item = new ListViewItem(carta.Name);
               // item.ImageIndex = carta.Image;
                listVbaralhoArbitro.Items.Add(item);
            }
        }

        private void Baralho_Arbitro_Load(object sender, EventArgs e)
        {

        }
        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro Hadmfrm = new Home_Arbitro();
            Hadmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro Barbfrm = new Baralho_Arbitro();
            Barbfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro Cartfrm = new Cartas_Arbitro();
            Cartfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JogoArfrm = new JogoArbitro();
            JogoArfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOTfrm = new Arbitro_JogosOndeTou();
            ArbOTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro();
            Histfrm.Show();
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

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
                item.ImageIndex = carta.Image;
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
                item.ImageIndex = carta.Image;
                listVbaralhoArbitro.Items.Add(item);
            }
        }

        private void Baralho_Arbitro_Load(object sender, EventArgs e)
        {

        }
    }
}

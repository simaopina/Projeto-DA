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
        public Baralho_Arbitro()
        {
            InitializeComponent();
        }

        private void btnBaralhoGaianArbitro_Click(object sender, EventArgs e)
        {
            listVbaralhoArbitro.SmallImageList = listaBaralhoArbitroGaianloveforlife;
        }

        private void btnBaralhoUneasyADM_Click(object sender, EventArgs e)
        {
            listVbaralhoArbitro.SmallImageList = listaBaralhoArbitroUneasyAlliance;
        }
    }
}

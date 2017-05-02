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
    public partial class Baralho_ADM : Form
    {
        public Baralho_ADM()
        {
            InitializeComponent();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Baralho_ADM_Load(object sender, EventArgs e)
        {

        }

        private void btnBaralhoGaianAMD_Click(object sender, EventArgs e)
        {
            ListVBaralhoADM.SmallImageList = ListaBaralhoGaianloveforlife;
        }

        private void btnBaralhoUneasyADM_Click(object sender, EventArgs e)
        {
            ListVBaralhoADM.SmallImageList = ListaBaralhoUneasyAlliance;
        }
    }
}

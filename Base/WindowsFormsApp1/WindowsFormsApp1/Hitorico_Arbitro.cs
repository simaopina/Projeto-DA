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
    public partial class Hitorico_Arbitro : Form
    {
        public Hitorico_Arbitro()
        {
            InitializeComponent();
        }
        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HArfrm = new Home_Arbitro();
            HArfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro Barfrm = new Baralho_Arbitro();
            Barfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CarArbfrm = new Cartas_Arbitro();
            CarArbfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro ArbJogosfrm = new JogoArbitro();
            ArbJogosfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOndeToufrm = new Arbitro_JogosOndeTou();
            ArbOndeToufrm.Show();
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

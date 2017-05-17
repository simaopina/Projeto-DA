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
    public partial class Cartas_Arbitro : Form
    {
        public Cartas_Arbitro()
        {
            InitializeComponent();
        }
        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro();
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BAfrm = new Baralho_Arbitro();
            BAfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CAfrm = new Cartas_Arbitro();
            CAfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JArbfrm = new JogoArbitro();
            JArbfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou AOTfrm = new Arbitro_JogosOndeTou();
            AOTfrm.Show();
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

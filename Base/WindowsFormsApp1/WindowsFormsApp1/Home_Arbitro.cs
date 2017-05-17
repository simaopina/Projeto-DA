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
    public partial class Home_Arbitro : Form
    {
        public Home_Arbitro()
        {
            InitializeComponent();
        }
        //Navegação
        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BarAbarfrm = new Baralho_Arbitro();
            BarAbarfrm.Show();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CartAbarfrm = new Cartas_Arbitro();
            CartAbarfrm.Show();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro ArbJogosfrm = new JogoArbitro();
            ArbJogosfrm.Show();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOndeToufrm = new Arbitro_JogosOndeTou();
            ArbOndeToufrm.Show();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro();
            Histfrm.Show();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
        }
    }
}

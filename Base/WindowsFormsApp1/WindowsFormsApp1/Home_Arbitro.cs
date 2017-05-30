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

        public int id;

        public Home_Arbitro(int id_arb)
        {
            InitializeComponent();

            id= id_arb;
        }
        //Navegação
        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BarAbarfrm = new Baralho_Arbitro(id);
            BarAbarfrm.Show();
            Close();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CartAbarfrm = new Cartas_Arbitro(id);
            CartAbarfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro ArbJogosfrm = new JogoArbitro(id);
            ArbJogosfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOndeToufrm = new Arbitro_JogosOndeTou(id);
            ArbOndeToufrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro(id);
            Histfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HArbfrm = new Home_Arbitro(id);
            HArbfrm.Show();
            Close();
        }
    }
}

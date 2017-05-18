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
    public partial class Jogos : Form
    {
        public Jogos()
        {

            /*inserir/editar/eliminar*/
            InitializeComponent();
        }

        private void Jogos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosGameStardad.GameSet_StardadGame' table. You can move, or remove it, as needed.
            this.gameSet_StardadGameTableAdapter.Fill(this.baseDadosGameStardad.GameSet_StardadGame);

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hfrm = new Home();
            hfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BArbfrm = new Baralho_Arbitro();
            BArbfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CartArbfrm = new Cartas_Arbitro();
            CartArbfrm.Show();
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
            Arbitro_JogosOndeTou AJOTfrm = new Arbitro_JogosOndeTou();
            AJOTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro HArbfrm = new Hitorico_Arbitro();
            HArbfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hfrm = new Home();
            hfrm.Show();
            Close();
        }
    }
}

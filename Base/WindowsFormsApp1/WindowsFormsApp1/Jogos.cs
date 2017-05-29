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
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        Game JogoSelecionado;

        public Jogos()
        {
        
            InitializeComponent();

            List<Game> listgame = container.GameSet.ToList();

            foreach (Game game in listgame)
            {
                listVJogos.Items.Add(game.Id.ToString());
            }

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

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home_Arbitro HArbfrm = new Home_Arbitro();
            HArbfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BAfrm = new Baralho_Arbitro();
            BAfrm.Show();
            Close();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CArbfrm = new Cartas_Arbitro();
            CArbfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Jogos Jogfrm = new Jogos();
            Jogfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou AJONTfrm = new Arbitro_JogosOndeTou();
            AJONTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hitorico_Arbitro HArbfrm = new Hitorico_Arbitro();
            HArbfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void listVJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVJogos.SelectedItems != null)
            {
                string JogosU = listVJogos.SelectedItems[0].Text;
                JogoSelecionado = container.GameSet.Where(gam => gam.Id.Equals(JogosU)).First();

                List<Game> game = container.GameSet.ToList();
                refresh_ListView();
            }
        }

        public void refresh_ListView()
        {
            listVJogos.Items.Clear();

            List<Game> listgame = container.GameSet.ToList();

            foreach (Game game in listgame)
            {
                listVJogos.Items.Add(game.Id.ToString());

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Name = JogoSelecionado.Id.ToString();

            var query = container.GameSet.Where(torn => torn.Id.Equals(JogoSelecionado.Id));

            container.GameSet.Remove(JogoSelecionado);

            container.SaveChanges();

            JogoSelecionado = null;

            MessageBox.Show("Eliminado com sucesso!");

            refresh_ListView();
        }
    }
}

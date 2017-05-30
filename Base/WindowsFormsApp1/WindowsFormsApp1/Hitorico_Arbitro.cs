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
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        Game JogoSelecionado;

        public int id;

        public Hitorico_Arbitro(int id_arb)
        {
            InitializeComponent();

            id = id_arb;

          
            var query = from Game in container.GameSet where JogoSelecionado.Equals(id) select Game;


            if (query.Any())
            {

                List<Game> listgame = container.GameSet.ToList();

                foreach (Game game in listgame)
                {
                    listVHistorico.Items.Add(game.Description.ToString());
                }

            }


            

        }
        //Navegação
       

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home_Arbitro Hfrm = new Home_Arbitro(id);
            Hfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro Hfrm = new Home_Arbitro(id);
            Hfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BArbfrm = new Baralho_Arbitro(id);
            BArbfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CarArbfrm = new Cartas_Arbitro(id);
            CarArbfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro Jogfrm = new JogoArbitro(id);
            Jogfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou OndeTfrm = new Arbitro_JogosOndeTou(id);
            OndeTfrm.Show();
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
    }
}

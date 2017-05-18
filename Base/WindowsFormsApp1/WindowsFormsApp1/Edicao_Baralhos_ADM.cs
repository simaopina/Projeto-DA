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
   
    public partial class Edicao_Baralhos_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        int id_baralho = 0;

        public Edicao_Baralhos_ADM()
        {
            InitializeComponent();

            foreach(Deck baralho in container.DeckSet)
            {
                cbxBaralho.Items.Add(baralho.Name);
            }
            
        }
        //Navegação
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Permfrm = new Permissoes_ADM();
            Permfrm.Show();
            Close();
        }
      
        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarADMfrm = new Baralho_ADM();
            BarADMfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM Cfrm = new Cartas_ADM();
            Cfrm.Show();
            Close();
        }
   
        private void addJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addJofrm = new ADD_Jogador_ADM();
            addJofrm.Show();
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
            Home_ADM Hadmfrm = new Home_ADM();
            Hadmfrm.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void cbxBaralho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listVCartas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

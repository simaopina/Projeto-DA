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
    public partial class GestaoTorneioJogadores : Form
    {
        int id_jogador = 0;
        Player jogadorSelected = null;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public GestaoTorneioJogadores()
        {
            InitializeComponent();
        }

        private void refreshJogador()
        {
            listbxJogador1.Items.Clear();

            foreach (Player jogador in container.PlayerSet)
            {
                listbxJogador1.Items.Add(jogador.Name);
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAfrm = new Home_ADM();
            HAfrm.Show();
            Close();
        }

        private void listVjogador1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbxJogador1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbxJogador1.SelectedItem != null)
            {
               
          
                
            }
            else
            {
                jogadorSelected = null;
            }
        }
    }
}

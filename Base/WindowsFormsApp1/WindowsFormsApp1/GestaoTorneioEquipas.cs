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
    public partial class GestaoTorneioEquipas : Form
    {
        public GestaoTorneioEquipas()
        {
            InitializeComponent();
        }



        //Navegação

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM Hadmfrm = new Home_ADM();
            Hadmfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addJofrm = new ADD_Jogador_ADM();
            addJofrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM Cfrm = new Cartas_ADM();
            Cfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarADMfrm = new Baralho_ADM();
            BarADMfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM Ebfrm = new Edicao_Baralhos_ADM();
            Ebfrm.Show();
            Close();
        }

        private void equipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa Iefrm = new InserirEquipa();
            Iefrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Utifrm = new Utilizadores_ADM();
            Utifrm.Show();
            Close();
        }

        private void btnPesquisarEquipa1_Click(object sender, EventArgs e)
        {

        }
    }
}

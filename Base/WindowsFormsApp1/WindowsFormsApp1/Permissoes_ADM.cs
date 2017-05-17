﻿using System;
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
    public partial class Permissoes_ADM : Form
    {
        public Permissoes_ADM()
        {
            InitializeComponent();
        }

        //Navegação
        private void bralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_ADM Brlhfrm = new Baralho_ADM();

            Brlhfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Edicao_Baralhos_ADM EBrlhfrm = new Edicao_Baralhos_ADM ();

            EBrlhfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM Cfrm = new Cartas_ADM();

            Cfrm.Show();
            Close();
        }

        private void perToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil_Jogador_ADM PJofrm = new Perfil_Jogador_ADM();

            PJofrm.Show();
            Close();
        }

        private void adicionarJogadorToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Perfrm = new Permissoes_ADM();
            Perfrm.Show();
            Close();
        }
    }
}

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
    public partial class Arbitro_JogosOndeTou : Form
    {
        public int id;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public Arbitro_JogosOndeTou(int id_arb)
        {
            InitializeComponent();

            id = id_arb;

            List<Referee> admin = container.UserSet.OfType<Referee>().ToList();

            var verificar_id = from user in container.UserSet.OfType<Referee>() where user.Id == id select user;


            if (verificar_id.Any())
            {

               var verificar_id_jogo = from Game in container.GameSet where Game.RefereeId == id where DateTime.Compare(Game.Date, DateTime.Today) >= 0 select Game;

                if (verificar_id.Any())
                {
                    List<Game> listgame = verificar_id_jogo.ToList();

                    foreach (Game game in listgame)
                    {
                        listVJogos.Items.Add(game.Description.ToString());
                    }
                }

            }

        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JArbfrm = new JogoArbitro(id);
            JArbfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HArbfrm = new Home_Arbitro(id);
            HArbfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BarArbfrm = new Baralho_Arbitro(id);
            BarArbfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CarArbfrm = new Cartas_Arbitro(id);
            CarArbfrm.Show();
            Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbJgToufrm = new Arbitro_JogosOndeTou(id);
            ArbJgToufrm.Show();
            Close();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro(id);
            Histfrm.Show();
            Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }
    }
}

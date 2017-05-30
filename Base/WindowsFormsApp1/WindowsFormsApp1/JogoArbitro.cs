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
    public partial class JogoArbitro : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public JogoArbitro()
        {
            InitializeComponent();

            listVJogo.Items.Clear();

            List<Game> listgame = container.GameSet.ToList();

            foreach (Game game in listgame)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());           


                listVJogo.Items.Add(item);
            }                       
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVJogo.Items.Count];
                listVJogo.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxpesquisa.Text)).ToArray();

                listVJogo.Items.Clear();
                listVJogo.Items.AddRange(dados);

                if(listVJogo.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refresh_listview();
                    tbxpesquisa.ResetText();
                    tbxpesquisa.Focus();
                }
            }
        }

        public void refresh_listview()
        {
            listVJogo.Items.Clear();

            List<Game> listgame = container.GameSet.ToList();

            foreach (Game game in listgame)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());


                listVJogo.Items.Add(item);

                
            }
        }

        private void rbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            refresh_listview();
        }

        private void rbtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            List<StardadGame> listgame = container.GameSet.OfType<StardadGame>().ToList();

            foreach (StardadGame game in listgame)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());


                listVJogo.Items.Add(item);
                refresh_listview();
            }
        }

        private void rbtnTeam_CheckedChanged(object sender, EventArgs e)
        {
            List<TeamGame> listgame = container.GameSet.OfType<TeamGame>().ToList();

            foreach (TeamGame game in listgame)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());

                listVJogo.Items.Add(item);
                refresh_listview();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro();
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BArfrm = new Baralho_Arbitro();
            BArfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CarArbfrm = new Cartas_Arbitro();
            CarArbfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JogArbfrm = new JogoArbitro();
            JogArbfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOTfrm = new Arbitro_JogosOndeTou();
            ArbOTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro();
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

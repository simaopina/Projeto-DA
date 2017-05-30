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
        //Declaração de variaveis
        public int id;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public JogoArbitro(int id_arb)
        {
            InitializeComponent();

            id = id_arb;

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

        //Butões
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
            else
            {
                refresh_listview();
            }
        }
       
        //Radio Buttons
        private void rbtnTodos_CheckedChanged(object sender, EventArgs e)
        {
            refresh_listview();
        }

        private void rbtnStandard_CheckedChanged(object sender, EventArgs e)
        {
            listVJogo.Items.Clear();
            List<StardadGame> STlistgame = container.GameSet.OfType<StardadGame>().ToList();

            foreach (StardadGame game in STlistgame)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());


                listVJogo.Items.Add(item);
             
            }
        }

        private void rbtnTeam_CheckedChanged(object sender, EventArgs e)
        {
            listVJogo.Items.Clear();
            List<TeamGame> TMlistgame = container.GameSet.OfType<TeamGame>().ToList();

            foreach (TeamGame game in TMlistgame)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());

                listVJogo.Items.Add(item);
             
            }
        }

        //Funções
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

        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro(id);
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BArfrm = new Baralho_Arbitro(id);
            BArfrm.Show();
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
            JogoArbitro JogArbfrm = new JogoArbitro(id);
            JogArbfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou ArbOTfrm = new Arbitro_JogosOndeTou(id);
            ArbOTfrm.Show();
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

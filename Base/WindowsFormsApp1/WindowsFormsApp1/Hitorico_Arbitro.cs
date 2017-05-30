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

            List<Referee> admin = container.UserSet.OfType<Referee>().ToList();

            var verificar_id = from user in container.UserSet.OfType<Referee>() where user.Id == id select user;


            if (verificar_id.Any())
            {

                var verificar_id_jogo = from Game in container.GameSet where Game.RefereeId == id select Game;

                if (verificar_id.Any())
                {
                    List<Game> listgame = verificar_id_jogo.ToList();

                    foreach (Game game in listgame)
                    {
                        listVHistorico.Items.Add(game.Description.ToString());
                    }
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVHistorico.Items.Count];
                listVHistorico.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxpesquisa.Text)).ToArray();

                listVHistorico.Items.Clear();
                listVHistorico.Items.AddRange(dados);

                if (listVHistorico.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refresh_listVHistorico();
                    tbxpesquisa.ResetText();
                    tbxpesquisa.Focus();
                }
            }
            else
            {
                refresh_listVHistorico();
            }
        }

        public void refresh_listVHistorico()
        {
            listVHistorico.Items.Clear();
            foreach (Game game in container.GameSet)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());

                listVHistorico.Items.Add(item);
            }
            
        }
    }
}

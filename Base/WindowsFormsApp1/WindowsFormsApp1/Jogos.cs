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

        //Declaração de Variaveis
        Game JogoSelecionado;

        //Inicialização o form
        public Jogos()
        {
        
            InitializeComponent();

            List<Game> listgame = container.GameSet.ToList();

            foreach (Game game in listgame)
            {
                listVJogos.Items.Add(game.Description.ToString());
            }

        }

        private void Jogos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosGameStardad.GameSet_StardadGame' table. You can move, or remove it, as needed.
            this.gameSet_StardadGameTableAdapter.Fill(this.baseDadosGameStardad.GameSet_StardadGame);

        }

        //Eventos
        private void listVJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVJogos.SelectedItems != null)
            {
                string JogosU = listVJogos.SelectedItems[0].Text;
                JogoSelecionado = container.GameSet.Where(gam => gam.Description.Equals(JogosU)).First();

                List<Game> game = container.GameSet.ToList();
                refresh_ListView();
            }
        }

        //Funções 
        public void refresh_ListView()
        {
            listVJogos.Items.Clear();

            List<Game> listgame = container.GameSet.ToList();

            foreach (Game game in listgame)
            {
                listVJogos.Items.Add(game.Description);

            }
        }

        public void refresh_listView()
        {
            listVJogos.Items.Clear();

            foreach (Game game in container.GameSet)
            {
                ListViewItem item = new ListViewItem(game.Number.ToString());
                item.SubItems.Add(game.Description);
                item.SubItems.Add(game.Hour.ToShortTimeString());
                item.SubItems.Add(game.Date.ToShortDateString());

                listVJogos.Items.Add(item);
            }
        }


        //Botões
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Name = JogoSelecionado.Description.ToString();

            var query = container.GameSet.Where(torn => torn.Description.Equals(JogoSelecionado.Description));

            container.GameSet.Remove(JogoSelecionado);

            container.SaveChanges();

            JogoSelecionado = null;

            MessageBox.Show("Eliminado com sucesso!");

            refresh_ListView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxPesquisar.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVJogos.Items.Count];
                listVJogos.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxPesquisar.Text)).ToArray();

                listVJogos.Items.Clear();
                listVJogos.Items.AddRange(dados);

                if (listVJogos.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refresh_listView();
                    tbxPesquisar.ResetText();
                    tbxPesquisar.Focus();
                }
            }
            else
            {
                refresh_listView();
            }
        }

    
        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hfrm = new Home();
            hfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hfrm = new Home();
            hfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Jogos Jogfrm = new Jogos();
            Jogfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Home_ADM Hadmfrm = new Home_ADM();
            Hadmfrm.Show();
            Close();
        }

        private void permissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baralhoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Baralho_ADM Brlhfrm = new Baralho_ADM();

            Brlhfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBrlhfrm = new Edicao_Baralhos_ADM();

            EBrlhfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cartas_ADM Cfrm = new Cartas_ADM();

            Cfrm.Show();
            Close();
        }

        private void adicionarJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addJofrm = new ADD_Jogador_ADM();

            addJofrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Home Hfrm = new Home();

            Hfrm.Show();
            Close();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ADD_Jogador_ADM : Form
    {
        int id_jogador = 0;
        Player jogadorSelected = null;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public ADD_Jogador_ADM()
        {
            InitializeComponent();
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            AddJogador();

            refreshJogador();
        }


        private void ADD_Jogador_ADM_Load(object sender, EventArgs e)
        {
            refreshJogador();
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarJogador();
            refreshJogador();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void AddJogador()
        {
            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string nickname = tbxNickName.Text;
            int idade = Convert.ToInt32(numupdownIdade.Text);
            string imagem = picbxAvatar.Text;
            //ver isto.


            Player jogador = new Player
            {
                Name = nome,
                Email = email,
                Nickname = nickname,
                Age = idade,
                Avatar = imagem
            };

            container.PlayerSet.Add(jogador);
            container.SaveChanges();
        }

        private void refreshJogador()
        {
            lbxJogadores.Items.Clear();

            foreach (Player jogador in container.PlayerSet)
            {
                lbxJogadores.Items.Add(jogador.Name);
            }
        }

        private void AlterarJogador()
        {
            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string nickname = tbxNickName.Text;
            int idade = Convert.ToInt32(numupdownIdade.Text);
            string imagem = picbxAvatar.Text;

            //Player player;
            if (jogadorSelected != null)
            {
                //player = container.PlayerSet.Find(id_jogador);
                jogadorSelected.Name = nome;
                jogadorSelected.Email = email;
                jogadorSelected.Nickname = nickname;
                jogadorSelected.Age = idade;
                jogadorSelected.Avatar = imagem;

                container.Entry(jogadorSelected).State = System.Data.Entity.EntityState.Modified;
                container.SaveChanges();

                MessageBox.Show("Alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro!");
            }

        }

        private void Cancelar()
        {
            tbxNome.ResetText();
            tbxNickName.ResetText();
            tbxEmail.ResetText();
            tbxpesquisa.ResetText();
            numupdownIdade.ResetText();
            picbxAvatar.ResetText();

        }

        private void lbxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxJogadores.SelectedItem != null)
            {
                jogadorSelected = container.PlayerSet.Where(jog => jog.Name.Equals(lbxJogadores.SelectedItem.ToString())).First();
                //jogadorSelected = (Player)lbxJogadores.SelectedItem;
                tbxNome.Text = jogadorSelected.Name;
                tbxEmail.Text = jogadorSelected.Email;
                tbxNickName.Text = jogadorSelected.Nickname;
                numupdownIdade.Value = jogadorSelected.Age;
            }
            else
            {
                jogadorSelected = null;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (lbxJogadores.SelectedItem != null)
            {

                // verificar o remover //
                jogadorSelected = container.PlayerSet.Find(jogadorSelected);
            
                container.PlayerSet.Remove(jogadorSelected);

                container.SaveChanges();


                MessageBox.Show("Eliminado com sucesso!");

                refreshJogador();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
            
        }


        // Menu Strip
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM Homefrm = new Home_ADM();
            Homefrm.Show();
            Close();
        }


        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarFrm = new Baralho_ADM();
            BarFrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBfrm = new Edicao_Baralhos_ADM();
            EBfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cartas_ADM CardFrm = new Cartas_ADM();
            CardFrm.Show();
            Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJFrm = new ADD_Jogador_ADM();
            AddJFrm.Show();
            Close();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Homefrm = new Home();
            Homefrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores Gtjfrm = new GestaoTorneioJogadores();
            Gtjfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas Gtefrm = new GestaoTorneioEquipas();
            Gtefrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa Iefrm = new InserirEquipa();
            Iefrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Utifrm = new Utilizadores_ADM();
            Utifrm.Show();
            Close();
        }
    }
}

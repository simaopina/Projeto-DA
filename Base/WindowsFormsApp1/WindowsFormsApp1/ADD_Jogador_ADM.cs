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

        private void AddJogador()
        {
            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string nickname = tbxNickName.Text;
            int idade = Convert.ToInt32(numupdownIdade.Text);
            string imagem = "Sou bueda Fixe";


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
            string imagem = "Sou bueda Fixe";

            Player player;

            player = container.PlayerSet.Find(id_jogador);
            player.Name = nome;
            player.Email = email;
            player.Nickname = nickname;
            player.Age = idade;
            player.Avatar = imagem;

            container.Entry(player).State = System.Data.Entity.EntityState.Modified;
            container.SaveChanges();

            MessageBox.Show("Alterado com sucesso!");
        }

        private void lbxJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            jogadorSelected = (Player)lbxJogadores.SelectedItem;
            tbxNome.Text = jogadorSelected.Name;
            tbxEmail.Text = jogadorSelected.Email;
            tbxNickName.Text = jogadorSelected.Nickname;
            numupdownIdade.Value = jogadorSelected.Age;

        }

        // Menu Strip
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Homefrm = new Home();
            Homefrm.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Permfrm = new Permissoes_ADM();
            Permfrm.Show();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarFrm = new Baralho_ADM();
            BarFrm.Show();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBfrm = new Edicao_Baralhos_ADM();
            EBfrm.Show();
        }

        private void cartasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cartas_ADM CardFrm = new Cartas_ADM();
            CardFrm.Show();
        }

        //private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Perfil_Jogador_ADM PerfFrm = new Perfil_Jogador_ADM();
        //    PerfFrm.Show();
        //}

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJFrm = new ADD_Jogador_ADM();
            AddJFrm.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Homefrm = new Home();
            Homefrm.Show();
        }

        
    }
}

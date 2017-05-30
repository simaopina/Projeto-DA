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


        string ParteFinalNome;
    

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
            string imagem = ParteFinalNome;
           


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
            refreshJogador();
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
                picbxAvatar.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + jogadorSelected.Avatar);
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
                //jogadorSelected = container.PlayerSet.Find(jogadorSelected);

                string caminhoImagem = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + jogadorSelected.Avatar;

                File.Delete(caminhoImagem);

                container.PlayerSet.Remove(jogadorSelected);

               
                container.SaveChanges();

                jogadorSelected = null;

                MessageBox.Show("Eliminado com sucesso!");

                refreshJogador();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
            
        }

        //limpar campos
        //apagar 


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

        private void btnInserirAvatar_Click(object sender, EventArgs e)
        {
            
            if (caminhoImagem.ShowDialog() == DialogResult.OK)
            {

                string caminhoFicheiro = caminhoImagem.FileName;

                caminhoFicheiro.Contains(".jpg");
                caminhoFicheiro.Contains(".png");

                string[] partes = caminhoFicheiro.Split('\\');
                ParteFinalNome = partes.Last();

                File.Copy(caminhoFicheiro, Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + partes.Last());

                picbxAvatar.Image = Image.FromFile(caminhoFicheiro);

            }
        
    }

        private void picbxAvatar_Click(object sender, EventArgs e)
        {

        }

        private void caminhoImagem_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void baralhoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Baralho_ADM BAdmfmr = new Baralho_ADM();
            BAdmfmr.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home_ADM HAfrm = new Home_ADM();
            HAfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBAdmfrm = new Edicao_Baralhos_ADM();
            EBAdmfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Cartas_ADM CAdmfrm = new Cartas_ADM();
            CAdmfrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Utadmfrm = new Utilizadores_ADM();
            Utadmfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio CTornrfm = new CriarTorneio();
            CTornrfm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GesTornJogform = new GestaoTorneioJogadores();
            GesTornJogform.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GesTornEqfrm = new GestaoTorneioEquipas();
            GesTornEqfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InserirEquipa IEfrm = new InserirEquipa();
            IEfrm.Show();
            Close();
        }

        private void listaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogos Jfrm = new Jogos();
            Jfrm.Show();
            Close();
        }
    }
}

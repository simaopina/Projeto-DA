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
        //Declaração de Variaveis
        Player jogadorSelected = null;

        string ParteFinalNome;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        
        //Iniciar Form
        public ADD_Jogador_ADM()
        {
            InitializeComponent();
        }

        private void ADD_Jogador_ADM_Load(object sender, EventArgs e)
        {
            refreshJogador();
        }

        //Funções
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

        //Eventos
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

        //Butões
        private void btnInserir_Click(object sender, EventArgs e)
        {
            AddJogador();

            refreshJogador();

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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarJogador();
            refreshJogador();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {
                string[] dados = new string[lbxJogadores.Items.Count];
                lbxJogadores.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Contains(tbxpesquisa.Text)).ToArray();

                lbxJogadores.Items.Clear();
                lbxJogadores.Items.AddRange(dados);

                if (lbxJogadores.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refreshJogador();
                    tbxpesquisa.ResetText();
                    tbxpesquisa.Focus();
                }
            }
            else
            {
                refreshJogador();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNome.ResetText();
            tbxEmail.ResetText();
            tbxNickName.ResetText();
            numupdownIdade.Value = 0;
            picbxAvatar.Image = null;
        }

        // Navegação
        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJFrm = new ADD_Jogador_ADM();
            AddJFrm.Show();
            Close();
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

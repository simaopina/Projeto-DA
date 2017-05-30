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
    public partial class InserirEquipa : Form
    {
        //Declaração de variáveis
        Team equipaSelected = null;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        public string ParteFinalNome;

        //Iniciazação de Form
        public InserirEquipa()
        {
            InitializeComponent();

            foreach (Player jogador in container.PlayerSet)
            {
                cbxJogador1.Items.Add(jogador.Id.ToString());
                refreshEquipa();
            }
            foreach (Player jogador in container.PlayerSet)
            {
                cbxJogador2.Items.Add(jogador.Id.ToString());
                refreshEquipa();
            }
        }
        
        //Eventos
        private void lbxEquipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEquipa.SelectedItem != null)
            {
                equipaSelected = container.TeamSet.Where(equip => equip.Name.Equals(lbxEquipa.SelectedItem.ToString())).First();
                tbxNome.Text = equipaSelected.Name;
                cbxJogador1.Text = Convert.ToString(equipaSelected.Player1);
                cbxJogador2.Text = Convert.ToString(equipaSelected.Player2);
                picbxAvatar.ImageLocation = Application.StartupPath + "/imagens/" + equipaSelected.Avatar;
            }
            else
            {
                equipaSelected = null;
            }
        }
        
        //Botões
        private void btnInserir_Click(object sender, EventArgs e)
        {
            AddEquipa();
            refreshEquipa();
            LimparDados();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
            Close();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxPesquisar.Text.Length > 0)
            {
                string[] dados = new string[lbxEquipa.Items.Count];
                lbxEquipa.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Contains(tbxPesquisar.Text)).ToArray();

                lbxEquipa.Items.Clear();
                lbxEquipa.Items.AddRange(dados);

                if (lbxEquipa.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refreshEquipa();
                    tbxPesquisar.ResetText();
                    tbxPesquisar.Focus();
                }
            }
            else
            {
                refreshEquipa();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbxNome.ResetText();
            tbxPesquisar.ResetText();
            cbxJogador1.ResetText();
            cbxJogador2.ResetText();
        }

        private void btnAbrirImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {

                string caminhoFicheiro = openFileDialogImagem.FileName;

                caminhoFicheiro.Contains(".jpg");
                caminhoFicheiro.Contains(".png");

                string[] partes = caminhoFicheiro.Split('\\');
                ParteFinalNome = partes.Last();

                File.Copy(caminhoFicheiro, Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + partes.Last());
                
                picbxAvatar.Image = Image.FromFile(caminhoFicheiro);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            int jog1 =Convert.ToInt32(cbxJogador1.Text);
            int jog2 = Convert.ToInt32(cbxJogador2.Text);
            string imagem = picbxAvatar.Text;

            if (equipaSelected != null)
            {
                equipaSelected.Name = nome;
                equipaSelected.Player1 = jog1;
                equipaSelected.Player2 = jog2;
                equipaSelected.Avatar = imagem;

                container.Entry(equipaSelected).State = System.Data.Entity.EntityState.Modified;
                container.SaveChanges();

                MessageBox.Show("Alterado com sucesso");

                refreshEquipa();
                LimparDados();

            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbxEquipa.SelectedItem != null)
            {
                string caminhoImagem = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + equipaSelected.Avatar;

                File.Delete(caminhoImagem);

                container.TeamSet.Remove(equipaSelected);

                container.SaveChanges();

                equipaSelected = null;

                MessageBox.Show("Elimindado com sucesso");

                refreshEquipa();
                LimparDados();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
        }

        //Funções
        public void LimparDados()
        {
            tbxNome.ResetText();
            cbxJogador1.ResetText();
            cbxJogador2.ResetText();
            picbxAvatar.Image = null;
        }

        private void AddEquipa()
        {
            string nome = tbxNome.Text;
            string imagem = ParteFinalNome;
            int jogador1 = Convert.ToInt32(cbxJogador1.Text);
            int jogador2 = Convert.ToInt32(cbxJogador2.Text);


            Team equipa = new Team
            {
                Name = nome,
                Avatar = imagem,
                Player1 = jogador1,
                Player2 = jogador2
            };

            container.TeamSet.Add(equipa);
            container.SaveChanges();
            refreshEquipa();
        }

        private void refreshEquipa()
        {
            lbxEquipa.Items.Clear();

            foreach (Team equipa in container.TeamSet)
            {
                lbxEquipa.Items.Add(equipa.Name);
            }
        }

        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BarAdm = new Baralho_ADM();
            BarAdm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EdBarAdmfrm = new Edicao_Baralhos_ADM();
            EdBarAdmfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM CartAdmfrm = new Cartas_ADM();
            CartAdmfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AddJogfrm = new ADD_Jogador_ADM();
            AddJogfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa InsEquipafrm = new InserirEquipa();
            InsEquipafrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Utilfrm = new Utilizadores_ADM();
            Utilfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio CriarTornfrm = new CriarTorneio();
            CriarTornfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GTJfrm = new GestaoTorneioJogadores();
            GTJfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GTEfrm = new GestaoTorneioEquipas();
            GTEfrm.Show();
            Close();
        }

        private void listaDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogos Jfrm = new Jogos();
            Jfrm.Show();
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

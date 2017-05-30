using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cartas_ADM : Form
    {
        //Declaração de variaveis
        int id_carta = 0;

        string ParteFinalNome;

        Card cartaselecionada;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();


        public Cartas_ADM()
        {
            InitializeComponent();

          
            foreach (Card cartas in container.CardSet)
            {
                ListViewItem CartaList = new ListViewItem(cartas.Name);
                CartaList.SubItems.Add(cartas.Faction);
                CartaList.SubItems.Add(cartas.Type);
                CartaList.SubItems.Add(Convert.ToString(cartas.Loyalty));
                CartaList.SubItems.Add(Convert.ToString(cartas.Cost));
                CartaList.SubItems.Add(cartas.RuleText);
                CartaList.SubItems.Add(Convert.ToString(cartas.Attack));
                CartaList.SubItems.Add(Convert.ToString(cartas.Defense));
                if (cartas.Image == "SemImagem")
                {
                    CartaList.SubItems.Add(cartas.Name);
                }
                else
                {
                    CartaList.SubItems.Add(ParteFinalNome);
                }
                

                listVCartas.Items.Add(CartaList);
            }

        }

        //Eventos
        private void btAdicionarCartas_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string facao = txtFacao.Text;
            string tipo = txtTipo.Text;
            int lealdade = Convert.ToInt32(txtLealdade.Text);
            int custo = Convert.ToInt32(txtcusto.Text);
            string regras = txtRegras.Text;
            int ataque = Convert.ToInt32(numericAtaque.Text);
            int defesa = Convert.ToInt32(numericDefesa.Text);
            string imagem = ParteFinalNome;
           
            Card carta = new Card
            {
                Name = nome,
                Faction = facao,
                Type = tipo,
                Loyalty = lealdade,
                Cost = custo,
                RuleText = regras,
                Attack = ataque,
                Defense = defesa,
                Image = imagem
            };

          

            container.CardSet.Add(carta);
           
            container.SaveChanges();

            refreshlistVcartas();
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtFacao.ResetText();
            txtTipo.ResetText();
            txtLealdade.ResetText();
            txtcusto.ResetText();
            txtRegras.ResetText();
            numericAtaque.ResetText();
            numericDefesa.ResetText();
            pictImagem.Image = null;
        }

        private void Cartas_ADM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosCartas.CardSet' table. You can move, or remove it, as needed.
            this.cardSetTableAdapter3.Fill(this.baseDadosCartas.CardSet);
            // TODO: This line of code loads data into the 'baseDadosDataSet3.CardSet' table. You can move, or remove it, as needed.
          //  this.cardSetTableAdapter2.Fill(this.baseDadosDataSet3.CardSet);
            // TODO: This line of code loads data into the 'baseDadosDataSet_Cards.CardSet' table. You can move, or remove it, as needed.
        //    this.cardSetTableAdapter1.Fill(this.baseDadosDataSet_Cards.CardSet);
            // TODO: This line of code loads data into the 'baseDadosDataSet.CardSet' table. You can move, or remove it, as needed.
            /*this.cardSetTableAdapter.Fill(this.baseDadosDataSet.CardSet);*/

        }
      
        private void btAlterarCarta_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string facao = txtFacao.Text;
            string tipo = txtTipo.Text;
            int lealdade = Convert.ToInt32(txtLealdade.Text);
            int custo = Convert.ToInt32(txtLealdade.Text);
            string regras = txtRegras.Text;
            int ataque = Convert.ToInt32(numericAtaque.Text);
            int defesa = Convert.ToInt32(numericDefesa.Text);
            string imagem = ParteFinalNome;

            // objeto já criado
            Card carta;

            //vai procurar o id da carta 
            carta = container.CardSet.Find(id_carta);
            carta.Name = nome;
            carta.Faction = facao;
            carta.Type = tipo;
            carta.Loyalty = lealdade;
            carta.Cost = custo;
            carta.RuleText = regras;
            carta.Attack = ataque;
            carta.Defense = defesa;
            carta.Image = imagem;

            //facultativa
            container.Entry(carta).State = System.Data.Entity.EntityState.Modified;
            container.SaveChanges();

            MessageBox.Show("Alterado com sucesso!");

            refreshlistVcartas();

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
            Close();
        }

        private void listVCartas_DoubleClick(object sender, EventArgs e)
        {

            string nome = null;
            string facao = null;
            string tipo = null;
            string lealdade = null;
            string custo = null;
            string regras = null;
            string ataque = null;
            string defesa = null;
            string imagem = ParteFinalNome;

           
                      
                 nome = cartaselecionada.Name;
                 facao = cartaselecionada.Faction;
                 tipo = cartaselecionada.Type;
                 lealdade = cartaselecionada.Loyalty.ToString();
                 custo = cartaselecionada.Cost.ToString();
                 regras = cartaselecionada.RuleText;
                 ataque = cartaselecionada.Attack.ToString();
                 defesa = cartaselecionada.Defense.ToString();
                 imagem = cartaselecionada.Image;
            

            Info_Cartas_ADM Info_cartas_ADM = new Info_Cartas_ADM(nome, facao, tipo, lealdade, custo, regras, ataque, defesa, imagem);
            Info_cartas_ADM.Show();

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
         
           // if (listVCartas.SelectedItems != null)
           // {
                cartaselecionada = container.CardSet.Where(jog => jog.Name.Equals(listVCartas.SelectedItems.ToString())).First();

                string caminhoImagem = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + cartaselecionada.Image;

                File.Delete(caminhoImagem);

             //   var procurar = container.CardSet.Where(id => id.Id.Equals(id_carta));


                cartaselecionada = container.CardSet.Find(cartaselecionada);

                container.CardSet.Remove(cartaselecionada);
        

                container.SaveChanges();


                MessageBox.Show("Eliminado com sucesso!");

                refreshlistVcartas();
           // }
            

            

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {
                ListViewItem[] dados = new ListViewItem[listVCartas.Items.Count];
                listVCartas.Items.CopyTo(dados, 0);

                dados = dados.Where(d => d.Text.Contains(tbxpesquisa.Text)).ToArray();

                listVCartas.Items.Clear();
                listVCartas.Items.AddRange(dados);

                if (listVCartas.Items.Count < 1)
                {
                    MessageBox.Show("Nao foi encontrado nenhum resultado");
                    refreshlistVcartas();
                    tbxpesquisa.ResetText();
                    tbxpesquisa.Focus();
                }
            }
            else
            {
                refreshlistVcartas();
            }
        }

        private void LinkLabelImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (caminhoImagem.ShowDialog() == DialogResult.OK)
            {

                string caminhoFicheiro = caminhoImagem.FileName;

                caminhoFicheiro.Contains(".jpg");
                caminhoFicheiro.Contains(".png");

                string[] partes = caminhoFicheiro.Split('\\');
                ParteFinalNome = partes.Last();

                string destino = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + partes.Last();

                if (File.Exists(destino))
                {
                    MessageBox.Show("Essa imagem já existe!");
                }

                else
                {
                    File.Copy(caminhoFicheiro, destino);


                    pictImagem.Image = Image.FromFile(caminhoFicheiro);

                }
            }
        }

        private void listVCartas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVCartas.SelectedItems.Count > 0)
            {
                string cartasU = listVCartas.SelectedItems[0].Text;


                cartaselecionada = container.CardSet.Where(cart => cart.Name.Equals(cartasU)).First();

                //cartaselecionada = container.CardSet.Find(cartaselecionada);

                CarregaDadosCartas();

                listVCartas.Refresh();

            }
            else
            {
                cartaselecionada = null;
            }

        }      
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialogImportar.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogImportar.FileName;

                string linha = "";             
                int nCartasImportadas = 0;

                using (StreamReader ficheiro = new StreamReader(path))
                {
                
                    Card carta;
                 

                    linha = ficheiro.ReadLine();

                    
                    while (ficheiro.EndOfStream == false)
                    {
                        carta = new Card();

                        ficheiro.ReadLine();

                        carta.Name = ficheiro.ReadLine();

                        carta.Faction = ficheiro.ReadLine();

                        carta.Type = ficheiro.ReadLine();

                        carta.Cost = Convert.ToInt32(ficheiro.ReadLine());

                        carta.Loyalty = Convert.ToInt32(ficheiro.ReadLine());

                        carta.RuleText = ficheiro.ReadLine();

                        carta.Attack = Convert.ToInt32(ficheiro.ReadLine());

                        carta.Defense = Convert.ToInt32(ficheiro.ReadLine());

                        carta.Image = "SemImagem";

                        container.CardSet.Add(carta);
                        nCartasImportadas++;
                    }
                }

               // container.SaveChanges();

               MessageBox.Show("Importadas " + nCartasImportadas);

                refreshlistVcartas();
            }
        }

        //Funções
        public void CarregaDadosCartas()
        {        

            txtNome.Text = cartaselecionada.Name;
            txtFacao.Text = cartaselecionada.Faction;
            txtTipo.Text = cartaselecionada.Type;
            txtLealdade.Text = (Convert.ToString(cartaselecionada.Loyalty));
            numericAtaque.Text = (Convert.ToString(cartaselecionada.Attack));
            txtcusto.Text = (Convert.ToString(cartaselecionada.Cost));
            txtRegras.Text = cartaselecionada.RuleText;
            numericDefesa.Text = (Convert.ToString(cartaselecionada.Defense));
            LinkLabelImagem.Text = cartaselecionada.Image;

        }
    
        public void refreshlistVcartas()
        {
            listVCartas.Items.Clear();
            foreach (Card cartas in container.CardSet)
            {
                ListViewItem CartaList = new ListViewItem(cartas.Name);
                CartaList.SubItems.Add(cartas.Faction);
                CartaList.SubItems.Add(cartas.Type);
                CartaList.SubItems.Add(Convert.ToString(cartas.Loyalty));
                CartaList.SubItems.Add(Convert.ToString(cartas.Cost));
                CartaList.SubItems.Add(cartas.RuleText);
                CartaList.SubItems.Add(Convert.ToString(cartas.Attack));
                CartaList.SubItems.Add(Convert.ToString(cartas.Defense));
                CartaList.SubItems.Add(ParteFinalNome);

                listVCartas.Items.Add(CartaList);
            }

        }

        //Navegação
        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa Iefrm = new InserirEquipa();
            Iefrm.Show();
            Close();
        }

        private void utilizadoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Uadmfrm = new Utilizadores_ADM();
            Uadmfrm.Show();
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

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BaAdmfrm = new Baralho_ADM();
            BaAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EdBaAdmfrm = new Edicao_Baralhos_ADM();
            EdBaAdmfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM adjfrm = new ADD_Jogador_ADM();
            adjfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InserirEquipa EquFrm = new InserirEquipa();
            EquFrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM utifrm = new Utilizadores_ADM();
            utifrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio tornfrm = new CriarTorneio();
            tornfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioJogadores Gtjfrm = new GestaoTorneioJogadores();
            Gtjfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GestaoTorneioEquipas Gtefrm = new GestaoTorneioEquipas();
            Gtefrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home hfrm = new Home();
            hfrm.Show();
            Close();
        }

        private void listadeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jogos Jfrm = new Jogos();
            Jfrm.Show();
            Close();
        }

    }
}

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
        /// <summary>
        /// Variavel gobal
        /// </summary>
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (DataGridCartas.CurrentRow != null)
            {
                cartaselecionada = container.CardSet.Where(car => car.Id.Equals(DataGridCartas.CurrentRow.ToString())).First();

                txtNome.Text = DataGridCartas.CurrentRow.Cells[1].Value.ToString();
                txtFacao.Text = DataGridCartas.CurrentRow.Cells[2].Value.ToString();
                txtTipo.Text = DataGridCartas.CurrentRow.Cells[3].Value.ToString();
                txtLealdade.Text = DataGridCartas.CurrentRow.Cells[4].Value.ToString();
                NumericDefesa.Text = DataGridCartas.CurrentRow.Cells[5].Value.ToString();
                txtcusto.Text = DataGridCartas.CurrentRow.Cells[6].Value.ToString();
                txtRegras.Text = DataGridCartas.CurrentRow.Cells[7].Value.ToString();
                NumericAtaque.Text = DataGridCartas.CurrentRow.Cells[8].Value.ToString();
                LinkLabelImagem.Text = DataGridCartas.CurrentRow.Cells[9].Value.ToString();

                id_carta = (int)DataGridCartas.CurrentRow.Cells[0].Value;
            }
            
            */
            
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


            private void btnRemover_Click(object sender, EventArgs e)
        {
         
            if (listVCartas.SelectedItems != null)
            {
                //cartaselecionada = container.CardSet.Where(jog => jog.Name.Equals(listVCartas.SelectedItems.ToString())).First();

                /*string caminhoImagem = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + cartaselecionada.Image;

                File.Delete(caminhoImagem);*/

              //  var procurar = container.CardSet.Where(id => id.Id.Equals(id_carta));



                //cartaselecionada = container.CardSet.Find(cartaselecionada);

                container.CardSet.Remove(cartaselecionada);

                
               


                container.SaveChanges();


                MessageBox.Show("Eliminado com sucesso!");

                refreshlistVcartas();
            }
            

            

        }

        private void tbxpesquisa_TextChanged(object sender, EventArgs e)
        {
           

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



        private void DataGridCartas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* string nome = DataGridCartas.CurrentRow.Cells[1].Value.ToString();
            string facao = DataGridCartas.CurrentRow.Cells[2].Value.ToString();
            string tipo = DataGridCartas.CurrentRow.Cells[3].Value.ToString();
            string lealdade =DataGridCartas.CurrentRow.Cells[4].Value.ToString();
            string custo = DataGridCartas.CurrentRow.Cells[5].Value.ToString();
            string regras = DataGridCartas.CurrentRow.Cells[6].Value.ToString();
            string ataque = DataGridCartas.CurrentRow.Cells[6].Value.ToString();
            string defesa = DataGridCartas.CurrentRow.Cells[6].Value.ToString();
            string imagem = DataGridCartas.CurrentRow.Cells[6].Value.ToString();

            Info_Cartas_ADM Info_cartas_ADM = new Info_Cartas_ADM(nome, facao, tipo, lealdade, custo, regras, ataque, defesa, imagem);
            Info_cartas_ADM.Show();*/
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

                File.Copy(caminhoFicheiro, Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + partes.Last());

                pictImagem.Image = Image.FromFile(caminhoFicheiro);

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

        public void CarregaDadosCartas()
        {
            Card carta;

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
    

       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialogImportar.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialogImportar.FileName;

                string linha = "";
                int nCartasTotais = 0;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home_ADM hfrm = new Home_ADM();
            hfrm.Show();
            Close();
        }
    }
}

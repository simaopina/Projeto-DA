﻿using System;
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
    public partial class Cartas_Arbitro : Form
    {
        int id_carta = 0;

        Card cartaselecionada;

        string ParteFinalNome;

        int id;

        public Cartas_Arbitro(int id_arb)
        {
            InitializeComponent();

            id = id_arb;

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
               
                listVCartas.Items.Add(CartaList);
            }
        }

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
       

        private void DataGridCartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro(id);
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BAfrm = new Baralho_Arbitro(id);
            BAfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CAfrm = new Cartas_Arbitro(id);
            CAfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JArbfrm = new JogoArbitro(id);
            JArbfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou AOTfrm = new Arbitro_JogosOndeTou(id);
            AOTfrm.Show();
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

        private void Cartas_Arbitro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet_Cards.CardSet' table. You can move, or remove it, as needed.
            //this.cardSetTableAdapter.Fill(this.baseDadosDataSet_Cards.CardSet);

        }

    }
}

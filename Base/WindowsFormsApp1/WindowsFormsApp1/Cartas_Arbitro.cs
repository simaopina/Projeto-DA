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
    public partial class Cartas_Arbitro : Form
    {
        int id_carta = 0;

        string ParteFinalNome;

        public Cartas_Arbitro()
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
               
                listVCartas.Items.Add(CartaList);
            }
        }

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
       

        private void DataGridCartas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    

        public void refresh_datagrid()
        {


        }

       


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tbxpesquisa.Text.Length > 0)
            {

                var query = container.CardSet.Where(carta => carta.Name.Contains(tbxpesquisa.Text));

               // DataGridCartas.DataSource = query.ToList();
            }

            else
            {
                refresh_datagrid();
            }
        }



        //Navegação
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro();
            HAfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baralho_Arbitro BAfrm = new Baralho_Arbitro();
            BAfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_Arbitro CAfrm = new Cartas_Arbitro();
            CAfrm.Show();
            Close();
        }

        private void jogosADecorrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JogoArbitro JArbfrm = new JogoArbitro();
            JArbfrm.Show();
            Close();
        }

        private void planeamentoDeJogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arbitro_JogosOndeTou AOTfrm = new Arbitro_JogosOndeTou();
            AOTfrm.Show();
            Close();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hitorico_Arbitro Histfrm = new Hitorico_Arbitro();
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
            this.cardSetTableAdapter.Fill(this.baseDadosDataSet_Cards.CardSet);

        }

        
    }
}

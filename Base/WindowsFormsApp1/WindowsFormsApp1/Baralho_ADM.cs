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
    public partial class Baralho_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public Baralho_ADM()
        {
            InitializeComponent();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();

            Hfrm.Show();
        }

        private void Baralho_ADM_Load(object sender, EventArgs e)
        {

        }

        private void btnBaralhoGaianAMD_Click(object sender, EventArgs e)
        {
           

        }

        private void btnBaralhoUneasyADM_Click(object sender, EventArgs e)
        {
            ListVBaralhoADM.SmallImageList = ListaBaralhoUneasyAlliance;

        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM form = new Baralho_ADM();
            // Ao atribuirmos à propriedade FormPrincipal uma referência para o form atual (form MTADMMenu)
            // podemos usar, o form ArmaForm, os métodos públicos do form principal e aceder, através de métodos
            // próprios para o efeito (ex.: método AdicionarArma()), aos componentes existentes no form principal.
           
            form.Show();
        }

        private void ListVBaralhoADM_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Card carta in container.CardSet)
            {
                ListViewItem item = new ListViewItem(carta.Name);
                //item.ImageIndex = carta.Image;
                ListVBaralhoADM.Items.Add(item);

            }
        }

        //Navegação
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permissoes_ADM Permfrm = new Permissoes_ADM();
            Permfrm.Show();
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
            Cartas_ADM Cfrm = new Cartas_ADM();

            Cfrm.Show();
            Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addJofrm = new ADD_Jogador_ADM();

            addJofrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM Hadmfrm = new Home_ADM();
            Hadmfrm.Show();
            Close();
        }
    }
}

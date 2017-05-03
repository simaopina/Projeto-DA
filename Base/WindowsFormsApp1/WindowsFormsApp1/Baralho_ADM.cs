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
        public Baralho_ADM()
        {
            InitializeComponent();
        }

        private void signoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Baralho_ADM_Load(object sender, EventArgs e)
        {

        }

        private void btnBaralhoGaianAMD_Click(object sender, EventArgs e)
        {
            ListVBaralhoADM.SmallImageList = ListaBaralhoGaianloveforlife;
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
    }
}

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
    public partial class Jogos : Form
    {
        public Jogos()
        {

            /*inserir/editar/eliminar*/
            InitializeComponent();
        }

        private void Jogos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosGameStardad.GameSet_StardadGame' table. You can move, or remove it, as needed.
            this.gameSet_StardadGameTableAdapter.Fill(this.baseDadosGameStardad.GameSet_StardadGame);

        }
    }
}

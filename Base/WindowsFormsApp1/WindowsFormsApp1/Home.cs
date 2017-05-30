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
    public partial class Home : Form
    {
        //Declaração de Variaveis
        public int id;

        //Inicialização do Form
        public Home()
        {
            InitializeComponent();

                  
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }
        //Navegação
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Lfrm = new Login(id);
            Lfrm.Show();
            Hide();           
        }
    }
}

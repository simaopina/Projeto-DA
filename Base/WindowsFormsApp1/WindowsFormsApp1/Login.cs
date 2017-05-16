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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Home_Arbitro HAfrm = new Home_Arbitro();

            HAfrm.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             Permissoes_ADM Perfrm = new Permissoes_ADM();

             Perfrm.Show();
        }
    }
}

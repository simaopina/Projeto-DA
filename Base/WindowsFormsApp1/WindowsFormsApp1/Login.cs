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

            string useremail = tbxemail.Text;
            string password = tbxPW.Text;

            if (tbxemail.Text == "")
            {
                MessageBox.Show("Insira uma email valido!");
                tbxemail.Focus();
            }


        Home_Arbitro HAfrm = new Home_Arbitro();

            //HAfrm.Show();
            //Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
             Home_ADM Perfrm = new Home_ADM();

             Perfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }
    }
}

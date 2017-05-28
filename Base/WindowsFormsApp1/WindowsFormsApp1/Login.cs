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
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        Administrator adminSelect = null;

        int id_admin = 0;

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
            else{
                if (tbxPW.Text == "")
                {
                    MessageBox.Show("Insira uma password valida!");
                    tbxPW.Focus();
                }

               // foreach (User user in container.UserSet.OfType<Administrator>())
                //{
                    if (tbxemail.Text.Length > 0)
                    {
                   
                   //var query = container.UserSet.OfType<Administrator>().Where(email => email.Email.Contains(tbxemail.Text));

                    Administrator db = new Administrator();
                    var query1 = from User in db.Email where db.Email == tbxemail.Text select User;
                    char validacao = query1.FirstOrDefault();

                    if (validacao != null)
                    {
                        Home_ADM HAdmfrm = new Home_ADM();
                        HAdmfrm.Show();
                        Close();
                    }
                    }
                //}
               
            }


            //Home_Arbitro HAfrm = new Home_Arbitro();
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

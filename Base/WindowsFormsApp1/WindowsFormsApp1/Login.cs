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

        Administrator administradorSelecionado = null;

        Referee arbitroSeleciona = null;

        public Login()
        {
            InitializeComponent();

            List<Administrator> admin = container.UserSet.OfType<Administrator>().ToList();

            List<Referee> arbitro = container.UserSet.OfType<Referee>().ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = tbxUsername.Text;
            string password = tbxPW.Text;

            /* // foreach (User user in container.UserSet.OfType<Administrator>())
             //{
                 if (tbxemail.Text.Length > 0)
                 {

                 //var query = container.UserSet.OfType<Administrator>().Where(email => email.Email.Contains(tbxemail.Text));

                 Administrator db = new Administrator();
                 var query = from User in db.Email where tbxemail.Text == db.Email select User;
                 char query1 = query.FirstOrDefault();

                 if (query1.ToString() != null || query1.ToString().Count() == 0)
                 {
                     Home_ADM HAdmfrm = new Home_ADM();
                     HAdmfrm.Show();
                     Close();
                 }
                 else
                 {
                     MessageBox.Show("Credencias erradas!");
                 }
                 }
             //}*/


           // var query = container.UserSet.OfType<Administrator>().Where(user => user.Username.Contains(tbxUsername.Text));

            //query.ToList().Where(user => user.Username.CompareTo(tbxUsername.Text.ToString()));

          

        }


        //Home_Arbitro HAfrm = new Home_Arbitro();
        //HAfrm.Show();
        //Close();
    

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home_Arbitro HArbfrm = new Home_Arbitro();
            HArbfrm.Show();
            Close();
        }

       
    }
}

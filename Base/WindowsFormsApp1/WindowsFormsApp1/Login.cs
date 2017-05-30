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

        public int id;

        public Login(int id_arb)
        {
            InitializeComponent();

            id = id_arb;

            List<Administrator> admin = container.UserSet.OfType<Administrator>().ToList();

            List<Referee> arbitro = container.UserSet.OfType<Referee>().ToList();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = tbxUsername.Text;
            string password = tbxPW.Text;

            if (rbAdm.Checked == true)
            {
                var query = from user in container.UserSet.OfType<Administrator>() where user.Username.Equals(tbxUsername.Text) where user.Password.Equals(tbxPW.Text) select user;


                if (query.Any())
                {
                    
                }
                else
                {
                    MessageBox.Show("Não tem histórico");
                }


            }

            else if (rbArb.Checked == true)
            {

                var query = from user in container.UserSet.OfType<Referee>() where user.Username.Equals(tbxUsername.Text) where user.Password.Equals(tbxPW.Text) select user;

                int id_arb = query.First().Id;

                if (query.Any())
                {
                    Home_Arbitro H_abrfrm = new Home_Arbitro(id_arb);
                    H_abrfrm.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário inválido!");
                }
            }
            

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
            Home_Arbitro HArbfrm = new Home_Arbitro(id);
            HArbfrm.Show();
            Close();
        }

       
    }
}

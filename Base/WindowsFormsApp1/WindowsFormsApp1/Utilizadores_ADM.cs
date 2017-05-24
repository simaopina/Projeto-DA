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
    public partial class Utilizadores_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        int id_ADM = 0;

        public Utilizadores_ADM()
        {
            InitializeComponent();

            List<Administrator> admin = container.UserSet.OfType<Administrator>().ToList();

            foreach (Administrator adm in admin)
            {
                ListViewItem item = new ListViewItem(adm.Username);
                item.SubItems.Add(adm.Email);
                listVADM.Items.Add(item);
            }
            //new string[] { adm.Username, adm.Email }



            List<Referee> arbitro = container.UserSet.OfType<Referee>().ToList();

            foreach (Referee arb in arbitro)
            {
                ListViewItem item = new ListViewItem(arb.Username);
                item.SubItems.Add(arb.Name);
                item.SubItems.Add(arb.Avatar);
                listView1.Items.Add(item);
            }


        }

        private void Utilizadores_ADM_Load(object sender, EventArgs e)
        {
          

            

        }

        private void btnGuardar_ADM_Click(object sender, EventArgs e)
        {
            string Username = txtbNickName_ADM.Text;
            string Password = txtbPassword_ADM.Text;
            string Email = txtbPassword_ADM.Text;


            Administrator User_ADM = new Administrator
            {
                Username = Username,
                Password = Password,
                Email = Email

            };

            container.UserSet.Add(User_ADM);
            container.SaveChanges();
            refresh_listview();

        }

        public void refresh_listview()
        {
            listVADM.Refresh();
        }

        private void btnAlterar_ADM_Click(object sender, EventArgs e)
        {
            /*string Username = txtbNickName_ADM.Text;
            string Password = txtbPassword_ADM.Text;
            string Email = txtbPassword_ADM.Text;

            Administrator User_ADM;

            //User_ADM = container.UserSet.Find(id_ADM);
            User_ADM.Username = Username;
            User_ADM.Password = Password;
            User_ADM.Email = Email;
            */

        }

        private void dataGrid_ADM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

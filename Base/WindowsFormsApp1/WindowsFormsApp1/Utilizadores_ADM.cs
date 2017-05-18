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
        }

        private void Utilizadores_ADM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosData_administrador.UserSet_Administrator' table. You can move, or remove it, as needed.
            this.userSet_AdministratorTableAdapter.Fill(this.baseDadosData_administrador.UserSet_Administrator);
            // TODO: This line of code loads data into the 'baseDadosDataSet2.UserSet' table. You can move, or remove it, as needed.
            this.userSetTableAdapter.Fill(this.baseDadosDataSet2.UserSet);

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
            refresh_datagrid();

        }

        public void refresh_datagrid()
        {
            this.userSet_AdministratorTableAdapter.Fill(this.baseDadosData_administrador.UserSet_Administrator);
            dataGrid_ADM.DataSource = userSetBindingSource;

           
        }

        private void btnAlterar_ADM_Click(object sender, EventArgs e)
        {
            string Username = txtbNickName_ADM.Text;
            string Password = txtbPassword_ADM.Text;
            string Email = txtbPassword_ADM.Text;

            Administrator User_ADM;

            User_ADM = container.UserSet.Find(id_ADM);
            User_ADM.Username = Username;
            User_ADM.Password = Password;
            User_ADM.Email = Email;


        }
    }
}

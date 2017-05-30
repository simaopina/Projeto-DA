using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Utilizadores_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        Administrator administradorSelecionado = null;

        Referee arbitroSeleciona = null;

        string partefinal;

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
                listVArbitro.Items.Add(item);
            }


        }

        private void Utilizadores_ADM_Load(object sender, EventArgs e)
        {
          

            

        }

        private void btnGuardar_ADM_Click(object sender, EventArgs e)
        {
            string Username = txtbNickName_ADM.Text;
            string Password = txtbPassword_ADM.Text;
            string Email = txtbEmail_ADM.Text;
           


            Administrator User_ADM = new Administrator
            {
                Username = Username,
                Password = Password,
                Email = Email


            };

            container.UserSet.Add(User_ADM);
            container.SaveChanges();
            refresh_listviewADM();

        }

        public void refresh_listviewADM()
        {
            listVADM.Items.Clear();

            List<Administrator> admin = container.UserSet.OfType<Administrator>().ToList();
            
            foreach (Administrator adm in admin)
            {
                ListViewItem item = new ListViewItem(adm.Username);
                item.SubItems.Add(adm.Email);
                listVADM.Items.Add(item);

            }

        }


        public void refresh_listviewARB()
        {
            listVArbitro.Items.Clear();

            List<Referee> arb = container.UserSet.OfType<Referee>().ToList();

            foreach (Referee arbrito in arb)
            {
                ListViewItem item = new ListViewItem(arbrito.Username);
                item.SubItems.Add(arbrito.Name);
                item.SubItems.Add(arbrito.Avatar);
                listVArbitro.Items.Add(item);

            }
        }



        private void btnAlterar_ADM_Click(object sender, EventArgs e)
        {
            string Username = txtbNickName_ADM.Text;
            string Password = txtbPassword_ADM.Text;
            string Email = txtbPassword_ADM.Text;

            List<Administrator> admin = container.UserSet.OfType<Administrator>().ToList();

            Administrator User_ADM;

            if (administradorSelecionado != null)
            {
                //User_ADM = container.UserSet.Find(id_ADM);
                
                administradorSelecionado.Username = Username;
                administradorSelecionado.Password = Password;
                administradorSelecionado.Email = Email;
                

                container.SaveChanges();

                MessageBox.Show("Alterado com sucesso!");

                refresh_listviewADM();
            }
           
        }

        private void dataGrid_ADM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listVADM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVArbitro.SelectedItems.Count > 0)
            {
                string adminU = listVADM.SelectedItems[0].Text;
                administradorSelecionado = container.UserSet.OfType<Administrator>().Where(user => user.Username.Equals(adminU)).First();

                CarregaDadosADM();

                listVADM.Refresh();

            }
            else
            {
                administradorSelecionado = null;
            }
        }

        private void CarregaDadosADM()
        {
           
            List<User> user = container.UserSet.ToList();

            txtbNickName_ADM.Text = administradorSelecionado.Username;
            txtbPassword_ADM.Text = administradorSelecionado.Password;
            txtbEmail_ADM.Text = administradorSelecionado.Email;
            
        }

        private void CarregaDadosARB()
        {
            List<User> user = container.UserSet.ToList();

            txtbNickName_ARB.Text = arbitroSeleciona.Username;
            txtbNome_ARB.Text = arbitroSeleciona.Name;
            txtbPassword_ARB.Text = arbitroSeleciona.Password;
            linkLAvatar_ARB.Text = arbitroSeleciona.Avatar;


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVArbitro.SelectedItems.Count > 0)
            {
                string arbU = listVArbitro.SelectedItems[0].Text;
                arbitroSeleciona = container.UserSet.OfType<Referee>().Where(user => user.Username.Equals(arbU)).First();

                CarregaDadosARB();

                listVArbitro.Refresh();

            }
            else
            {
                administradorSelecionado = null;
            }
        }

        private void btnGuarda_ARB_Click(object sender, EventArgs e)
        {
            string Username = txtbNickName_ARB.Text;
            string Password = txtbPassword_ARB.Text;
            string Nome = txtbNome_ARB.Text;
            string avatar = partefinal;


            Referee User_ARB = new Referee
            {
                Username = Username,
                Password = Password,
                Name = Nome,
                Avatar = avatar

            };

            container.UserSet.Add(User_ARB);
            container.SaveChanges();
            listVArbitro.Refresh();
        }

        private void linkLAvatar_ARB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (caminhoImagem.ShowDialog() == DialogResult.OK)
            {

                string caminhoFicheiro = caminhoImagem.FileName;

                caminhoFicheiro.Contains(".jpg");
                caminhoFicheiro.Contains(".png");

                string[] partes = caminhoFicheiro.Split('\\');
                partefinal = partes.Last();
                File.Copy(caminhoFicheiro, Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + partes.Last());

                linkLAvatar_ARB.Text = caminhoFicheiro;

            }
        }

        private void btnAlterar_ARB_Click(object sender, EventArgs e)
        {
            string Username = txtbNickName_ARB.Text;
            string Password = txtbPassword_ARB.Text;
            string Name = txtbNome_ARB.Text;
            string avatar = partefinal;

            List<Referee> arb = container.UserSet.OfType<Referee>().ToList();

            Administrator User_ARB;

            if (arbitroSeleciona != null)
            {
               // User_ADM = container.UserSet.Find(id_ADM);

                arbitroSeleciona.Username = Username;
                arbitroSeleciona.Password = Password;
                arbitroSeleciona.Name = Name;
                arbitroSeleciona.Avatar = avatar;


                container.SaveChanges();

                MessageBox.Show("Alterado com sucesso!");

                refresh_listviewARB();
              
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_ADM_Click(object sender, EventArgs e)
        {

            string caminhoImagem = Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + arbitroSeleciona.Avatar;

            File.Delete(caminhoImagem);

            string Username = administradorSelecionado.Username;
            
            var query = container.UserSet.Where(admin => admin.Id.Equals(administradorSelecionado.Username));

            container.UserSet.Remove(administradorSelecionado);

            container.SaveChanges();

            administradorSelecionado = null;

            MessageBox.Show("Eliminado com sucesso!");

            refresh_listviewADM();


        }

        private void btn_eliminarArbitro_Click(object sender, EventArgs e)
        {
            string Username = arbitroSeleciona.Username;

            var query = container.UserSet.Where(arbitro => arbitro.Id.Equals(arbitroSeleciona.Username));

            container.UserSet.Remove(arbitroSeleciona);

            container.SaveChanges();

            arbitroSeleciona = null;

            MessageBox.Show("Eliminado com sucesso!");

            refresh_listviewARB();

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAdmfrm = new Home_ADM();
            HAdmfrm.Show();
            Close();
        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM BAdmfrm = new Baralho_ADM();
            BAdmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM EBAfrm = new Edicao_Baralhos_ADM();
            EBAfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM CAdmfrm = new Cartas_ADM();
            CAdmfrm.Show();
            Close();                
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM AJAfrm = new ADD_Jogador_ADM();
            AJAfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa IEfrm = new InserirEquipa();
            IEfrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM Utilfrm = new Utilizadores_ADM();
            Utilfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CriarTorneio CTorfrm = new CriarTorneio();
            CTorfrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores GTJfrm = new GestaoTorneioJogadores();
            GTJfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas GTEfrm = new GestaoTorneioEquipas();
            GTEfrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home Hfrm = new Home();
            Hfrm.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class ADD_Jogador_ADM : Form
    {
        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public ADD_Jogador_ADM()
        {
            InitializeComponent();
        }

        private void tbxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            string email = tbxEmail.Text;
            string nickname = tbxNickName.Text;
            int idade = Convert.ToInt32(numupdownIdade.Text);
            string imagem = "asd";


            Player jogador = new Player
            {
                Name = nome,
                Email = email,
                Nickname = nickname,
                Age = idade,
                Avatar = imagem
            };

            container.PlayerSet.Add(jogador);
            container.SaveChanges();
        }

    }
}

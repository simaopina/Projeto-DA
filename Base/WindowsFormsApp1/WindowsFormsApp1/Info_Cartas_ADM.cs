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
    public partial class Info_Cartas_ADM : Form
    {
        public Info_Cartas_ADM()
        {
            InitializeComponent();


        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void Info_Cartas_ADM_Load(object sender, EventArgs e)
        {
            string nome = lblNome.Text;
            string facao = lblFacao.Text;
            string tipo = lblTipo.Text;
            int lealdade = Convert.ToInt32(lblLealdade.Text);
            int custo = Convert.ToInt32(lblCusto.Text);
            string regras = lblRegras.Text;
            int ataque = Convert.ToInt32(lblAtaque.Text);
            int defesa = Convert.ToInt32(lblDefesa.Text);
            int imagem = 0;


             Card carta = new Card
            {
                Name = nome,
                Faction = facao,
                Type = tipo,
                Loyalty = lealdade,
                Cost = custo,
                RuleText = regras,
                Attack = ataque,
                Defense = defesa,
                Image = imagem
            };
        }
    }
}

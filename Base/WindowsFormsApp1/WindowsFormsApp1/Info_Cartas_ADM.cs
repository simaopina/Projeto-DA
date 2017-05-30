﻿using System;
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
    public partial class Info_Cartas_ADM : Form
    {
        //declaração de variaveis
        int id_carta = 0;

        string ParteFinalNome;

        Card carta = null;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public Info_Cartas_ADM(string nome, string facao, string tipo, string lealdade, string custo, string regras, string  ataque, string defesa, string imagem)
        {
            InitializeComponent();

            lblNome.Text = nome;
            lblFacao.Text = facao;
            lblTipo.Text = tipo;
            lblLealdade.Text = lealdade;
            lblCusto.Text = custo;
            lblRegras.Text = regras;
            lblAtaque.Text = ataque;
            lblDefesa.Text = defesa;
            pictureBox.Image = Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\imagens\" + imagem);

        }

        private void Info_Cartas_ADM_Load(object sender, EventArgs e)
        {

            
        }
    }
}

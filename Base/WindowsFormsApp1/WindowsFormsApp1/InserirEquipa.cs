﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class InserirEquipa : Form
    {
        Team equipaSelected = null;

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();
        public InserirEquipa()
        {
            InitializeComponent();

            foreach (Player jogador in container.PlayerSet)
            {
                lbxJogador1.Items.Add(jogador.Name.ToString());
            }
            foreach (Player jogador in container.PlayerSet)
            {
                lbxJogador2.Items.Add(jogador.Name.ToString());
            }
        }

        private void lbxEquipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxEquipa.SelectedItem != null)
            {
                equipaSelected = container.TeamSet.Where(equip => equip.Name.Equals(lbxEquipa.SelectedItem.ToString())).First();
                tbxNome.Text = equipaSelected.Name;

            }
            else
            {
                equipaSelected = null;
            }
        }

        private void AddEquipa()
        {
            string nome = tbxNome.Text;
            string imagem = picbxAvatar.Text;
            string jogador1 = lbxJogador1.Text;
            string jogador2 = lbxJogador2.Text;


            Team equipa = new Team
            {
                Name = nome,
                Avatar = imagem
                
            };

            container.TeamSet.Add(equipa);
            container.SaveChanges();
            refreshEquipa();
        }

        private void refreshEquipa()
        {
            lbxEquipa.Items.Clear();

            foreach (Team equipa in container.TeamSet)
            {
                lbxEquipa.Items.Add(equipa.Name);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            AddEquipa();
            refreshEquipa();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void Cancelar()
        {
            tbxNome.ResetText();
            picbxAvatar.ResetText();
        }
    }
}

﻿using System;
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
    public partial class GestaoTorneioJogadores : Form
    {
        public GestaoTorneioJogadores()
        {
            InitializeComponent();
        }

        public DiagramaEntidadesArcmageContainer container = new DiagramaEntidadesArcmageContainer();

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home_ADM HAfrm = new Home_ADM();
            HAfrm.Show();
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void baralhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Baralho_ADM barfrm = new Baralho_ADM();
            barfrm.Show();
            Close();
        }

        private void homeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Home_ADM hmfrm = new Home_ADM();
            hmfrm.Show();
            Close();
        }

        private void editarBaralhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edicao_Baralhos_ADM ebfrm = new Edicao_Baralhos_ADM();
            ebfrm.Show();
            Close();
        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartas_ADM ctfrm = new Cartas_ADM();
            ctfrm.Show();
            Close();
        }

        private void novoJogadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD_Jogador_ADM addfrm = new ADD_Jogador_ADM();
            addfrm.Show();
            Close();
        }

        private void novaEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InserirEquipa efrm = new InserirEquipa();
            efrm.Show();
            Close();
        }

        private void utilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilizadores_ADM ufrm = new Utilizadores_ADM();
            ufrm.Show();
            Close();
        }

        private void torneioIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioJogadores gtfrm = new GestaoTorneioJogadores();
            gtfrm.Show();
            Close();
        }

        private void torneioEquipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestaoTorneioEquipas gtefrm = new GestaoTorneioEquipas();
            gtefrm.Show();
            Close();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home logfrm = new Home();
            logfrm.Show();
            Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ATorneioJogosStandard tjsfrm = new ATorneioJogosStandard();
            tjsfrm.Show();
            Close();
        }

        private void btnPesquisarJogador1_Click(object sender, EventArgs e)
        {
            if (tbxJogador1.Text.Length > 0)
            {

                var query = container.PlayerSet.Where(pla => pla.Name.Contains(tbxJogador1.Text));

                dataGridJogador1.DataSource = query.ToList();
            }

            else
            {
                refresh_datagrid();
            }
        }

        private void GestaoTorneioJogadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet4.PlayerSet' table. You can move, or remove it, as needed.
            this.playerSetTableAdapter1.Fill(this.baseDadosDataSet4.PlayerSet);
            // TODO: This line of code loads data into the 'baseDadosDataSet3.PlayerSet' table. You can move, or remove it, as needed.
            this.playerSetTableAdapter.Fill(this.baseDadosDataSet3.PlayerSet);

        }

        private void btnPesquisarJogador2_Click(object sender, EventArgs e)
        {
            if (tbxJogador2.Text.Length > 0)
            {

                var query = container.PlayerSet.Where(play => play.Name.Contains(tbxJogador2.Text));

                dataGridJogador2.DataSource = query.ToList();
            }

            else
            {
                refresh_datagrid();
            }
        }

        public void refresh_datagrid()
        {
            
            this.playerSetTableAdapter.Fill(this.baseDadosDataSet3.PlayerSet);
            dataGridJogador1.DataSource = playerSetBindingSource;
            dataGridJogador2.DataSource = playerSetBindingSource;

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = tbxNome.Text;
            string data = datetimeData.Text;
            string hora = datetimeHora.Text;
            string descricao = tbxDescricao.Text;

            Jogos jogo = new Jogos
            {
                Name = nome,
                Date = data,
                Hora = hora,
                Description = descricao
            };
        }
    }
}

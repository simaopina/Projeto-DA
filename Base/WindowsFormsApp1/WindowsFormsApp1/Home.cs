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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
       
        }

        private void Home_Load(object sender, EventArgs e)
        {
            /*Utilizadores_ADM UTILIZADORESfrm = new Utilizadores_ADM();
            UTILIZADORESfrm.Show();
            Hide();*/
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Lfrm = new Login();
            Lfrm.Show();
            Hide();

           
        }

        private void iiiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarTorneio ctfrm = new CriarTorneio();
            ctfrm.Show();
        }
    }
}

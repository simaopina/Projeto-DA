﻿namespace WindowsFormsApp1
{
    partial class JogoArbitro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxJogosArbitro = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.listVNumeroJogo = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listVData = new System.Windows.Forms.ListView();
            this.listVJogo = new System.Windows.Forms.ListView();
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
            this.rbtnCartas = new System.Windows.Forms.RadioButton();
            this.rbtnTorneio = new System.Windows.Forms.RadioButton();
            this.rbtnJogadores = new System.Windows.Forms.RadioButton();
            this.rbtnArbitro = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosADecorrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeamentoDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxJogosArbitro.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxJogosArbitro
            // 
            this.gbxJogosArbitro.Controls.Add(this.label13);
            this.gbxJogosArbitro.Controls.Add(this.listVNumeroJogo);
            this.gbxJogosArbitro.Controls.Add(this.label12);
            this.gbxJogosArbitro.Controls.Add(this.label11);
            this.gbxJogosArbitro.Controls.Add(this.listVData);
            this.gbxJogosArbitro.Controls.Add(this.listVJogo);
            this.gbxJogosArbitro.Location = new System.Drawing.Point(245, 272);
            this.gbxJogosArbitro.Name = "gbxJogosArbitro";
            this.gbxJogosArbitro.Size = new System.Drawing.Size(348, 248);
            this.gbxJogosArbitro.TabIndex = 30;
            this.gbxJogosArbitro.TabStop = false;
            this.gbxJogosArbitro.Text = "Jogos Arbitro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Nº";
            // 
            // listVNumeroJogo
            // 
            this.listVNumeroJogo.Location = new System.Drawing.Point(7, 33);
            this.listVNumeroJogo.Name = "listVNumeroJogo";
            this.listVNumeroJogo.Size = new System.Drawing.Size(40, 209);
            this.listVNumeroJogo.TabIndex = 4;
            this.listVNumeroJogo.UseCompatibleStateImageBehavior = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(236, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Jogo";
            // 
            // listVData
            // 
            this.listVData.Location = new System.Drawing.Point(238, 33);
            this.listVData.Name = "listVData";
            this.listVData.Size = new System.Drawing.Size(104, 209);
            this.listVData.TabIndex = 1;
            this.listVData.UseCompatibleStateImageBehavior = false;
            // 
            // listVJogo
            // 
            this.listVJogo.Location = new System.Drawing.Point(53, 33);
            this.listVJogo.Name = "listVJogo";
            this.listVJogo.Size = new System.Drawing.Size(179, 209);
            this.listVJogo.TabIndex = 0;
            this.listVJogo.UseCompatibleStateImageBehavior = false;
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(245, 205);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(266, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // rbtnCartas
            // 
            this.rbtnCartas.AutoSize = true;
            this.rbtnCartas.Location = new System.Drawing.Point(456, 235);
            this.rbtnCartas.Name = "rbtnCartas";
            this.rbtnCartas.Size = new System.Drawing.Size(55, 17);
            this.rbtnCartas.TabIndex = 25;
            this.rbtnCartas.TabStop = true;
            this.rbtnCartas.Text = "Cartas";
            this.rbtnCartas.UseVisualStyleBackColor = true;
            // 
            // rbtnTorneio
            // 
            this.rbtnTorneio.AutoSize = true;
            this.rbtnTorneio.Location = new System.Drawing.Point(388, 235);
            this.rbtnTorneio.Name = "rbtnTorneio";
            this.rbtnTorneio.Size = new System.Drawing.Size(61, 17);
            this.rbtnTorneio.TabIndex = 24;
            this.rbtnTorneio.TabStop = true;
            this.rbtnTorneio.Text = "Torneio";
            this.rbtnTorneio.UseVisualStyleBackColor = true;
            // 
            // rbtnJogadores
            // 
            this.rbtnJogadores.AutoSize = true;
            this.rbtnJogadores.Location = new System.Drawing.Point(307, 235);
            this.rbtnJogadores.Name = "rbtnJogadores";
            this.rbtnJogadores.Size = new System.Drawing.Size(74, 17);
            this.rbtnJogadores.TabIndex = 23;
            this.rbtnJogadores.TabStop = true;
            this.rbtnJogadores.Text = "Jogadores";
            this.rbtnJogadores.UseVisualStyleBackColor = true;
            // 
            // rbtnArbitro
            // 
            this.rbtnArbitro.AutoSize = true;
            this.rbtnArbitro.Location = new System.Drawing.Point(245, 235);
            this.rbtnArbitro.Name = "rbtnArbitro";
            this.rbtnArbitro.Size = new System.Drawing.Size(55, 17);
            this.rbtnArbitro.TabIndex = 22;
            this.rbtnArbitro.TabStop = true;
            this.rbtnArbitro.Text = "Arbitro";
            this.rbtnArbitro.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(518, 205);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.torneioToolStripMenuItem,
            this.terminarSessãoToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(640, 24);
            this.menuStripHome.TabIndex = 20;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baralhoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cartasToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.loginToolStripMenuItem.Text = "Baralho";
            // 
            // baralhoToolStripMenuItem
            // 
            this.baralhoToolStripMenuItem.Name = "baralhoToolStripMenuItem";
            this.baralhoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.baralhoToolStripMenuItem.Text = "Baralho";
            this.baralhoToolStripMenuItem.Click += new System.EventHandler(this.baralhoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.cartasToolStripMenuItem.Text = "Cartas";
            this.cartasToolStripMenuItem.Click += new System.EventHandler(this.cartasToolStripMenuItem_Click);
            // 
            // torneioToolStripMenuItem
            // 
            this.torneioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosADecorrerToolStripMenuItem,
            this.planeamentoDeJogosToolStripMenuItem,
            this.historicoToolStripMenuItem});
            this.torneioToolStripMenuItem.Name = "torneioToolStripMenuItem";
            this.torneioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.torneioToolStripMenuItem.Text = "Torneio";
            // 
            // jogosADecorrerToolStripMenuItem
            // 
            this.jogosADecorrerToolStripMenuItem.Name = "jogosADecorrerToolStripMenuItem";
            this.jogosADecorrerToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.jogosADecorrerToolStripMenuItem.Text = "Jogos a decorrer";
            this.jogosADecorrerToolStripMenuItem.Click += new System.EventHandler(this.jogosADecorrerToolStripMenuItem_Click);
            // 
            // planeamentoDeJogosToolStripMenuItem
            // 
            this.planeamentoDeJogosToolStripMenuItem.Name = "planeamentoDeJogosToolStripMenuItem";
            this.planeamentoDeJogosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.planeamentoDeJogosToolStripMenuItem.Text = "Planeamento de jogos";
            this.planeamentoDeJogosToolStripMenuItem.Click += new System.EventHandler(this.planeamentoDeJogosToolStripMenuItem_Click);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.historicoToolStripMenuItem.Text = "Historico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar Sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.terminarSessãoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // JogoArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 540);
            this.Controls.Add(this.gbxJogosArbitro);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.rbtnCartas);
            this.Controls.Add(this.rbtnTorneio);
            this.Controls.Add(this.rbtnJogadores);
            this.Controls.Add(this.rbtnArbitro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "JogoArbitro";
            this.Text = "JogoArbitro";
            this.gbxJogosArbitro.ResumeLayout(false);
            this.gbxJogosArbitro.PerformLayout();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxJogosArbitro;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.RadioButton rbtnCartas;
        private System.Windows.Forms.RadioButton rbtnTorneio;
        private System.Windows.Forms.RadioButton rbtnJogadores;
        private System.Windows.Forms.RadioButton rbtnArbitro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listVData;
        private System.Windows.Forms.ListView listVJogo;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosADecorrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeamentoDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listVNumeroJogo;
    }
}
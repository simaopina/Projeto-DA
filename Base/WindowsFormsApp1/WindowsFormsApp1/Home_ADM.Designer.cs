namespace WindowsFormsApp1
{
    partial class Home_ADM
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarBaralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.novaEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.torneioIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCartas = new System.Windows.Forms.Button();
            this.btnJogador = new System.Windows.Forms.Button();
            this.btnEditBaralhos = new System.Windows.Forms.Button();
            this.btnBaralhos = new System.Windows.Forms.Button();
            this.btnUtilizadores = new System.Windows.Forms.Button();
            this.btnGestaoTorneios = new System.Windows.Forms.Button();
            this.btnGestaoDeJogosST = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGestaoDeJogosTeam = new System.Windows.Forms.Button();
            this.gpbxMenu = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripHome.SuspendLayout();
            this.gpbxMenu.SuspendLayout();
            this.SuspendLayout();
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
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.baralhoToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.terminarSessãoToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(640, 24);
            this.menuStripHome.TabIndex = 42;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // baralhoToolStripMenuItem
            // 
            this.baralhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baralhoToolStripMenuItem1,
            this.editarBaralhoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cartasToolStripMenuItem});
            this.baralhoToolStripMenuItem.Name = "baralhoToolStripMenuItem";
            this.baralhoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.baralhoToolStripMenuItem.Text = "Baralho";
            // 
            // baralhoToolStripMenuItem1
            // 
            this.baralhoToolStripMenuItem1.Name = "baralhoToolStripMenuItem1";
            this.baralhoToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.baralhoToolStripMenuItem1.Text = "Baralho";
            this.baralhoToolStripMenuItem1.Click += new System.EventHandler(this.baralhoToolStripMenuItem1_Click_1);
            // 
            // editarBaralhoToolStripMenuItem
            // 
            this.editarBaralhoToolStripMenuItem.Name = "editarBaralhoToolStripMenuItem";
            this.editarBaralhoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarBaralhoToolStripMenuItem.Text = "Editar Baralho";
            this.editarBaralhoToolStripMenuItem.Click += new System.EventHandler(this.editarBaralhoToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cartasToolStripMenuItem.Text = "Cartas";
            this.cartasToolStripMenuItem.Click += new System.EventHandler(this.cartasToolStripMenuItem_Click_1);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogadorToolStripMenuItem,
            this.toolStripSeparator2,
            this.novaEquipaToolStripMenuItem,
            this.toolStripSeparator3,
            this.utilizadoresToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.jogadoresToolStripMenuItem.Text = "Gestão Utilizadores";
            // 
            // novoJogadorToolStripMenuItem
            // 
            this.novoJogadorToolStripMenuItem.Name = "novoJogadorToolStripMenuItem";
            this.novoJogadorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.novoJogadorToolStripMenuItem.Text = "Jogador";
            this.novoJogadorToolStripMenuItem.Click += new System.EventHandler(this.novoJogadorToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // novaEquipaToolStripMenuItem
            // 
            this.novaEquipaToolStripMenuItem.Name = "novaEquipaToolStripMenuItem";
            this.novaEquipaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.novaEquipaToolStripMenuItem.Text = "Nova Equipa";
            this.novaEquipaToolStripMenuItem.Click += new System.EventHandler(this.novaEquipaToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // utilizadoresToolStripMenuItem
            // 
            this.utilizadoresToolStripMenuItem.Name = "utilizadoresToolStripMenuItem";
            this.utilizadoresToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.utilizadoresToolStripMenuItem.Text = "Utilizadores";
            this.utilizadoresToolStripMenuItem.Click += new System.EventHandler(this.utilizadoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator4,
            this.torneioIndividualToolStripMenuItem,
            this.torneioEquipaToolStripMenuItem,
            this.listaDeJogosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.toolStripMenuItem1.Text = "Gestão Jogos";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItem2.Text = "Torneios";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(151, 6);
            // 
            // torneioIndividualToolStripMenuItem
            // 
            this.torneioIndividualToolStripMenuItem.Name = "torneioIndividualToolStripMenuItem";
            this.torneioIndividualToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.torneioIndividualToolStripMenuItem.Text = "Jogo Individual";
            this.torneioIndividualToolStripMenuItem.Click += new System.EventHandler(this.torneioIndividualToolStripMenuItem_Click);
            // 
            // torneioEquipaToolStripMenuItem
            // 
            this.torneioEquipaToolStripMenuItem.Name = "torneioEquipaToolStripMenuItem";
            this.torneioEquipaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.torneioEquipaToolStripMenuItem.Text = "Jogo Equipa";
            this.torneioEquipaToolStripMenuItem.Click += new System.EventHandler(this.torneioEquipaToolStripMenuItem_Click);
            // 
            // listaDeJogosToolStripMenuItem
            // 
            this.listaDeJogosToolStripMenuItem.Name = "listaDeJogosToolStripMenuItem";
            this.listaDeJogosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listaDeJogosToolStripMenuItem.Text = "Lista de Jogos";
            this.listaDeJogosToolStripMenuItem.Click += new System.EventHandler(this.listaDeJogosToolStripMenuItem_Click);
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar Sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.terminarSessãoToolStripMenuItem_Click);
            // 
            // btnCartas
            // 
            this.btnCartas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCartas.Location = new System.Drawing.Point(51, 173);
            this.btnCartas.Name = "btnCartas";
            this.btnCartas.Size = new System.Drawing.Size(98, 92);
            this.btnCartas.TabIndex = 33;
            this.btnCartas.Text = "Cartas";
            this.btnCartas.UseVisualStyleBackColor = false;
            this.btnCartas.Click += new System.EventHandler(this.btnCartas_Click);
            // 
            // btnJogador
            // 
            this.btnJogador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnJogador.Location = new System.Drawing.Point(257, 52);
            this.btnJogador.Name = "btnJogador";
            this.btnJogador.Size = new System.Drawing.Size(98, 92);
            this.btnJogador.TabIndex = 37;
            this.btnJogador.Text = "Adicionar Jogador";
            this.btnJogador.UseVisualStyleBackColor = false;
            this.btnJogador.Click += new System.EventHandler(this.btnJogador_Click);
            // 
            // btnEditBaralhos
            // 
            this.btnEditBaralhos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEditBaralhos.Location = new System.Drawing.Point(61, 24);
            this.btnEditBaralhos.Name = "btnEditBaralhos";
            this.btnEditBaralhos.Size = new System.Drawing.Size(75, 23);
            this.btnEditBaralhos.TabIndex = 35;
            this.btnEditBaralhos.Text = "Edição";
            this.btnEditBaralhos.UseVisualStyleBackColor = false;
            this.btnEditBaralhos.Click += new System.EventHandler(this.btnEditBaralhos_Click);
            // 
            // btnBaralhos
            // 
            this.btnBaralhos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaralhos.Location = new System.Drawing.Point(51, 52);
            this.btnBaralhos.Name = "btnBaralhos";
            this.btnBaralhos.Size = new System.Drawing.Size(98, 92);
            this.btnBaralhos.TabIndex = 34;
            this.btnBaralhos.Text = "Baralhos";
            this.btnBaralhos.UseVisualStyleBackColor = false;
            this.btnBaralhos.Click += new System.EventHandler(this.btnBaralhos_Click);
            // 
            // btnUtilizadores
            // 
            this.btnUtilizadores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUtilizadores.Location = new System.Drawing.Point(257, 173);
            this.btnUtilizadores.Name = "btnUtilizadores";
            this.btnUtilizadores.Size = new System.Drawing.Size(98, 92);
            this.btnUtilizadores.TabIndex = 39;
            this.btnUtilizadores.Text = "Utilizadores";
            this.btnUtilizadores.UseVisualStyleBackColor = false;
            this.btnUtilizadores.Click += new System.EventHandler(this.btnUtilizadores_Click);
            // 
            // btnGestaoTorneios
            // 
            this.btnGestaoTorneios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGestaoTorneios.Location = new System.Drawing.Point(465, 52);
            this.btnGestaoTorneios.Name = "btnGestaoTorneios";
            this.btnGestaoTorneios.Size = new System.Drawing.Size(98, 92);
            this.btnGestaoTorneios.TabIndex = 40;
            this.btnGestaoTorneios.Text = "Gestão de torneios";
            this.btnGestaoTorneios.UseVisualStyleBackColor = false;
            this.btnGestaoTorneios.Click += new System.EventHandler(this.btnGestaoTorneios_Click);
            // 
            // btnGestaoDeJogosST
            // 
            this.btnGestaoDeJogosST.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGestaoDeJogosST.Location = new System.Drawing.Point(465, 173);
            this.btnGestaoDeJogosST.Name = "btnGestaoDeJogosST";
            this.btnGestaoDeJogosST.Size = new System.Drawing.Size(98, 44);
            this.btnGestaoDeJogosST.TabIndex = 41;
            this.btnGestaoDeJogosST.Text = "Gestão de jogos Standard";
            this.btnGestaoDeJogosST.UseVisualStyleBackColor = false;
            this.btnGestaoDeJogosST.Click += new System.EventHandler(this.btnGestaoDeJogosST_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Welcome!";
            // 
            // btnGestaoDeJogosTeam
            // 
            this.btnGestaoDeJogosTeam.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGestaoDeJogosTeam.Location = new System.Drawing.Point(465, 221);
            this.btnGestaoDeJogosTeam.Name = "btnGestaoDeJogosTeam";
            this.btnGestaoDeJogosTeam.Size = new System.Drawing.Size(98, 44);
            this.btnGestaoDeJogosTeam.TabIndex = 42;
            this.btnGestaoDeJogosTeam.Text = "Gestão de jogos team";
            this.btnGestaoDeJogosTeam.UseVisualStyleBackColor = false;
            this.btnGestaoDeJogosTeam.Click += new System.EventHandler(this.btnGestaoDeJogosTeam_Click);
            // 
            // gpbxMenu
            // 
            this.gpbxMenu.Controls.Add(this.btnGestaoDeJogosTeam);
            this.gpbxMenu.Controls.Add(this.btnGestaoDeJogosST);
            this.gpbxMenu.Controls.Add(this.btnGestaoTorneios);
            this.gpbxMenu.Controls.Add(this.btnUtilizadores);
            this.gpbxMenu.Controls.Add(this.btnBaralhos);
            this.gpbxMenu.Controls.Add(this.btnEditBaralhos);
            this.gpbxMenu.Controls.Add(this.btnJogador);
            this.gpbxMenu.Controls.Add(this.btnCartas);
            this.gpbxMenu.Location = new System.Drawing.Point(12, 250);
            this.gpbxMenu.Name = "gpbxMenu";
            this.gpbxMenu.Size = new System.Drawing.Size(616, 295);
            this.gpbxMenu.TabIndex = 41;
            this.gpbxMenu.TabStop = false;
            this.gpbxMenu.Text = "Menu:";
            // 
            // Home_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 540);
            this.Controls.Add(this.menuStripHome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbxMenu);
            this.Name = "Home_ADM";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.gpbxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarBaralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem novaEquipaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem torneioIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioEquipaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.Button btnCartas;
        private System.Windows.Forms.Button btnJogador;
        private System.Windows.Forms.Button btnEditBaralhos;
        private System.Windows.Forms.Button btnBaralhos;
        private System.Windows.Forms.Button btnUtilizadores;
        private System.Windows.Forms.Button btnGestaoTorneios;
        private System.Windows.Forms.Button btnGestaoDeJogosST;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGestaoDeJogosTeam;
        private System.Windows.Forms.GroupBox gpbxMenu;
        private System.Windows.Forms.ToolStripMenuItem listaDeJogosToolStripMenuItem;
    }
}
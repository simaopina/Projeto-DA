namespace WindowsFormsApp1
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rbtnArbitro = new System.Windows.Forms.RadioButton();
            this.rbtnJogadores = new System.Windows.Forms.RadioButton();
            this.rbtnTorneio = new System.Windows.Forms.RadioButton();
            this.rbtnCartas = new System.Windows.Forms.RadioButton();
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
            this.listRank = new System.Windows.Forms.ListView();
            this.listEquipas = new System.Windows.Forms.ListView();
            this.list_Curiosidades = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxRank = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEquipas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxCuriosidades = new System.Windows.Forms.GroupBox();
            this.gbxNoticias = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStripHome.SuspendLayout();
            this.gbxRank.SuspendLayout();
            this.gbxEquipas.SuspendLayout();
            this.gbxCuriosidades.SuspendLayout();
            this.gbxNoticias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(627, 24);
            this.menuStripHome.TabIndex = 0;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(518, 203);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // rbtnArbitro
            // 
            this.rbtnArbitro.AutoSize = true;
            this.rbtnArbitro.Location = new System.Drawing.Point(245, 233);
            this.rbtnArbitro.Name = "rbtnArbitro";
            this.rbtnArbitro.Size = new System.Drawing.Size(55, 17);
            this.rbtnArbitro.TabIndex = 2;
            this.rbtnArbitro.TabStop = true;
            this.rbtnArbitro.Text = "Arbitro";
            this.rbtnArbitro.UseVisualStyleBackColor = true;
            // 
            // rbtnJogadores
            // 
            this.rbtnJogadores.AutoSize = true;
            this.rbtnJogadores.Location = new System.Drawing.Point(307, 233);
            this.rbtnJogadores.Name = "rbtnJogadores";
            this.rbtnJogadores.Size = new System.Drawing.Size(74, 17);
            this.rbtnJogadores.TabIndex = 3;
            this.rbtnJogadores.TabStop = true;
            this.rbtnJogadores.Text = "Jogadores";
            this.rbtnJogadores.UseVisualStyleBackColor = true;
            // 
            // rbtnTorneio
            // 
            this.rbtnTorneio.AutoSize = true;
            this.rbtnTorneio.Location = new System.Drawing.Point(388, 233);
            this.rbtnTorneio.Name = "rbtnTorneio";
            this.rbtnTorneio.Size = new System.Drawing.Size(61, 17);
            this.rbtnTorneio.TabIndex = 4;
            this.rbtnTorneio.TabStop = true;
            this.rbtnTorneio.Text = "Torneio";
            this.rbtnTorneio.UseVisualStyleBackColor = true;
            // 
            // rbtnCartas
            // 
            this.rbtnCartas.AutoSize = true;
            this.rbtnCartas.Location = new System.Drawing.Point(456, 233);
            this.rbtnCartas.Name = "rbtnCartas";
            this.rbtnCartas.Size = new System.Drawing.Size(55, 17);
            this.rbtnCartas.TabIndex = 5;
            this.rbtnCartas.TabStop = true;
            this.rbtnCartas.Text = "Cartas";
            this.rbtnCartas.UseVisualStyleBackColor = true;
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(245, 203);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(266, 20);
            this.tbxpesquisa.TabIndex = 6;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // listRank
            // 
            this.listRank.Location = new System.Drawing.Point(37, 19);
            this.listRank.Name = "listRank";
            this.listRank.Size = new System.Drawing.Size(121, 64);
            this.listRank.TabIndex = 7;
            this.listRank.UseCompatibleStateImageBehavior = false;
            // 
            // listEquipas
            // 
            this.listEquipas.Location = new System.Drawing.Point(37, 19);
            this.listEquipas.Name = "listEquipas";
            this.listEquipas.Size = new System.Drawing.Size(121, 64);
            this.listEquipas.TabIndex = 8;
            this.listEquipas.UseCompatibleStateImageBehavior = false;
            // 
            // list_Curiosidades
            // 
            this.list_Curiosidades.Location = new System.Drawing.Point(37, 19);
            this.list_Curiosidades.Name = "list_Curiosidades";
            this.list_Curiosidades.Size = new System.Drawing.Size(121, 64);
            this.list_Curiosidades.TabIndex = 9;
            this.list_Curiosidades.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "1.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "2.";
            // 
            // gbxRank
            // 
            this.gbxRank.Controls.Add(this.label7);
            this.gbxRank.Controls.Add(this.label6);
            this.gbxRank.Controls.Add(this.label1);
            this.gbxRank.Controls.Add(this.listRank);
            this.gbxRank.Controls.Add(this.label5);
            this.gbxRank.Controls.Add(this.label4);
            this.gbxRank.Location = new System.Drawing.Point(35, 196);
            this.gbxRank.Name = "gbxRank";
            this.gbxRank.Size = new System.Drawing.Size(179, 100);
            this.gbxRank.TabIndex = 15;
            this.gbxRank.TabStop = false;
            this.gbxRank.Text = "Rank Jogadores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "5.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "4.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "3.";
            // 
            // gbxEquipas
            // 
            this.gbxEquipas.Controls.Add(this.label2);
            this.gbxEquipas.Controls.Add(this.listEquipas);
            this.gbxEquipas.Controls.Add(this.label3);
            this.gbxEquipas.Controls.Add(this.label8);
            this.gbxEquipas.Controls.Add(this.label10);
            this.gbxEquipas.Controls.Add(this.label9);
            this.gbxEquipas.Location = new System.Drawing.Point(35, 303);
            this.gbxEquipas.Name = "gbxEquipas";
            this.gbxEquipas.Size = new System.Drawing.Size(179, 100);
            this.gbxEquipas.TabIndex = 16;
            this.gbxEquipas.TabStop = false;
            this.gbxEquipas.Text = "Rank Equipas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "5.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "4.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "3.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "1.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "2.";
            // 
            // gbxCuriosidades
            // 
            this.gbxCuriosidades.Controls.Add(this.list_Curiosidades);
            this.gbxCuriosidades.Location = new System.Drawing.Point(35, 415);
            this.gbxCuriosidades.Name = "gbxCuriosidades";
            this.gbxCuriosidades.Size = new System.Drawing.Size(179, 100);
            this.gbxCuriosidades.TabIndex = 17;
            this.gbxCuriosidades.TabStop = false;
            this.gbxCuriosidades.Text = "Curiosidades";
            // 
            // gbxNoticias
            // 
            this.gbxNoticias.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNoticias.Controls.Add(this.label13);
            this.gbxNoticias.Controls.Add(this.label12);
            this.gbxNoticias.Controls.Add(this.label11);
            this.gbxNoticias.Location = new System.Drawing.Point(245, 270);
            this.gbxNoticias.Name = "gbxNoticias";
            this.gbxNoticias.Size = new System.Drawing.Size(348, 248);
            this.gbxNoticias.TabIndex = 18;
            this.gbxNoticias.TabStop = false;
            this.gbxNoticias.Text = "Informações";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Arcmage é um jogo cartas, inspirado no jogo Magic The Gathering,";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = " com o tema de fantasia em desenvolvimento por uma comunidade ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "de criadores de jogos e jogadores.";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(627, 539);
            this.Controls.Add(this.gbxNoticias);
            this.Controls.Add(this.gbxCuriosidades);
            this.Controls.Add(this.gbxEquipas);
            this.Controls.Add(this.gbxRank);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.rbtnCartas);
            this.Controls.Add(this.rbtnTorneio);
            this.Controls.Add(this.rbtnJogadores);
            this.Controls.Add(this.rbtnArbitro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.menuStripHome);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStripHome;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.gbxRank.ResumeLayout(false);
            this.gbxRank.PerformLayout();
            this.gbxEquipas.ResumeLayout(false);
            this.gbxEquipas.PerformLayout();
            this.gbxCuriosidades.ResumeLayout(false);
            this.gbxNoticias.ResumeLayout(false);
            this.gbxNoticias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rbtnArbitro;
        private System.Windows.Forms.RadioButton rbtnJogadores;
        private System.Windows.Forms.RadioButton rbtnTorneio;
        private System.Windows.Forms.RadioButton rbtnCartas;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.ListView listRank;
        private System.Windows.Forms.ListView listEquipas;
        private System.Windows.Forms.ListView list_Curiosidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxEquipas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxCuriosidades;
        private System.Windows.Forms.GroupBox gbxNoticias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}


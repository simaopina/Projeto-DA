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
            this.gbxNoticias = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStripHome.SuspendLayout();
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
            this.rbtnArbitro.Location = new System.Drawing.Point(25, 229);
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
            this.rbtnJogadores.Location = new System.Drawing.Point(77, 229);
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
            this.rbtnTorneio.Location = new System.Drawing.Point(157, 229);
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
            this.rbtnCartas.Location = new System.Drawing.Point(224, 229);
            this.rbtnCartas.Name = "rbtnCartas";
            this.rbtnCartas.Size = new System.Drawing.Size(55, 17);
            this.rbtnCartas.TabIndex = 5;
            this.rbtnCartas.TabStop = true;
            this.rbtnCartas.Text = "Cartas";
            this.rbtnCartas.UseVisualStyleBackColor = true;
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(25, 203);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(486, 20);
            this.tbxpesquisa.TabIndex = 6;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // gbxNoticias
            // 
            this.gbxNoticias.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxNoticias.Controls.Add(this.label14);
            this.gbxNoticias.Controls.Add(this.label13);
            this.gbxNoticias.Controls.Add(this.label12);
            this.gbxNoticias.Controls.Add(this.label11);
            this.gbxNoticias.Location = new System.Drawing.Point(25, 270);
            this.gbxNoticias.Name = "gbxNoticias";
            this.gbxNoticias.Size = new System.Drawing.Size(568, 248);
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
            this.label11.Location = new System.Drawing.Point(132, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(322, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Arcmage é um jogo cartas, inspirado no jogo Magic The Gathering,";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(129, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = " com o tema de fantasia em desenvolvimento por uma comunidade ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(132, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "de criadores de jogos e jogadores.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(146, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(262, 55);
            this.label14.TabIndex = 3;
            this.label14.Text = "Bem-Vindo";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(627, 539);
            this.Controls.Add(this.gbxNoticias);
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
        private System.Windows.Forms.GroupBox gbxNoticias;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
    }
}


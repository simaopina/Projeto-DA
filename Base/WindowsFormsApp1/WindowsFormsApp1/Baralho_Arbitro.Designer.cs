namespace WindowsFormsApp1
{
    partial class Baralho_Arbitro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baralho_Arbitro));
            this.gbxBaralhoArbitro = new System.Windows.Forms.GroupBox();
            this.listVbaralhoArbitro = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
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
            this.listaBaralhoArbitroUneasyAlliance = new System.Windows.Forms.ImageList(this.components);
            this.listaBaralhoArbitroGaianloveforlife = new System.Windows.Forms.ImageList(this.components);
            this.btnBaralhoGaianArbitro = new System.Windows.Forms.Button();
            this.btnBaralhoUneasyADM = new System.Windows.Forms.Button();
            this.gbxBaralhoArbitro.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBaralhoArbitro
            // 
            this.gbxBaralhoArbitro.Controls.Add(this.listVbaralhoArbitro);
            this.gbxBaralhoArbitro.Location = new System.Drawing.Point(12, 270);
            this.gbxBaralhoArbitro.Name = "gbxBaralhoArbitro";
            this.gbxBaralhoArbitro.Size = new System.Drawing.Size(581, 248);
            this.gbxBaralhoArbitro.TabIndex = 30;
            this.gbxBaralhoArbitro.TabStop = false;
            this.gbxBaralhoArbitro.Text = "Baralho";
            // 
            // listVbaralhoArbitro
            // 
            this.listVbaralhoArbitro.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listVbaralhoArbitro.Location = new System.Drawing.Point(7, 19);
            this.listVbaralhoArbitro.Name = "listVbaralhoArbitro";
            this.listVbaralhoArbitro.Size = new System.Drawing.Size(568, 223);
            this.listVbaralhoArbitro.TabIndex = 0;
            this.listVbaralhoArbitro.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Carta";
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(25, 203);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(486, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(518, 203);
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
            this.menuStripHome.Size = new System.Drawing.Size(636, 24);
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
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // listaBaralhoArbitroUneasyAlliance
            // 
            this.listaBaralhoArbitroUneasyAlliance.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaBaralhoArbitroUneasyAlliance.ImageStream")));
            this.listaBaralhoArbitroUneasyAlliance.TransparentColor = System.Drawing.Color.Transparent;
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(0, "1.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(1, "2.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(2, "3.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(3, "4.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(4, "5.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(5, "6.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(6, "7.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(7, "8.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(8, "9.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(9, "10.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(10, "11.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(11, "12.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(12, "13.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(13, "14.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(14, "15.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(15, "16.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(16, "17.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(17, "18.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(18, "19.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(19, "20.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(20, "21.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(21, "22.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(22, "23.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(23, "24.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(24, "25.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(25, "26.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(26, "27.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(27, "28.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(28, "29.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(29, "30.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(30, "31.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(31, "32.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(32, "33.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(33, "34.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(34, "35.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(35, "36.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(36, "37.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(37, "38.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(38, "39.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(39, "40.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(40, "41.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(41, "42.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(42, "43.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(43, "44.PNG");
            this.listaBaralhoArbitroUneasyAlliance.Images.SetKeyName(44, "45.PNG");
            // 
            // listaBaralhoArbitroGaianloveforlife
            // 
            this.listaBaralhoArbitroGaianloveforlife.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaBaralhoArbitroGaianloveforlife.ImageStream")));
            this.listaBaralhoArbitroGaianloveforlife.TransparentColor = System.Drawing.Color.Transparent;
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(0, "1.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(1, "2.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(2, "3.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(3, "4.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(4, "5.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(5, "6.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(6, "7.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(7, "8.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(8, "9.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(9, "10.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(10, "11.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(11, "12.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(12, "13.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(13, "14.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(14, "15.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(15, "16.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(16, "17.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(17, "18.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(18, "19.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(19, "20.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(20, "21.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(21, "22.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(22, "23.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(23, "24.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(24, "25.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(25, "26.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(26, "27.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(27, "28.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(28, "29.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(29, "30.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(30, "31.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(31, "32.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(32, "33.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(33, "34.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(34, "35.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(35, "36.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(36, "37.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(37, "38.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(38, "39.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(39, "40.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(40, "41.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(41, "42.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(42, "43.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(43, "44.PNG");
            this.listaBaralhoArbitroGaianloveforlife.Images.SetKeyName(44, "45.PNG");
            // 
            // btnBaralhoGaianArbitro
            // 
            this.btnBaralhoGaianArbitro.Location = new System.Drawing.Point(81, 242);
            this.btnBaralhoGaianArbitro.Name = "btnBaralhoGaianArbitro";
            this.btnBaralhoGaianArbitro.Size = new System.Drawing.Size(119, 24);
            this.btnBaralhoGaianArbitro.TabIndex = 32;
            this.btnBaralhoGaianArbitro.Text = "Gaian love for life";
            this.btnBaralhoGaianArbitro.UseVisualStyleBackColor = true;
            this.btnBaralhoGaianArbitro.Click += new System.EventHandler(this.btnBaralhoGaianArbitro_Click);
            // 
            // btnBaralhoUneasyADM
            // 
            this.btnBaralhoUneasyADM.Location = new System.Drawing.Point(357, 242);
            this.btnBaralhoUneasyADM.Name = "btnBaralhoUneasyADM";
            this.btnBaralhoUneasyADM.Size = new System.Drawing.Size(119, 22);
            this.btnBaralhoUneasyADM.TabIndex = 33;
            this.btnBaralhoUneasyADM.Text = "Uneasy Alliance";
            this.btnBaralhoUneasyADM.UseVisualStyleBackColor = true;
            this.btnBaralhoUneasyADM.Click += new System.EventHandler(this.btnBaralhoUneasyADM_Click);
            // 
            // Baralho_Arbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 538);
            this.Controls.Add(this.btnBaralhoUneasyADM);
            this.Controls.Add(this.btnBaralhoGaianArbitro);
            this.Controls.Add(this.gbxBaralhoArbitro);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "Baralho_Arbitro";
            this.Text = "Baralho_Arbitro";
            this.Load += new System.EventHandler(this.Baralho_Arbitro_Load);
            this.gbxBaralhoArbitro.ResumeLayout(false);
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBaralhoArbitro;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ListView listVbaralhoArbitro;
        private System.Windows.Forms.ImageList listaBaralhoArbitroUneasyAlliance;
        private System.Windows.Forms.ImageList listaBaralhoArbitroGaianloveforlife;
        private System.Windows.Forms.Button btnBaralhoGaianArbitro;
        private System.Windows.Forms.Button btnBaralhoUneasyADM;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosADecorrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeamentoDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
    }
}
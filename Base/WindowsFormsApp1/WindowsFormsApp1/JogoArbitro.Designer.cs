namespace WindowsFormsApp1
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
            this.rbtnTeam = new System.Windows.Forms.RadioButton();
            this.rbtnStandard = new System.Windows.Forms.RadioButton();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.listVJogo = new System.Windows.Forms.ListView();
            this.Nº = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxJogosArbitro.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxJogosArbitro
            // 
            this.gbxJogosArbitro.Controls.Add(this.rbtnTeam);
            this.gbxJogosArbitro.Controls.Add(this.rbtnStandard);
            this.gbxJogosArbitro.Controls.Add(this.rbtnTodos);
            this.gbxJogosArbitro.Controls.Add(this.listVJogo);
            this.gbxJogosArbitro.Location = new System.Drawing.Point(25, 246);
            this.gbxJogosArbitro.Name = "gbxJogosArbitro";
            this.gbxJogosArbitro.Size = new System.Drawing.Size(568, 289);
            this.gbxJogosArbitro.TabIndex = 30;
            this.gbxJogosArbitro.TabStop = false;
            this.gbxJogosArbitro.Text = "Jogos Arbitro";
            // 
            // rbtnTeam
            // 
            this.rbtnTeam.AutoSize = true;
            this.rbtnTeam.Location = new System.Drawing.Point(141, 20);
            this.rbtnTeam.Name = "rbtnTeam";
            this.rbtnTeam.Size = new System.Drawing.Size(52, 17);
            this.rbtnTeam.TabIndex = 3;
            this.rbtnTeam.TabStop = true;
            this.rbtnTeam.Text = "Team";
            this.rbtnTeam.UseVisualStyleBackColor = true;
            this.rbtnTeam.CheckedChanged += new System.EventHandler(this.rbtnTeam_CheckedChanged);
            // 
            // rbtnStandard
            // 
            this.rbtnStandard.AutoSize = true;
            this.rbtnStandard.Location = new System.Drawing.Point(67, 20);
            this.rbtnStandard.Name = "rbtnStandard";
            this.rbtnStandard.Size = new System.Drawing.Size(68, 17);
            this.rbtnStandard.TabIndex = 2;
            this.rbtnStandard.TabStop = true;
            this.rbtnStandard.Text = "Standard";
            this.rbtnStandard.UseVisualStyleBackColor = true;
            this.rbtnStandard.CheckedChanged += new System.EventHandler(this.rbtnStandard_CheckedChanged);
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Location = new System.Drawing.Point(6, 20);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 1;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            this.rbtnTodos.CheckedChanged += new System.EventHandler(this.rbtnTodos_CheckedChanged);
            // 
            // listVJogo
            // 
            this.listVJogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nº,
            this.Description,
            this.Hour,
            this.Date});
            this.listVJogo.Location = new System.Drawing.Point(6, 43);
            this.listVJogo.Name = "listVJogo";
            this.listVJogo.Size = new System.Drawing.Size(556, 240);
            this.listVJogo.TabIndex = 0;
            this.listVJogo.UseCompatibleStateImageBehavior = false;
            this.listVJogo.View = System.Windows.Forms.View.Details;
            // 
            // Nº
            // 
            this.Nº.Text = "Nº";
            // 
            // Description
            // 
            this.Description.Text = "Descrição";
            // 
            // Hour
            // 
            this.Hour.Text = "Hora";
            this.Hour.Width = 138;
            // 
            // Date
            // 
            this.Date.Text = "Data";
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(25, 219);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(486, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar pelo numero do jogo...";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(517, 216);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Pesquisar pelo número do jogo:";
            // 
            // JogoArbitro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxJogosArbitro);
            this.Controls.Add(this.tbxpesquisa);
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
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ListView listVJogo;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosADecorrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeamentoDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Nº;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Hour;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.RadioButton rbtnTeam;
        private System.Windows.Forms.RadioButton rbtnStandard;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private System.Windows.Forms.Label label1;
    }
}
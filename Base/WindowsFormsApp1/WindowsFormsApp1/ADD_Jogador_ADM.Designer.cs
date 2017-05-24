namespace WindowsFormsApp1
{
    partial class ADD_Jogador_ADM
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
            this.gbxNovoJogadorADM = new System.Windows.Forms.GroupBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.numupdownIdade = new System.Windows.Forms.NumericUpDown();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.tbxNickName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInserirAvatar = new System.Windows.Forms.Button();
            this.picbxAvatar = new System.Windows.Forms.PictureBox();
            this.gbxJogadores = new System.Windows.Forms.GroupBox();
            this.lbxJogadores = new System.Windows.Forms.ListBox();
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.novaEquipaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.utilizadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxNovoJogadorADM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAvatar)).BeginInit();
            this.gbxJogadores.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxNovoJogadorADM
            // 
            this.gbxNovoJogadorADM.Controls.Add(this.btnRemover);
            this.gbxNovoJogadorADM.Controls.Add(this.btnAlterar);
            this.gbxNovoJogadorADM.Controls.Add(this.numupdownIdade);
            this.gbxNovoJogadorADM.Controls.Add(this.btnCancelar);
            this.gbxNovoJogadorADM.Controls.Add(this.btnInserir);
            this.gbxNovoJogadorADM.Controls.Add(this.tbxNickName);
            this.gbxNovoJogadorADM.Controls.Add(this.tbxEmail);
            this.gbxNovoJogadorADM.Controls.Add(this.tbxNome);
            this.gbxNovoJogadorADM.Controls.Add(this.label14);
            this.gbxNovoJogadorADM.Controls.Add(this.label13);
            this.gbxNovoJogadorADM.Controls.Add(this.label12);
            this.gbxNovoJogadorADM.Controls.Add(this.label11);
            this.gbxNovoJogadorADM.Controls.Add(this.btnInserirAvatar);
            this.gbxNovoJogadorADM.Controls.Add(this.picbxAvatar);
            this.gbxNovoJogadorADM.Location = new System.Drawing.Point(244, 271);
            this.gbxNovoJogadorADM.Name = "gbxNovoJogadorADM";
            this.gbxNovoJogadorADM.Size = new System.Drawing.Size(348, 248);
            this.gbxNovoJogadorADM.TabIndex = 30;
            this.gbxNovoJogadorADM.TabStop = false;
            this.gbxNovoJogadorADM.Text = "Novo Jogador";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(179, 203);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(98, 203);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // numupdownIdade
            // 
            this.numupdownIdade.Location = new System.Drawing.Point(194, 145);
            this.numupdownIdade.Name = "numupdownIdade";
            this.numupdownIdade.Size = new System.Drawing.Size(142, 20);
            this.numupdownIdade.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(17, 203);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // tbxNickName
            // 
            this.tbxNickName.Location = new System.Drawing.Point(194, 113);
            this.tbxNickName.Name = "tbxNickName";
            this.tbxNickName.Size = new System.Drawing.Size(142, 20);
            this.tbxNickName.TabIndex = 8;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(194, 77);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(142, 20);
            this.tbxEmail.TabIndex = 7;
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(194, 46);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(142, 20);
            this.tbxNome.TabIndex = 6;
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(154, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Idade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(131, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "NickName:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Nome:";
            // 
            // btnInserirAvatar
            // 
            this.btnInserirAvatar.Location = new System.Drawing.Point(20, 142);
            this.btnInserirAvatar.Name = "btnInserirAvatar";
            this.btnInserirAvatar.Size = new System.Drawing.Size(100, 23);
            this.btnInserirAvatar.TabIndex = 1;
            this.btnInserirAvatar.Text = "Inserir Imagem";
            this.btnInserirAvatar.UseVisualStyleBackColor = true;
            // 
            // picbxAvatar
            // 
            this.picbxAvatar.Location = new System.Drawing.Point(20, 52);
            this.picbxAvatar.Name = "picbxAvatar";
            this.picbxAvatar.Size = new System.Drawing.Size(100, 83);
            this.picbxAvatar.TabIndex = 0;
            this.picbxAvatar.TabStop = false;
            // 
            // gbxJogadores
            // 
            this.gbxJogadores.Controls.Add(this.lbxJogadores);
            this.gbxJogadores.Location = new System.Drawing.Point(34, 197);
            this.gbxJogadores.Name = "gbxJogadores";
            this.gbxJogadores.Size = new System.Drawing.Size(179, 322);
            this.gbxJogadores.TabIndex = 27;
            this.gbxJogadores.TabStop = false;
            this.gbxJogadores.Text = "Lista de Jogadores";
            // 
            // lbxJogadores
            // 
            this.lbxJogadores.FormattingEnabled = true;
            this.lbxJogadores.Location = new System.Drawing.Point(7, 20);
            this.lbxJogadores.Name = "lbxJogadores";
            this.lbxJogadores.Size = new System.Drawing.Size(166, 290);
            this.lbxJogadores.TabIndex = 0;
            this.lbxJogadores.SelectedIndexChanged += new System.EventHandler(this.lbxJogadores_SelectedIndexChanged);
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(244, 204);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(266, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(517, 204);
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
            this.baralhoToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.terminarSessãoToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(632, 24);
            this.menuStripHome.TabIndex = 20;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // baralhoToolStripMenuItem
            // 
            this.baralhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baralhoToolStripMenuItem1,
            this.cartasToolStripMenuItem,
            this.toolStripSeparator1,
            this.cartasToolStripMenuItem1});
            this.baralhoToolStripMenuItem.Name = "baralhoToolStripMenuItem";
            this.baralhoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.baralhoToolStripMenuItem.Text = "Baralho";
            // 
            // baralhoToolStripMenuItem1
            // 
            this.baralhoToolStripMenuItem1.Name = "baralhoToolStripMenuItem1";
            this.baralhoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.baralhoToolStripMenuItem1.Text = "Baralho";
            this.baralhoToolStripMenuItem1.Click += new System.EventHandler(this.baralhoToolStripMenuItem1_Click);
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cartasToolStripMenuItem.Text = "Editar Baralho";
            this.cartasToolStripMenuItem.Click += new System.EventHandler(this.cartasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // cartasToolStripMenuItem1
            // 
            this.cartasToolStripMenuItem1.Name = "cartasToolStripMenuItem1";
            this.cartasToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cartasToolStripMenuItem1.Text = "Cartas";
            this.cartasToolStripMenuItem1.Click += new System.EventHandler(this.cartasToolStripMenuItem1_Click);
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarNovoToolStripMenuItem,
            this.toolStripSeparator4,
            this.novaEquipaToolStripMenuItem1,
            this.toolStripSeparator5,
            this.utilizadoresToolStripMenuItem1});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.jogadoresToolStripMenuItem.Text = "Gestão";
            // 
            // adicionarNovoToolStripMenuItem
            // 
            this.adicionarNovoToolStripMenuItem.Name = "adicionarNovoToolStripMenuItem";
            this.adicionarNovoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.adicionarNovoToolStripMenuItem.Text = "Jogador";
            this.adicionarNovoToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torneioIndividualToolStripMenuItem,
            this.torneioEquipaToolStripMenuItem});
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.signOutToolStripMenuItem.Text = "Torneios";
            // 
            // torneioIndividualToolStripMenuItem
            // 
            this.torneioIndividualToolStripMenuItem.Name = "torneioIndividualToolStripMenuItem";
            this.torneioIndividualToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.torneioIndividualToolStripMenuItem.Text = "Torneio Individual";
            this.torneioIndividualToolStripMenuItem.Click += new System.EventHandler(this.torneioIndividualToolStripMenuItem_Click);
            // 
            // torneioEquipaToolStripMenuItem
            // 
            this.torneioEquipaToolStripMenuItem.Name = "torneioEquipaToolStripMenuItem";
            this.torneioEquipaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.torneioEquipaToolStripMenuItem.Text = "Torneio Equipa";
            this.torneioEquipaToolStripMenuItem.Click += new System.EventHandler(this.torneioEquipaToolStripMenuItem_Click);
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar Sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // novaEquipaToolStripMenuItem1
            // 
            this.novaEquipaToolStripMenuItem1.Name = "novaEquipaToolStripMenuItem1";
            this.novaEquipaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.novaEquipaToolStripMenuItem1.Text = "Nova Equipa";
            this.novaEquipaToolStripMenuItem1.Click += new System.EventHandler(this.novaEquipaToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // utilizadoresToolStripMenuItem1
            // 
            this.utilizadoresToolStripMenuItem1.Name = "utilizadoresToolStripMenuItem1";
            this.utilizadoresToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.utilizadoresToolStripMenuItem1.Text = "Utilizadores";
            this.utilizadoresToolStripMenuItem1.Click += new System.EventHandler(this.utilizadoresToolStripMenuItem1_Click);
            // 
            // ADD_Jogador_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 540);
            this.Controls.Add(this.gbxNovoJogadorADM);
            this.Controls.Add(this.gbxJogadores);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "ADD_Jogador_ADM";
            this.Text = "ADD_Jogador_ADM";
            this.Load += new System.EventHandler(this.ADD_Jogador_ADM_Load);
            this.gbxNovoJogadorADM.ResumeLayout(false);
            this.gbxNovoJogadorADM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAvatar)).EndInit();
            this.gbxJogadores.ResumeLayout(false);
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNovoJogadorADM;
        private System.Windows.Forms.GroupBox gbxJogadores;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.PictureBox picbxAvatar;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox tbxNickName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInserirAvatar;
        private System.Windows.Forms.NumericUpDown numupdownIdade;
        private System.Windows.Forms.ListBox lbxJogadores;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioEquipaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem novaEquipaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem1;
    }
}
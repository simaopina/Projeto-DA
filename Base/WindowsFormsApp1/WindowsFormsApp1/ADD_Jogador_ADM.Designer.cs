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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_Jogador_ADM));
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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.caminhoImagem = new System.Windows.Forms.OpenFileDialog();
            this.gbxNovoJogadorADM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAvatar)).BeginInit();
            this.gbxJogadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStripHome.SuspendLayout();
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
            this.btnInserirAvatar.Click += new System.EventHandler(this.btnInserirAvatar_Click);
            // 
            // picbxAvatar
            // 
            this.picbxAvatar.Location = new System.Drawing.Point(20, 52);
            this.picbxAvatar.Name = "picbxAvatar";
            this.picbxAvatar.Size = new System.Drawing.Size(100, 83);
            this.picbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.menuStripHome.Size = new System.Drawing.Size(632, 24);
            this.menuStripHome.TabIndex = 32;
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
            this.editarBaralhoToolStripMenuItem.Click += new System.EventHandler(this.editarBaralhoToolStripMenuItem_Click);
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
            this.novaEquipaToolStripMenuItem.Click += new System.EventHandler(this.novaEquipaToolStripMenuItem_Click_1);
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
            this.torneioIndividualToolStripMenuItem.Click += new System.EventHandler(this.torneioIndividualToolStripMenuItem_Click_1);
            // 
            // torneioEquipaToolStripMenuItem
            // 
            this.torneioEquipaToolStripMenuItem.Name = "torneioEquipaToolStripMenuItem";
            this.torneioEquipaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.torneioEquipaToolStripMenuItem.Text = "Jogo Equipa";
            this.torneioEquipaToolStripMenuItem.Click += new System.EventHandler(this.torneioEquipaToolStripMenuItem_Click_1);
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
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpar.Location = new System.Drawing.Point(554, 242);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(38, 23);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // caminhoImagem
            // 
            this.caminhoImagem.FileName = "openFileDialog1";
            // 
            // ADD_Jogador_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 540);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.menuStripHome);
            this.Controls.Add(this.gbxNovoJogadorADM);
            this.Controls.Add(this.gbxJogadores);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ADD_Jogador_ADM";
            this.Text = "ADD_Jogador_ADM";
            this.Load += new System.EventHandler(this.ADD_Jogador_ADM_Load);
            this.gbxNovoJogadorADM.ResumeLayout(false);
            this.gbxNovoJogadorADM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxAvatar)).EndInit();
            this.gbxJogadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxNovoJogadorADM;
        private System.Windows.Forms.GroupBox gbxJogadores;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picbxAvatar;
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
        private System.Windows.Forms.ToolStripMenuItem listaDeJogosToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.OpenFileDialog caminhoImagem;
    }
}
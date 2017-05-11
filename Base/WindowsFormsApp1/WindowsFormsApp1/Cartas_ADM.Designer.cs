namespace WindowsFormsApp1
{
    partial class Cartas_ADM
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
            this.gbxCartasADM = new System.Windows.Forms.GroupBox();
            this.gbxCuriosidades = new System.Windows.Forms.GroupBox();
            this.list_Curiosidades = new System.Windows.Forms.ListView();
            this.gbxEquipas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listEquipas = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxRank = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listRank = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.torneiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtFacao = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtLealdade = new System.Windows.Forms.TextBox();
            this.txtcusto = new System.Windows.Forms.TextBox();
            this.txtRegras = new System.Windows.Forms.TextBox();
            this.txtAtaque = new System.Windows.Forms.TextBox();
            this.txtImagem = new System.Windows.Forms.TextBox();
            this.txtDefesa = new System.Windows.Forms.TextBox();
            this.btAdicionarCartas = new System.Windows.Forms.Button();
            this.gbxCartasADM.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCartas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCartasADM
            // 
            this.gbxCartasADM.Controls.Add(this.btAlterarCarta);
            this.gbxCartasADM.Controls.Add(this.btAdicionarCartas);
            this.gbxCartasADM.Controls.Add(this.txtDefesa);
            this.gbxCartasADM.Controls.Add(this.txtImagem);
            this.gbxCartasADM.Controls.Add(this.txtAtaque);
            this.gbxCartasADM.Controls.Add(this.txtRegras);
            this.gbxCartasADM.Controls.Add(this.txtcusto);
            this.gbxCartasADM.Controls.Add(this.txtLealdade);
            this.gbxCartasADM.Controls.Add(this.txtTipo);
            this.gbxCartasADM.Controls.Add(this.txtFacao);
            this.gbxCartasADM.Controls.Add(this.txtNome);
            this.gbxCartasADM.Controls.Add(this.label19);
            this.gbxCartasADM.Controls.Add(this.label18);
            this.gbxCartasADM.Controls.Add(this.label17);
            this.gbxCartasADM.Controls.Add(this.label16);
            this.gbxCartasADM.Controls.Add(this.label15);
            this.gbxCartasADM.Controls.Add(this.label14);
            this.gbxCartasADM.Controls.Add(this.label13);
            this.gbxCartasADM.Controls.Add(this.label12);
            this.gbxCartasADM.Controls.Add(this.label11);
            this.gbxCartasADM.Location = new System.Drawing.Point(327, 253);
            this.gbxCartasADM.Name = "gbxCartasADM";
            this.gbxCartasADM.Size = new System.Drawing.Size(278, 289);
            this.gbxCartasADM.TabIndex = 30;
            this.gbxCartasADM.TabStop = false;
            this.gbxCartasADM.Text = "Cartas Administrador";
            // 
            // gbxCuriosidades
            // 
            this.btAlterarCarta.Location = new System.Drawing.Point(200, 52);
            this.btAlterarCarta.Name = "btAlterarCarta";
            this.btAlterarCarta.Size = new System.Drawing.Size(75, 23);
            this.btAlterarCarta.TabIndex = 19;
            this.btAlterarCarta.Text = "Alterar";
            this.btAlterarCarta.UseVisualStyleBackColor = true;
            this.btAlterarCarta.Click += new System.EventHandler(this.btAlterarCarta_Click);
            // 
            // btAdicionarCartas
            // 
            this.btAdicionarCartas.Location = new System.Drawing.Point(200, 180);
            this.btAdicionarCartas.Name = "btAdicionarCartas";
            this.btAdicionarCartas.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarCartas.TabIndex = 18;
            this.btAdicionarCartas.Text = "Adicionar";
            this.btAdicionarCartas.UseVisualStyleBackColor = true;
            this.btAdicionarCartas.Click += new System.EventHandler(this.btAdicionarCartas_Click);
            // 
            // txtDefesa
            // 
            this.txtDefesa.Location = new System.Drawing.Point(71, 246);
            this.txtDefesa.Name = "txtDefesa";
            this.txtDefesa.Size = new System.Drawing.Size(100, 20);
            this.txtDefesa.TabIndex = 17;
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(62, 214);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(100, 20);
            this.txtImagem.TabIndex = 16;
            // 
            // txtAtaque
            // 
            this.txtAtaque.Location = new System.Drawing.Point(62, 188);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.Size = new System.Drawing.Size(100, 20);
            this.txtAtaque.TabIndex = 15;
            // 
            // txtRegras
            // 
            this.txtRegras.Location = new System.Drawing.Point(75, 162);
            this.txtRegras.Name = "txtRegras";
            this.txtRegras.Size = new System.Drawing.Size(100, 20);
            this.txtRegras.TabIndex = 14;
            // 
            // txtcusto
            // 
            this.txtcusto.Location = new System.Drawing.Point(62, 139);
            this.txtcusto.Name = "txtcusto";
            this.txtcusto.Size = new System.Drawing.Size(100, 20);
            this.txtcusto.TabIndex = 13;
            // 
            // txtLealdade
            // 
            this.txtLealdade.Location = new System.Drawing.Point(75, 107);
            this.txtLealdade.Name = "txtLealdade";
            this.txtLealdade.Size = new System.Drawing.Size(100, 20);
            this.txtLealdade.TabIndex = 12;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(62, 78);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // txtFacao
            // 
            this.txtFacao.Location = new System.Drawing.Point(62, 48);
            this.txtFacao.Name = "txtFacao";
            this.txtFacao.Size = new System.Drawing.Size(100, 20);
            this.txtFacao.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "imagem";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 249);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Defesa";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Ataque";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Regras";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "custo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "lealdade";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fação";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome";
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(245, 204);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(266, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(518, 204);
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
            // 
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.permissõesToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.torneiosToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(637, 24);
            this.menuStripHome.TabIndex = 20;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baralhoToolStripMenuItem,
            this.cartasToolStripMenuItem,
            this.toolStripSeparator1,
            this.cartasToolStripMenuItem1});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.loginToolStripMenuItem.Text = "Baralho";
            // 
            // baralhoToolStripMenuItem
            // 
            this.baralhoToolStripMenuItem.Name = "baralhoToolStripMenuItem";
            this.baralhoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.baralhoToolStripMenuItem.Text = "Baralho";
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cartasToolStripMenuItem.Text = "Editar Baralho";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // cartasToolStripMenuItem1
            // 
            this.cartasToolStripMenuItem1.Name = "cartasToolStripMenuItem1";
            this.cartasToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.cartasToolStripMenuItem1.Text = "Cartas";
            // 
            // torneiosToolStripMenuItem
            // 
            this.torneiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.addJogadorToolStripMenuItem});
            this.torneiosToolStripMenuItem.Name = "torneiosToolStripMenuItem";
            this.torneiosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.torneiosToolStripMenuItem.Text = "Jogadores";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // addJogadorToolStripMenuItem
            // 
            this.addJogadorToolStripMenuItem.Name = "addJogadorToolStripMenuItem";
            this.addJogadorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addJogadorToolStripMenuItem.Text = "Add jogador";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.signOutToolStripMenuItem.Text = "Terminar Sessão";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fação";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tipo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "lealdade";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "custo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Regras";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Ataque";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(196, 215);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Defesa";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "imagem";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(62, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtFacao
            // 
            this.txtFacao.Location = new System.Drawing.Point(62, 48);
            this.txtFacao.Name = "txtFacao";
            this.txtFacao.Size = new System.Drawing.Size(100, 20);
            this.txtFacao.TabIndex = 10;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(62, 78);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // txtLealdade
            // 
            this.txtLealdade.Location = new System.Drawing.Point(75, 107);
            this.txtLealdade.Name = "txtLealdade";
            this.txtLealdade.Size = new System.Drawing.Size(100, 20);
            this.txtLealdade.TabIndex = 12;
            // 
            // txtcusto
            // 
            this.txtcusto.Location = new System.Drawing.Point(62, 139);
            this.txtcusto.Name = "txtcusto";
            this.txtcusto.Size = new System.Drawing.Size(100, 20);
            this.txtcusto.TabIndex = 13;
            // 
            // txtRegras
            // 
            this.txtRegras.Location = new System.Drawing.Point(75, 162);
            this.txtRegras.Name = "txtRegras";
            this.txtRegras.Size = new System.Drawing.Size(100, 20);
            this.txtRegras.TabIndex = 14;
            // 
            // txtAtaque
            // 
            this.txtAtaque.Location = new System.Drawing.Point(62, 188);
            this.txtAtaque.Name = "txtAtaque";
            this.txtAtaque.Size = new System.Drawing.Size(100, 20);
            this.txtAtaque.TabIndex = 15;
            // 
            // txtImagem
            // 
            this.txtImagem.Location = new System.Drawing.Point(62, 214);
            this.txtImagem.Name = "txtImagem";
            this.txtImagem.Size = new System.Drawing.Size(100, 20);
            this.txtImagem.TabIndex = 16;
            // 
            // txtDefesa
            // 
            this.txtDefesa.Location = new System.Drawing.Point(242, 212);
            this.txtDefesa.Name = "txtDefesa";
            this.txtDefesa.Size = new System.Drawing.Size(100, 20);
            this.txtDefesa.TabIndex = 17;
            // 
            // btAdicionarCartas
            // 
            this.btAdicionarCartas.Location = new System.Drawing.Point(218, 69);
            this.btAdicionarCartas.Name = "btAdicionarCartas";
            this.btAdicionarCartas.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarCartas.TabIndex = 18;
            this.btAdicionarCartas.Text = "button1";
            this.btAdicionarCartas.UseVisualStyleBackColor = true;
            this.btAdicionarCartas.Click += new System.EventHandler(this.btAdicionarCartas_Click);
            // 
            // Cartas_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 540);
            this.Controls.Add(this.DataGridCartas);
            this.Controls.Add(this.gbxCartasADM);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "Cartas_ADM";
            this.Text = "Cartas_ADM";
            this.Load += new System.EventHandler(this.Cartas_ADM_Load);
            this.gbxCartasADM.ResumeLayout(false);
            this.gbxCartasADM.PerformLayout();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCartas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCartasADM;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem torneiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Button btAdicionarCartas;
        private System.Windows.Forms.TextBox txtDefesa;
        private System.Windows.Forms.TextBox txtImagem;
        private System.Windows.Forms.TextBox txtAtaque;
        private System.Windows.Forms.TextBox txtRegras;
        private System.Windows.Forms.TextBox txtcusto;
        private System.Windows.Forms.TextBox txtLealdade;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtFacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private BaseDadosDataSet baseDadosDataSet;
        private System.Windows.Forms.BindingSource cardSetBindingSource;
        private BaseDadosDataSetTableAdapters.CardSetTableAdapter cardSetTableAdapter;
        private System.Windows.Forms.Button btAlterarCarta;
        private System.Windows.Forms.DataGridView DataGridCartas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
    }
}
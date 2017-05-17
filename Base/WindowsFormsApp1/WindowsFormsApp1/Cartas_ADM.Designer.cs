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
            this.LinkLabelImagem = new System.Windows.Forms.LinkLabel();
            this.NumericDefesa = new System.Windows.Forms.NumericUpDown();
            this.NumericAtaque = new System.Windows.Forms.NumericUpDown();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btAlterarCarta = new System.Windows.Forms.Button();
            this.btAdicionarCartas = new System.Windows.Forms.Button();
            this.txtRegras = new System.Windows.Forms.TextBox();
            this.txtcusto = new System.Windows.Forms.TextBox();
            this.txtLealdade = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtFacao = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.cardSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSet = new WindowsFormsApp1.BaseDadosDataSet();
            this.cardSetTableAdapter = new WindowsFormsApp1.BaseDadosDataSetTableAdapters.CardSetTableAdapter();
            this.DataGridCartas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSet_Cards = new WindowsFormsApp1.BaseDadosDataSet_Cards();
            this.cardSetTableAdapter1 = new WindowsFormsApp1.BaseDadosDataSet_CardsTableAdapters.CardSetTableAdapter();
            this.gbxCartasADM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericDefesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAtaque)).BeginInit();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet_Cards)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxCartasADM
            // 
            this.gbxCartasADM.Controls.Add(this.LinkLabelImagem);
            this.gbxCartasADM.Controls.Add(this.NumericDefesa);
            this.gbxCartasADM.Controls.Add(this.NumericAtaque);
            this.gbxCartasADM.Controls.Add(this.btnRemover);
            this.gbxCartasADM.Controls.Add(this.btAlterarCarta);
            this.gbxCartasADM.Controls.Add(this.btAdicionarCartas);
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
            this.gbxCartasADM.Location = new System.Drawing.Point(25, 369);
            this.gbxCartasADM.Name = "gbxCartasADM";
            this.gbxCartasADM.Size = new System.Drawing.Size(580, 172);
            this.gbxCartasADM.TabIndex = 30;
            this.gbxCartasADM.TabStop = false;
            this.gbxCartasADM.Text = "Cartas";
            // 
            // LinkLabelImagem
            // 
            this.LinkLabelImagem.AutoSize = true;
            this.LinkLabelImagem.Location = new System.Drawing.Point(429, 77);
            this.LinkLabelImagem.Name = "LinkLabelImagem";
            this.LinkLabelImagem.Size = new System.Drawing.Size(60, 13);
            this.LinkLabelImagem.TabIndex = 24;
            this.LinkLabelImagem.TabStop = true;
            this.LinkLabelImagem.Text = "Adicionar...";
            // 
            // NumericDefesa
            // 
            this.NumericDefesa.Location = new System.Drawing.Point(429, 104);
            this.NumericDefesa.Name = "NumericDefesa";
            this.NumericDefesa.Size = new System.Drawing.Size(47, 20);
            this.NumericDefesa.TabIndex = 23;
            // 
            // NumericAtaque
            // 
            this.NumericAtaque.Location = new System.Drawing.Point(429, 46);
            this.NumericAtaque.Name = "NumericAtaque";
            this.NumericAtaque.Size = new System.Drawing.Size(47, 20);
            this.NumericAtaque.TabIndex = 21;
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(314, 137);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 20;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btAlterarCarta
            // 
            this.btAlterarCarta.Location = new System.Drawing.Point(493, 136);
            this.btAlterarCarta.Name = "btAlterarCarta";
            this.btAlterarCarta.Size = new System.Drawing.Size(75, 23);
            this.btAlterarCarta.TabIndex = 19;
            this.btAlterarCarta.Text = "Alterar";
            this.btAlterarCarta.UseVisualStyleBackColor = true;
            this.btAlterarCarta.Click += new System.EventHandler(this.btAlterarCarta_Click);
            // 
            // btAdicionarCartas
            // 
            this.btAdicionarCartas.Location = new System.Drawing.Point(395, 137);
            this.btAdicionarCartas.Name = "btAdicionarCartas";
            this.btAdicionarCartas.Size = new System.Drawing.Size(75, 23);
            this.btAdicionarCartas.TabIndex = 18;
            this.btAdicionarCartas.Text = "Adicionar";
            this.btAdicionarCartas.UseVisualStyleBackColor = true;
            this.btAdicionarCartas.Click += new System.EventHandler(this.btAdicionarCartas_Click);
            // 
            // txtRegras
            // 
            this.txtRegras.Location = new System.Drawing.Point(429, 19);
            this.txtRegras.Name = "txtRegras";
            this.txtRegras.Size = new System.Drawing.Size(100, 20);
            this.txtRegras.TabIndex = 14;
            // 
            // txtcusto
            // 
            this.txtcusto.Location = new System.Drawing.Point(75, 136);
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
            this.txtTipo.Location = new System.Drawing.Point(75, 78);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 11;
            // 
            // txtFacao
            // 
            this.txtFacao.Location = new System.Drawing.Point(75, 48);
            this.txtFacao.Name = "txtFacao";
            this.txtFacao.Size = new System.Drawing.Size(100, 20);
            this.txtFacao.TabIndex = 10;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(372, 72);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Imagem:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(372, 106);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Defesa:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(372, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Ataque:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(372, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Regras:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Custo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Lealdade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Tipo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Fação:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nome:";
            // 
            // tbxpesquisa
            // 
            this.tbxpesquisa.Location = new System.Drawing.Point(25, 204);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(486, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar...";
            this.tbxpesquisa.TextChanged += new System.EventHandler(this.tbxpesquisa_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(518, 204);
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
            this.permissõesToolStripMenuItem.Click += new System.EventHandler(this.permissõesToolStripMenuItem_Click);
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
            this.baralhoToolStripMenuItem.Click += new System.EventHandler(this.baralhoToolStripMenuItem_Click);
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cartasToolStripMenuItem.Text = "Editar Baralho";
            this.cartasToolStripMenuItem.Click += new System.EventHandler(this.cartasToolStripMenuItem_Click);
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
            this.cartasToolStripMenuItem1.Click += new System.EventHandler(this.cartasToolStripMenuItem1_Click);
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
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // addJogadorToolStripMenuItem
            // 
            this.addJogadorToolStripMenuItem.Name = "addJogadorToolStripMenuItem";
            this.addJogadorToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addJogadorToolStripMenuItem.Text = "Add jogador";
            this.addJogadorToolStripMenuItem.Click += new System.EventHandler(this.addJogadorToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.signOutToolStripMenuItem.Text = "Terminar Sessão";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
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
            // cardSetBindingSource
            // 
            this.cardSetBindingSource.DataMember = "CardSet";
            this.cardSetBindingSource.DataSource = this.baseDadosDataSet;
            // 
            // baseDadosDataSet
            // 
            this.baseDadosDataSet.DataSetName = "BaseDadosDataSet";
            this.baseDadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardSetTableAdapter
            // 
            this.cardSetTableAdapter.ClearBeforeFill = true;
            // 
            // DataGridCartas
            // 
            this.DataGridCartas.AllowUserToAddRows = false;
            this.DataGridCartas.AllowUserToDeleteRows = false;
            this.DataGridCartas.AutoGenerateColumns = false;
            this.DataGridCartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCartas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.factionDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.loyaltyDataGridViewTextBoxColumn,
            this.defenseDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.ruleTextDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn});
            this.DataGridCartas.DataSource = this.cardSetBindingSource1;
            this.DataGridCartas.Location = new System.Drawing.Point(25, 253);
            this.DataGridCartas.Name = "DataGridCartas";
            this.DataGridCartas.ReadOnly = true;
            this.DataGridCartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCartas.Size = new System.Drawing.Size(568, 98);
            this.DataGridCartas.TabIndex = 32;
            this.DataGridCartas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factionDataGridViewTextBoxColumn
            // 
            this.factionDataGridViewTextBoxColumn.DataPropertyName = "Faction";
            this.factionDataGridViewTextBoxColumn.HeaderText = "Faction";
            this.factionDataGridViewTextBoxColumn.Name = "factionDataGridViewTextBoxColumn";
            this.factionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loyaltyDataGridViewTextBoxColumn
            // 
            this.loyaltyDataGridViewTextBoxColumn.DataPropertyName = "Loyalty";
            this.loyaltyDataGridViewTextBoxColumn.HeaderText = "Loyalty";
            this.loyaltyDataGridViewTextBoxColumn.Name = "loyaltyDataGridViewTextBoxColumn";
            this.loyaltyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defenseDataGridViewTextBoxColumn
            // 
            this.defenseDataGridViewTextBoxColumn.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn.HeaderText = "Defense";
            this.defenseDataGridViewTextBoxColumn.Name = "defenseDataGridViewTextBoxColumn";
            this.defenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ruleTextDataGridViewTextBoxColumn
            // 
            this.ruleTextDataGridViewTextBoxColumn.DataPropertyName = "RuleText";
            this.ruleTextDataGridViewTextBoxColumn.HeaderText = "RuleText";
            this.ruleTextDataGridViewTextBoxColumn.Name = "ruleTextDataGridViewTextBoxColumn";
            this.ruleTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            this.attackDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardSetBindingSource1
            // 
            this.cardSetBindingSource1.DataMember = "CardSet";
            this.cardSetBindingSource1.DataSource = this.baseDadosDataSet_Cards;
            // 
            // baseDadosDataSet_Cards
            // 
            this.baseDadosDataSet_Cards.DataSetName = "BaseDadosDataSet_Cards";
            this.baseDadosDataSet_Cards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardSetTableAdapter1
            // 
            this.cardSetTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.NumericDefesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAtaque)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet_Cards)).EndInit();
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
        private BaseDadosDataSet_Cards baseDadosDataSet_Cards;
        private System.Windows.Forms.BindingSource cardSetBindingSource1;
        private BaseDadosDataSet_CardsTableAdapters.CardSetTableAdapter cardSetTableAdapter1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.NumericUpDown NumericDefesa;
        private System.Windows.Forms.NumericUpDown NumericAtaque;
        private System.Windows.Forms.LinkLabel LinkLabelImagem;
    }
}
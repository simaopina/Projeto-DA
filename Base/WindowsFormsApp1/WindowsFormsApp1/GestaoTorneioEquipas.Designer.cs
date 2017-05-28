namespace WindowsFormsApp1
{
    partial class GestaoTorneioEquipas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxGestaoTorneios = new System.Windows.Forms.GroupBox();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.datetimeHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimeData = new System.Windows.Forms.DateTimePicker();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnPesquisarEquipa2 = new System.Windows.Forms.Button();
            this.btnPesquisarEquipa1 = new System.Windows.Forms.Button();
            this.tbxEquipa1 = new System.Windows.Forms.TextBox();
            this.gbxJogador2 = new System.Windows.Forms.GroupBox();
            this.tbxEquipa2 = new System.Windows.Forms.TextBox();
            this.gbxJogador1 = new System.Windows.Forms.GroupBox();
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
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridEquipa1 = new System.Windows.Forms.DataGridView();
            this.dataGridEquipa2 = new System.Windows.Forms.DataGridView();
            this.baseDadosDataSetTeamSet = new WindowsFormsApp1.BaseDadosDataSetTeamSet();
            this.teamSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamSetTableAdapter = new WindowsFormsApp1.BaseDadosDataSetTeamSetTableAdapters.TeamSetTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseDadosDataSetTeamSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGestaoTorneios.SuspendLayout();
            this.gbxJogador2.SuspendLayout();
            this.gbxJogador1.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipa2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetTeamSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetTeamSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(132, 157);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Descrição";
            // 
            // gbxGestaoTorneios
            // 
            this.gbxGestaoTorneios.Controls.Add(this.btnCancelar);
            this.gbxGestaoTorneios.Controls.Add(this.label4);
            this.gbxGestaoTorneios.Controls.Add(this.tbxDescricao);
            this.gbxGestaoTorneios.Controls.Add(this.label3);
            this.gbxGestaoTorneios.Controls.Add(this.tbxNome);
            this.gbxGestaoTorneios.Controls.Add(this.datetimeHora);
            this.gbxGestaoTorneios.Controls.Add(this.label2);
            this.gbxGestaoTorneios.Controls.Add(this.label1);
            this.gbxGestaoTorneios.Controls.Add(this.datetimeData);
            this.gbxGestaoTorneios.Controls.Add(this.btnCriar);
            this.gbxGestaoTorneios.Location = new System.Drawing.Point(23, 341);
            this.gbxGestaoTorneios.Name = "gbxGestaoTorneios";
            this.gbxGestaoTorneios.Size = new System.Drawing.Size(580, 193);
            this.gbxGestaoTorneios.TabIndex = 44;
            this.gbxGestaoTorneios.TabStop = false;
            this.gbxGestaoTorneios.Text = "Gestão Equipa - Jogos";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(309, 55);
            this.tbxDescricao.Multiline = true;
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(246, 99);
            this.tbxDescricao.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nome";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(105, 35);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(183, 20);
            this.tbxNome.TabIndex = 43;
            // 
            // datetimeHora
            // 
            this.datetimeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimeHora.Location = new System.Drawing.Point(105, 114);
            this.datetimeHora.Name = "datetimeHora";
            this.datetimeHora.Size = new System.Drawing.Size(121, 20);
            this.datetimeHora.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Data";
            // 
            // datetimeData
            // 
            this.datetimeData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetimeData.Location = new System.Drawing.Point(105, 77);
            this.datetimeData.Name = "datetimeData";
            this.datetimeData.Size = new System.Drawing.Size(121, 20);
            this.datetimeData.TabIndex = 39;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(50, 157);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 38;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarEquipa2
            // 
            this.btnPesquisarEquipa2.Location = new System.Drawing.Point(191, 29);
            this.btnPesquisarEquipa2.Name = "btnPesquisarEquipa2";
            this.btnPesquisarEquipa2.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarEquipa2.TabIndex = 36;
            this.btnPesquisarEquipa2.Text = "Pesquisar";
            this.btnPesquisarEquipa2.UseVisualStyleBackColor = true;
            this.btnPesquisarEquipa2.Click += new System.EventHandler(this.btnPesquisarEquipa2_Click);
            // 
            // btnPesquisarEquipa1
            // 
            this.btnPesquisarEquipa1.Location = new System.Drawing.Point(192, 30);
            this.btnPesquisarEquipa1.Name = "btnPesquisarEquipa1";
            this.btnPesquisarEquipa1.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarEquipa1.TabIndex = 35;
            this.btnPesquisarEquipa1.Text = "Pesquisar";
            this.btnPesquisarEquipa1.UseVisualStyleBackColor = true;
            this.btnPesquisarEquipa1.Click += new System.EventHandler(this.btnPesquisarEquipa1_Click);
            // 
            // tbxEquipa1
            // 
            this.tbxEquipa1.Location = new System.Drawing.Point(6, 30);
            this.tbxEquipa1.Name = "tbxEquipa1";
            this.tbxEquipa1.Size = new System.Drawing.Size(179, 20);
            this.tbxEquipa1.TabIndex = 34;
            this.tbxEquipa1.Text = "Pesquisar Equipa 1";
            // 
            // gbxJogador2
            // 
            this.gbxJogador2.Controls.Add(this.dataGridEquipa2);
            this.gbxJogador2.Controls.Add(this.btnPesquisarEquipa2);
            this.gbxJogador2.Controls.Add(this.tbxEquipa2);
            this.gbxJogador2.Location = new System.Drawing.Point(326, 190);
            this.gbxJogador2.Name = "gbxJogador2";
            this.gbxJogador2.Size = new System.Drawing.Size(277, 144);
            this.gbxJogador2.TabIndex = 43;
            this.gbxJogador2.TabStop = false;
            this.gbxJogador2.Text = "Equipa 2";
            // 
            // tbxEquipa2
            // 
            this.tbxEquipa2.Location = new System.Drawing.Point(6, 29);
            this.tbxEquipa2.Name = "tbxEquipa2";
            this.tbxEquipa2.Size = new System.Drawing.Size(178, 20);
            this.tbxEquipa2.TabIndex = 35;
            this.tbxEquipa2.Text = "Pesquisar Equipa 2";
            // 
            // gbxJogador1
            // 
            this.gbxJogador1.Controls.Add(this.dataGridEquipa1);
            this.gbxJogador1.Controls.Add(this.btnPesquisarEquipa1);
            this.gbxJogador1.Controls.Add(this.tbxEquipa1);
            this.gbxJogador1.Location = new System.Drawing.Point(23, 189);
            this.gbxJogador1.Name = "gbxJogador1";
            this.gbxJogador1.Size = new System.Drawing.Size(276, 145);
            this.gbxJogador1.TabIndex = 42;
            this.gbxJogador1.TabStop = false;
            this.gbxJogador1.Text = "Equipa 1";
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
            this.menuStripHome.Size = new System.Drawing.Size(628, 24);
            this.menuStripHome.TabIndex = 40;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            this.baralhoToolStripMenuItem1.Click += new System.EventHandler(this.baralhoToolStripMenuItem1_Click);
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
            this.cartasToolStripMenuItem.Click += new System.EventHandler(this.cartasToolStripMenuItem_Click);
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
            this.novoJogadorToolStripMenuItem.Click += new System.EventHandler(this.novoJogadorToolStripMenuItem_Click);
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
            this.torneioEquipaToolStripMenuItem});
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
            this.pictureBox1.Location = new System.Drawing.Point(23, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridEquipa1
            // 
            this.dataGridEquipa1.AutoGenerateColumns = false;
            this.dataGridEquipa1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipa1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.dataGridEquipa1.DataSource = this.teamSetBindingSource;
            this.dataGridEquipa1.Location = new System.Drawing.Point(6, 57);
            this.dataGridEquipa1.Name = "dataGridEquipa1";
            this.dataGridEquipa1.Size = new System.Drawing.Size(260, 77);
            this.dataGridEquipa1.TabIndex = 37;
            // 
            // dataGridEquipa2
            // 
            this.dataGridEquipa2.AutoGenerateColumns = false;
            this.dataGridEquipa2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipa2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridEquipa2.DataSource = this.teamSetBindingSource1;
            this.dataGridEquipa2.Location = new System.Drawing.Point(7, 56);
            this.dataGridEquipa2.Name = "dataGridEquipa2";
            this.dataGridEquipa2.Size = new System.Drawing.Size(259, 77);
            this.dataGridEquipa2.TabIndex = 37;
            // 
            // baseDadosDataSetTeamSet
            // 
            this.baseDadosDataSetTeamSet.DataSetName = "BaseDadosDataSetTeamSet";
            this.baseDadosDataSetTeamSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamSetBindingSource
            // 
            this.teamSetBindingSource.DataMember = "TeamSet";
            this.teamSetBindingSource.DataSource = this.baseDadosDataSetTeamSet;
            // 
            // teamSetTableAdapter
            // 
            this.teamSetTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // baseDadosDataSetTeamSetBindingSource
            // 
            this.baseDadosDataSetTeamSetBindingSource.DataSource = this.baseDadosDataSetTeamSet;
            this.baseDadosDataSetTeamSetBindingSource.Position = 0;
            // 
            // teamSetBindingSource1
            // 
            this.teamSetBindingSource1.DataMember = "TeamSet";
            this.teamSetBindingSource1.DataSource = this.baseDadosDataSetTeamSetBindingSource;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // GestaoTorneioEquipas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 540);
            this.Controls.Add(this.gbxGestaoTorneios);
            this.Controls.Add(this.gbxJogador2);
            this.Controls.Add(this.gbxJogador1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "GestaoTorneioEquipas";
            this.Text = "GestaoTorneioEquipas";
            this.Load += new System.EventHandler(this.GestaoTorneioEquipas_Load);
            this.gbxGestaoTorneios.ResumeLayout(false);
            this.gbxGestaoTorneios.PerformLayout();
            this.gbxJogador2.ResumeLayout(false);
            this.gbxJogador2.PerformLayout();
            this.gbxJogador1.ResumeLayout(false);
            this.gbxJogador1.PerformLayout();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipa2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetTeamSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetTeamSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxGestaoTorneios;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.DateTimePicker datetimeHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetimeData;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnPesquisarEquipa2;
        private System.Windows.Forms.Button btnPesquisarEquipa1;
        private System.Windows.Forms.TextBox tbxEquipa1;
        private System.Windows.Forms.GroupBox gbxJogador2;
        private System.Windows.Forms.TextBox tbxEquipa2;
        private System.Windows.Forms.GroupBox gbxJogador1;
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
        private System.Windows.Forms.DataGridView dataGridEquipa1;
        private System.Windows.Forms.DataGridView dataGridEquipa2;
        private BaseDadosDataSetTeamSet baseDadosDataSetTeamSet;
        private System.Windows.Forms.BindingSource teamSetBindingSource;
        private BaseDadosDataSetTeamSetTableAdapters.TeamSetTableAdapter teamSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource teamSetBindingSource1;
        private System.Windows.Forms.BindingSource baseDadosDataSetTeamSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}
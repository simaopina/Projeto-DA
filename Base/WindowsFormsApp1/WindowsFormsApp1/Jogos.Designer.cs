namespace WindowsFormsApp1
{
    partial class Jogos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.standadTournamentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameSetStardadGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosGameStardad = new WindowsFormsApp1.BaseDadosGameStardad();
            this.gameSet_StardadGameTableAdapter = new WindowsFormsApp1.BaseDadosGameStardadTableAdapters.GameSet_StardadGameTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosADecorrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeamentoDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.standadTournamentIdDataGridViewTextBoxColumn,
            this.playerIdDataGridViewTextBoxColumn,
            this.playerId1DataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameSetStardadGameBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 110);
            this.dataGridView1.TabIndex = 33;
            // 
            // standadTournamentIdDataGridViewTextBoxColumn
            // 
            this.standadTournamentIdDataGridViewTextBoxColumn.DataPropertyName = "StandadTournamentId";
            this.standadTournamentIdDataGridViewTextBoxColumn.HeaderText = "StandadTournamentId";
            this.standadTournamentIdDataGridViewTextBoxColumn.Name = "standadTournamentIdDataGridViewTextBoxColumn";
            this.standadTournamentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerIdDataGridViewTextBoxColumn
            // 
            this.playerIdDataGridViewTextBoxColumn.DataPropertyName = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.HeaderText = "PlayerId";
            this.playerIdDataGridViewTextBoxColumn.Name = "playerIdDataGridViewTextBoxColumn";
            this.playerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerId1DataGridViewTextBoxColumn
            // 
            this.playerId1DataGridViewTextBoxColumn.DataPropertyName = "PlayerId1";
            this.playerId1DataGridViewTextBoxColumn.HeaderText = "PlayerId1";
            this.playerId1DataGridViewTextBoxColumn.Name = "playerId1DataGridViewTextBoxColumn";
            this.playerId1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameSetStardadGameBindingSource
            // 
            this.gameSetStardadGameBindingSource.DataMember = "GameSet_StardadGame";
            this.gameSetStardadGameBindingSource.DataSource = this.baseDadosGameStardad;
            // 
            // baseDadosGameStardad
            // 
            this.baseDadosGameStardad.DataSetName = "BaseDadosGameStardad";
            this.baseDadosGameStardad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameSet_StardadGameTableAdapter
            // 
            this.gameSet_StardadGameTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.baralhoToolStripMenuItem,
            this.torneiosToolStripMenuItem,
            this.terminarSessãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(607, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
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
            this.toolStripSeparator1,
            this.cartasToolStripMenuItem});
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // cartasToolStripMenuItem
            // 
            this.cartasToolStripMenuItem.Name = "cartasToolStripMenuItem";
            this.cartasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cartasToolStripMenuItem.Text = "Cartas";
            this.cartasToolStripMenuItem.Click += new System.EventHandler(this.cartasToolStripMenuItem_Click);
            // 
            // torneiosToolStripMenuItem
            // 
            this.torneiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogosADecorrerToolStripMenuItem,
            this.planeamentoDeJogosToolStripMenuItem,
            this.historicoToolStripMenuItem});
            this.torneiosToolStripMenuItem.Name = "torneiosToolStripMenuItem";
            this.torneiosToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.torneiosToolStripMenuItem.Text = "Torneio";
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
            this.historicoToolStripMenuItem.Text = "Histórico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click);
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.terminarSessãoToolStripMenuItem_Click);
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Jogos";
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.Jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BaseDadosGameStardad baseDadosGameStardad;
        private System.Windows.Forms.BindingSource gameSetStardadGameBindingSource;
        private BaseDadosGameStardadTableAdapters.GameSet_StardadGameTableAdapter gameSet_StardadGameTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn standadTournamentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerId1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosADecorrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeamentoDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
    }
}
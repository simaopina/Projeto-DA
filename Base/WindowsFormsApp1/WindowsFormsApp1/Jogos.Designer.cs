﻿namespace WindowsFormsApp1
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
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarBaralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).BeginInit();
            this.menuStripHome.SuspendLayout();
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
            // menuStripHome
            // 
            this.menuStripHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.baralhoToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.terminarSessãoToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(607, 24);
            this.menuStripHome.TabIndex = 34;
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
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.loginToolStripMenuItem.Text = "Permissões";
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
            // 
            // editarBaralhoToolStripMenuItem
            // 
            this.editarBaralhoToolStripMenuItem.Name = "editarBaralhoToolStripMenuItem";
            this.editarBaralhoToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarBaralhoToolStripMenuItem.Text = "Editar Baralho";
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
            // 
            // jogadoresToolStripMenuItem
            // 
            this.jogadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogadorToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            // 
            // novoJogadorToolStripMenuItem
            // 
            this.novoJogadorToolStripMenuItem.Name = "novoJogadorToolStripMenuItem";
            this.novoJogadorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.novoJogadorToolStripMenuItem.Text = "Adicionar Novo";
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar Sessão";
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.menuStripHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Jogos";
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.Jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarBaralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
    }
}
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
            this.baseDadosGameStardad = new WindowsFormsApp1.BaseDadosGameStardad();
            this.gameSetStardadGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameSet_StardadGameTableAdapter = new WindowsFormsApp1.BaseDadosGameStardadTableAdapters.GameSet_StardadGameTableAdapter();
            this.standadTournamentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerId1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 30);
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
            this.dataGridView1.Location = new System.Drawing.Point(40, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // baseDadosGameStardad
            // 
            this.baseDadosGameStardad.DataSetName = "BaseDadosGameStardad";
            this.baseDadosGameStardad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameSetStardadGameBindingSource
            // 
            this.gameSetStardadGameBindingSource.DataMember = "GameSet_StardadGame";
            this.gameSetStardadGameBindingSource.DataSource = this.baseDadosGameStardad;
            // 
            // gameSet_StardadGameTableAdapter
            // 
            this.gameSet_StardadGameTableAdapter.ClearBeforeFill = true;
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
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Jogos";
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.Jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}
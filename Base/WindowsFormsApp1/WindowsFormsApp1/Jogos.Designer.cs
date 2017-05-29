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
            this.gameSetStardadGameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosGameStardad = new WindowsFormsApp1.BaseDadosGameStardad();
            this.gameSet_StardadGameTableAdapter = new WindowsFormsApp1.BaseDadosGameStardadTableAdapters.GameSet_StardadGameTableAdapter();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogosADecorrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planeamentoDeJogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listVJogos = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.torneioToolStripMenuItem,
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
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click_1);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baralhoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cartaToolStripMenuItem});
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
            // cartaToolStripMenuItem
            // 
            this.cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            this.cartaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.cartaToolStripMenuItem.Text = "Cartas";
            this.cartaToolStripMenuItem.Click += new System.EventHandler(this.cartaToolStripMenuItem_Click);
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
            this.jogosADecorrerToolStripMenuItem.Click += new System.EventHandler(this.jogosADecorrerToolStripMenuItem_Click_1);
            // 
            // planeamentoDeJogosToolStripMenuItem
            // 
            this.planeamentoDeJogosToolStripMenuItem.Name = "planeamentoDeJogosToolStripMenuItem";
            this.planeamentoDeJogosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.planeamentoDeJogosToolStripMenuItem.Text = "Planeamento de jogos";
            this.planeamentoDeJogosToolStripMenuItem.Click += new System.EventHandler(this.planeamentoDeJogosToolStripMenuItem_Click_1);
            // 
            // historicoToolStripMenuItem
            // 
            this.historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            this.historicoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.historicoToolStripMenuItem.Text = "Historico";
            this.historicoToolStripMenuItem.Click += new System.EventHandler(this.historicoToolStripMenuItem_Click_1);
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.terminarSessãoToolStripMenuItem_Click_1);
            // 
            // listVJogos
            // 
            this.listVJogos.Location = new System.Drawing.Point(13, 237);
            this.listVJogos.Name = "listVJogos";
            this.listVJogos.Size = new System.Drawing.Size(160, 226);
            this.listVJogos.TabIndex = 35;
            this.listVJogos.UseCompatibleStateImageBehavior = false;
            this.listVJogos.View = System.Windows.Forms.View.List;
            this.listVJogos.SelectedIndexChanged += new System.EventHandler(this.listVJogos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Jogos:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(314, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 109);
            this.btnEliminar.TabIndex = 37;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 475);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listVJogos);
            this.Controls.Add(this.menuStripHome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Jogos";
            this.Text = "Jogos";
            this.Load += new System.EventHandler(this.Jogos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameSetStardadGameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosGameStardad)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private BaseDadosGameStardad baseDadosGameStardad;
        private System.Windows.Forms.BindingSource gameSetStardadGameBindingSource;
        private BaseDadosGameStardadTableAdapters.GameSet_StardadGameTableAdapter gameSet_StardadGameTableAdapter;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogosADecorrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planeamentoDeJogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ListView listVJogos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
    }
}
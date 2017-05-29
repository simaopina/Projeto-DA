namespace WindowsFormsApp1
{
    partial class CriarTorneio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabStandard = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEliminarStandard = new System.Windows.Forms.Button();
            this.btnAlterarStandard = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.listVStandard = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuardarStandard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDataStandard = new System.Windows.Forms.DateTimePicker();
            this.tbxDescricaoStandard = new System.Windows.Forms.TextBox();
            this.tbxNomeStandard = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarEquipas = new System.Windows.Forms.Button();
            this.btnAlterarEquipas = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listVEquipas = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTEquipas = new System.Windows.Forms.DateTimePicker();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.tbxNomeEquipas = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabStandard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(21, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // tabStandard
            // 
            this.tabStandard.Controls.Add(this.tabPage1);
            this.tabStandard.Controls.Add(this.tabPage2);
            this.tabStandard.Location = new System.Drawing.Point(12, 191);
            this.tabStandard.Name = "tabStandard";
            this.tabStandard.SelectedIndex = 0;
            this.tabStandard.Size = new System.Drawing.Size(598, 336);
            this.tabStandard.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.btnEliminarStandard);
            this.tabPage1.Controls.Add(this.btnAlterarStandard);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.listVStandard);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnGuardarStandard);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimeDataStandard);
            this.tabPage1.Controls.Add(this.tbxDescricaoStandard);
            this.tabPage1.Controls.Add(this.tbxNomeStandard);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            // 
            // btnEliminarStandard
            // 
            this.btnEliminarStandard.Location = new System.Drawing.Point(332, 284);
            this.btnEliminarStandard.Name = "btnEliminarStandard";
            this.btnEliminarStandard.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarStandard.TabIndex = 21;
            this.btnEliminarStandard.Text = "Eliminar";
            this.btnEliminarStandard.UseVisualStyleBackColor = true;
            this.btnEliminarStandard.Click += new System.EventHandler(this.btnEliminarStandard_Click);
            // 
            // btnAlterarStandard
            // 
            this.btnAlterarStandard.Location = new System.Drawing.Point(413, 284);
            this.btnAlterarStandard.Name = "btnAlterarStandard";
            this.btnAlterarStandard.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarStandard.TabIndex = 20;
            this.btnAlterarStandard.Text = "Alterar";
            this.btnAlterarStandard.UseVisualStyleBackColor = true;
            this.btnAlterarStandard.Click += new System.EventHandler(this.btnAlterarStandard_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(86, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Torneios:";
            // 
            // listVStandard
            // 
            this.listVStandard.Location = new System.Drawing.Point(7, 38);
            this.listVStandard.Name = "listVStandard";
            this.listVStandard.Size = new System.Drawing.Size(204, 266);
            this.listVStandard.TabIndex = 16;
            this.listVStandard.UseCompatibleStateImageBehavior = false;
            this.listVStandard.View = System.Windows.Forms.View.List;
            this.listVStandard.SelectedIndexChanged += new System.EventHandler(this.listVStandard_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(494, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnGuardarStandard
            // 
            this.btnGuardarStandard.Location = new System.Drawing.Point(251, 284);
            this.btnGuardarStandard.Name = "btnGuardarStandard";
            this.btnGuardarStandard.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarStandard.TabIndex = 14;
            this.btnGuardarStandard.Text = "Guardar";
            this.btnGuardarStandard.UseVisualStyleBackColor = true;
            this.btnGuardarStandard.Click += new System.EventHandler(this.btnGuardarStandard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Torneio Standard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // dateTimeDataStandard
            // 
            this.dateTimeDataStandard.Location = new System.Drawing.Point(276, 64);
            this.dateTimeDataStandard.Name = "dateTimeDataStandard";
            this.dateTimeDataStandard.Size = new System.Drawing.Size(206, 20);
            this.dateTimeDataStandard.TabIndex = 2;
            // 
            // tbxDescricaoStandard
            // 
            this.tbxDescricaoStandard.Location = new System.Drawing.Point(238, 118);
            this.tbxDescricaoStandard.Multiline = true;
            this.tbxDescricaoStandard.Name = "tbxDescricaoStandard";
            this.tbxDescricaoStandard.Size = new System.Drawing.Size(342, 133);
            this.tbxDescricaoStandard.TabIndex = 1;
            // 
            // tbxNomeStandard
            // 
            this.tbxNomeStandard.Location = new System.Drawing.Point(276, 38);
            this.tbxNomeStandard.Name = "tbxNomeStandard";
            this.tbxNomeStandard.Size = new System.Drawing.Size(206, 20);
            this.tbxNomeStandard.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage2.Controls.Add(this.btnEliminarEquipas);
            this.tabPage2.Controls.Add(this.btnAlterarEquipas);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.listVEquipas);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dateTEquipas);
            this.tabPage2.Controls.Add(this.tbxDescricao);
            this.tabPage2.Controls.Add(this.tbxNomeEquipas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Equipas";
            // 
            // btnEliminarEquipas
            // 
            this.btnEliminarEquipas.Location = new System.Drawing.Point(324, 274);
            this.btnEliminarEquipas.Name = "btnEliminarEquipas";
            this.btnEliminarEquipas.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarEquipas.TabIndex = 22;
            this.btnEliminarEquipas.Text = "Eliminar";
            this.btnEliminarEquipas.UseVisualStyleBackColor = true;
            this.btnEliminarEquipas.Click += new System.EventHandler(this.btnEliminarEquipas_Click);
            // 
            // btnAlterarEquipas
            // 
            this.btnAlterarEquipas.Location = new System.Drawing.Point(405, 274);
            this.btnAlterarEquipas.Name = "btnAlterarEquipas";
            this.btnAlterarEquipas.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarEquipas.TabIndex = 21;
            this.btnAlterarEquipas.Text = "Alterar";
            this.btnAlterarEquipas.UseVisualStyleBackColor = true;
            this.btnAlterarEquipas.Click += new System.EventHandler(this.btnAlterarEquipas_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Torneios:";
            // 
            // listVEquipas
            // 
            this.listVEquipas.Location = new System.Drawing.Point(7, 41);
            this.listVEquipas.Name = "listVEquipas";
            this.listVEquipas.Size = new System.Drawing.Size(204, 266);
            this.listVEquipas.TabIndex = 17;
            this.listVEquipas.UseCompatibleStateImageBehavior = false;
            this.listVEquipas.View = System.Windows.Forms.View.List;
            this.listVEquipas.SelectedIndexChanged += new System.EventHandler(this.listVEquipas_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(243, 274);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Torneio Equipas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nome";
            // 
            // dateTEquipas
            // 
            this.dateTEquipas.Location = new System.Drawing.Point(255, 69);
            this.dateTEquipas.Name = "dateTEquipas";
            this.dateTEquipas.Size = new System.Drawing.Size(206, 20);
            this.dateTEquipas.TabIndex = 8;
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(217, 108);
            this.tbxDescricao.Multiline = true;
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(342, 160);
            this.tbxDescricao.TabIndex = 7;
            // 
            // tbxNomeEquipas
            // 
            this.tbxNomeEquipas.Location = new System.Drawing.Point(255, 43);
            this.tbxNomeEquipas.Name = "tbxNomeEquipas";
            this.tbxNomeEquipas.Size = new System.Drawing.Size(206, 20);
            this.tbxNomeEquipas.TabIndex = 6;
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
            this.menuStripHome.Size = new System.Drawing.Size(622, 24);
            this.menuStripHome.TabIndex = 48;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
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
            // 
            // torneioEquipaToolStripMenuItem
            // 
            this.torneioEquipaToolStripMenuItem.Name = "torneioEquipaToolStripMenuItem";
            this.torneioEquipaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.torneioEquipaToolStripMenuItem.Text = "Jogo Equipa";
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar Sessão";
            // 
            // CriarTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 539);
            this.Controls.Add(this.menuStripHome);
            this.Controls.Add(this.tabStandard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CriarTorneio";
            this.Text = "CriarTorneio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabStandard.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabStandard;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxDescricaoStandard;
        private System.Windows.Forms.TextBox tbxNomeStandard;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDataStandard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTEquipas;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.TextBox tbxNomeEquipas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGuardarStandard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView listVStandard;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listVEquipas;
        private System.Windows.Forms.Button btnAlterarStandard;
        private System.Windows.Forms.Button btnAlterarEquipas;
        private System.Windows.Forms.Button btnEliminarStandard;
        private System.Windows.Forms.Button btnEliminarEquipas;
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
    }
}
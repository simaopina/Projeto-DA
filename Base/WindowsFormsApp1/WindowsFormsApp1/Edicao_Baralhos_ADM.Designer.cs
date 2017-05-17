namespace WindowsFormsApp1
{
    partial class Edicao_Baralhos_ADM
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
            this.gbxEdBaralhoADM = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarAlterações = new System.Windows.Forms.Button();
            this.btnAdicionarBaralho = new System.Windows.Forms.Button();
            this.btnRemoverBaralho = new System.Windows.Forms.Button();
            this.cbxBaralho = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listVCartas = new System.Windows.Forms.ListView();
            this.listVBaralho = new System.Windows.Forms.ListView();
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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxEdBaralhoADM.SuspendLayout();
            this.gbxCuriosidades.SuspendLayout();
            this.gbxEquipas.SuspendLayout();
            this.gbxRank.SuspendLayout();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEdBaralhoADM
            // 
            this.gbxEdBaralhoADM.Controls.Add(this.label13);
            this.gbxEdBaralhoADM.Controls.Add(this.label12);
            this.gbxEdBaralhoADM.Controls.Add(this.btnCancelar);
            this.gbxEdBaralhoADM.Controls.Add(this.btnGuardarAlterações);
            this.gbxEdBaralhoADM.Controls.Add(this.btnAdicionarBaralho);
            this.gbxEdBaralhoADM.Controls.Add(this.btnRemoverBaralho);
            this.gbxEdBaralhoADM.Controls.Add(this.cbxBaralho);
            this.gbxEdBaralhoADM.Controls.Add(this.label11);
            this.gbxEdBaralhoADM.Controls.Add(this.listVCartas);
            this.gbxEdBaralhoADM.Controls.Add(this.listVBaralho);
            this.gbxEdBaralhoADM.Location = new System.Drawing.Point(245, 233);
            this.gbxEdBaralhoADM.Name = "gbxEdBaralhoADM";
            this.gbxEdBaralhoADM.Size = new System.Drawing.Size(348, 286);
            this.gbxEdBaralhoADM.TabIndex = 30;
            this.gbxEdBaralhoADM.TabStop = false;
            this.gbxEdBaralhoADM.Text = "Edição Baralho";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(252, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Cartas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Baralho:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(251, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 43);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuardarAlterações
            // 
            this.btnGuardarAlterações.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardarAlterações.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlterações.Location = new System.Drawing.Point(171, 236);
            this.btnGuardarAlterações.Name = "btnGuardarAlterações";
            this.btnGuardarAlterações.Size = new System.Drawing.Size(77, 43);
            this.btnGuardarAlterações.TabIndex = 6;
            this.btnGuardarAlterações.Text = "Guardar alterações";
            this.btnGuardarAlterações.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarBaralho
            // 
            this.btnAdicionarBaralho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdicionarBaralho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarBaralho.Location = new System.Drawing.Point(143, 143);
            this.btnAdicionarBaralho.Name = "btnAdicionarBaralho";
            this.btnAdicionarBaralho.Size = new System.Drawing.Size(45, 37);
            this.btnAdicionarBaralho.TabIndex = 5;
            this.btnAdicionarBaralho.Text = "<";
            this.btnAdicionarBaralho.UseVisualStyleBackColor = false;
            // 
            // btnRemoverBaralho
            // 
            this.btnRemoverBaralho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoverBaralho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverBaralho.Location = new System.Drawing.Point(143, 100);
            this.btnRemoverBaralho.Name = "btnRemoverBaralho";
            this.btnRemoverBaralho.Size = new System.Drawing.Size(45, 37);
            this.btnRemoverBaralho.TabIndex = 4;
            this.btnRemoverBaralho.Text = ">";
            this.btnRemoverBaralho.UseVisualStyleBackColor = false;
            // 
            // cbxBaralho
            // 
            this.cbxBaralho.FormattingEnabled = true;
            this.cbxBaralho.Location = new System.Drawing.Point(127, 14);
            this.cbxBaralho.Name = "cbxBaralho";
            this.cbxBaralho.Size = new System.Drawing.Size(121, 21);
            this.cbxBaralho.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(83, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Baralho:";
            // 
            // listVCartas
            // 
            this.listVCartas.Location = new System.Drawing.Point(213, 62);
            this.listVCartas.Name = "listVCartas";
            this.listVCartas.Size = new System.Drawing.Size(115, 168);
            this.listVCartas.TabIndex = 1;
            this.listVCartas.UseCompatibleStateImageBehavior = false;
            // 
            // listVBaralho
            // 
            this.listVBaralho.Location = new System.Drawing.Point(6, 62);
            this.listVBaralho.Name = "listVBaralho";
            this.listVBaralho.Size = new System.Drawing.Size(115, 168);
            this.listVBaralho.TabIndex = 0;
            this.listVBaralho.UseCompatibleStateImageBehavior = false;
            // 
            // gbxCuriosidades
            // 
            this.gbxCuriosidades.Controls.Add(this.list_Curiosidades);
            this.gbxCuriosidades.Location = new System.Drawing.Point(35, 416);
            this.gbxCuriosidades.Name = "gbxCuriosidades";
            this.gbxCuriosidades.Size = new System.Drawing.Size(179, 100);
            this.gbxCuriosidades.TabIndex = 29;
            this.gbxCuriosidades.TabStop = false;
            this.gbxCuriosidades.Text = "Curiosidades";
            // 
            // list_Curiosidades
            // 
            this.list_Curiosidades.Location = new System.Drawing.Point(37, 19);
            this.list_Curiosidades.Name = "list_Curiosidades";
            this.list_Curiosidades.Size = new System.Drawing.Size(121, 64);
            this.list_Curiosidades.TabIndex = 9;
            this.list_Curiosidades.UseCompatibleStateImageBehavior = false;
            // 
            // gbxEquipas
            // 
            this.gbxEquipas.Controls.Add(this.label2);
            this.gbxEquipas.Controls.Add(this.listEquipas);
            this.gbxEquipas.Controls.Add(this.label3);
            this.gbxEquipas.Controls.Add(this.label8);
            this.gbxEquipas.Controls.Add(this.label10);
            this.gbxEquipas.Controls.Add(this.label9);
            this.gbxEquipas.Location = new System.Drawing.Point(35, 304);
            this.gbxEquipas.Name = "gbxEquipas";
            this.gbxEquipas.Size = new System.Drawing.Size(179, 100);
            this.gbxEquipas.TabIndex = 28;
            this.gbxEquipas.TabStop = false;
            this.gbxEquipas.Text = "Rank Equipas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "5.";
            // 
            // listEquipas
            // 
            this.listEquipas.Location = new System.Drawing.Point(37, 19);
            this.listEquipas.Name = "listEquipas";
            this.listEquipas.Size = new System.Drawing.Size(121, 64);
            this.listEquipas.TabIndex = 8;
            this.listEquipas.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "4.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "3.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "1.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "2.";
            // 
            // gbxRank
            // 
            this.gbxRank.Controls.Add(this.label7);
            this.gbxRank.Controls.Add(this.label6);
            this.gbxRank.Controls.Add(this.label1);
            this.gbxRank.Controls.Add(this.listRank);
            this.gbxRank.Controls.Add(this.label5);
            this.gbxRank.Controls.Add(this.label4);
            this.gbxRank.Location = new System.Drawing.Point(35, 197);
            this.gbxRank.Name = "gbxRank";
            this.gbxRank.Size = new System.Drawing.Size(179, 100);
            this.gbxRank.TabIndex = 27;
            this.gbxRank.TabStop = false;
            this.gbxRank.Text = "Rank Jogadores";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "5.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "4.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "3.";
            // 
            // listRank
            // 
            this.listRank.Location = new System.Drawing.Point(37, 19);
            this.listRank.Name = "listRank";
            this.listRank.Size = new System.Drawing.Size(121, 64);
            this.listRank.TabIndex = 7;
            this.listRank.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "2.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "1.";
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
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            this.menuStripHome.Size = new System.Drawing.Size(635, 24);
            this.menuStripHome.TabIndex = 20;
            this.menuStripHome.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.loginToolStripMenuItem.Text = "Permissões";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // baralhoToolStripMenuItem
            // 
            this.baralhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baralhoToolStripMenuItem1,
            this.editarToolStripMenuItem,
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
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarToolStripMenuItem.Text = "Editar Baralho";
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
            this.addJogadorToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.jogadoresToolStripMenuItem.Text = "Jogadores";
            // 
            // addJogadorToolStripMenuItem
            // 
            this.addJogadorToolStripMenuItem.Name = "addJogadorToolStripMenuItem";
            this.addJogadorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addJogadorToolStripMenuItem.Text = "Add Jogador";
            this.addJogadorToolStripMenuItem.Click += new System.EventHandler(this.addJogadorToolStripMenuItem_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Edicao_Baralhos_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 539);
            this.Controls.Add(this.gbxEdBaralhoADM);
            this.Controls.Add(this.gbxCuriosidades);
            this.Controls.Add(this.gbxEquipas);
            this.Controls.Add(this.gbxRank);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "Edicao_Baralhos_ADM";
            this.Text = "Edicao_Baralhos_ADM";
            this.gbxEdBaralhoADM.ResumeLayout(false);
            this.gbxEdBaralhoADM.PerformLayout();
            this.gbxCuriosidades.ResumeLayout(false);
            this.gbxEquipas.ResumeLayout(false);
            this.gbxEquipas.PerformLayout();
            this.gbxRank.ResumeLayout(false);
            this.gbxRank.PerformLayout();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEdBaralhoADM;
        private System.Windows.Forms.GroupBox gbxCuriosidades;
        private System.Windows.Forms.ListView list_Curiosidades;
        private System.Windows.Forms.GroupBox gbxEquipas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listEquipas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbxRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listRank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jogadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baralhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cartasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addJogadorToolStripMenuItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarAlterações;
        private System.Windows.Forms.Button btnAdicionarBaralho;
        private System.Windows.Forms.Button btnRemoverBaralho;
        private System.Windows.Forms.ComboBox cbxBaralho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listVCartas;
        private System.Windows.Forms.ListView listVBaralho;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
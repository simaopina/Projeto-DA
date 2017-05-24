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
            this.tbxpesquisa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
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
            this.gbxEdBaralhoADM.Location = new System.Drawing.Point(48, 241);
            this.gbxEdBaralhoADM.Name = "gbxEdBaralhoADM";
            this.gbxEdBaralhoADM.Size = new System.Drawing.Size(536, 286);
            this.gbxEdBaralhoADM.TabIndex = 30;
            this.gbxEdBaralhoADM.TabStop = false;
            this.gbxEdBaralhoADM.Text = "Edição Baralho";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(345, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Cartas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(83, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Baralho:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(386, 236);
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
            this.btnGuardarAlterações.Location = new System.Drawing.Point(306, 236);
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
            this.btnAdicionarBaralho.Location = new System.Drawing.Point(247, 140);
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
            this.btnRemoverBaralho.Location = new System.Drawing.Point(247, 97);
            this.btnRemoverBaralho.Name = "btnRemoverBaralho";
            this.btnRemoverBaralho.Size = new System.Drawing.Size(45, 37);
            this.btnRemoverBaralho.TabIndex = 4;
            this.btnRemoverBaralho.Text = ">";
            this.btnRemoverBaralho.UseVisualStyleBackColor = false;
            // 
            // cbxBaralho
            // 
            this.cbxBaralho.FormattingEnabled = true;
            this.cbxBaralho.Location = new System.Drawing.Point(226, 19);
            this.cbxBaralho.Name = "cbxBaralho";
            this.cbxBaralho.Size = new System.Drawing.Size(121, 21);
            this.cbxBaralho.TabIndex = 2;
            this.cbxBaralho.SelectedIndexChanged += new System.EventHandler(this.cbxBaralho_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Baralho:";
            // 
            // listVCartas
            // 
            this.listVCartas.Location = new System.Drawing.Point(348, 62);
            this.listVCartas.Name = "listVCartas";
            this.listVCartas.Size = new System.Drawing.Size(115, 168);
            this.listVCartas.TabIndex = 1;
            this.listVCartas.UseCompatibleStateImageBehavior = false;
            this.listVCartas.SelectedIndexChanged += new System.EventHandler(this.listVCartas_SelectedIndexChanged);
            // 
            // listVBaralho
            // 
            this.listVBaralho.Location = new System.Drawing.Point(86, 62);
            this.listVBaralho.Name = "listVBaralho";
            this.listVBaralho.Size = new System.Drawing.Size(115, 168);
            this.listVBaralho.TabIndex = 0;
            this.listVBaralho.UseCompatibleStateImageBehavior = false;
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.baralhoToolStripMenuItem,
            this.jogadoresToolStripMenuItem,
            this.terminarSessãoToolStripMenuItem});
            this.menuStripHome.Location = new System.Drawing.Point(0, 0);
            this.menuStripHome.Name = "menuStripHome";
            this.menuStripHome.Size = new System.Drawing.Size(635, 24);
            this.menuStripHome.TabIndex = 20;
            this.menuStripHome.Text = "menuStrip1";
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
            this.baralhoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.baralhoToolStripMenuItem1.Text = "Baralho";
            this.baralhoToolStripMenuItem1.Click += new System.EventHandler(this.baralhoToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editarToolStripMenuItem.Text = "Editar Baralho";
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
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "Edicao_Baralhos_ADM";
            this.Text = "Edicao_Baralhos_ADM";
            this.gbxEdBaralhoADM.ResumeLayout(false);
            this.gbxEdBaralhoADM.PerformLayout();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEdBaralhoADM;
        private System.Windows.Forms.TextBox tbxpesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripHome;
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
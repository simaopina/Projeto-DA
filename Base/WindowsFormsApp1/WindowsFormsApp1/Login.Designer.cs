namespace WindowsFormsApp1
{
    partial class Login
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbxPW = new System.Windows.Forms.TextBox();
            this.tbxemail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gbxCuriosidade = new System.Windows.Forms.GroupBox();
            this.list_Curiosidades = new System.Windows.Forms.ListView();
            this.gbx_Equipas = new System.Windows.Forms.GroupBox();
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
            this.rbtnCartas = new System.Windows.Forms.RadioButton();
            this.rbtnTorneio = new System.Windows.Forms.RadioButton();
            this.rbtnJogadores = new System.Windows.Forms.RadioButton();
            this.rbtnArbitro = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.menustripLogin = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxLogin.SuspendLayout();
            this.gbxCuriosidade.SuspendLayout();
            this.gbx_Equipas.SuspendLayout();
            this.gbxRank.SuspendLayout();
            this.menustripLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.button2);
            this.gbxLogin.Controls.Add(this.button1);
            this.gbxLogin.Controls.Add(this.btnCancelar);
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.tbxPW);
            this.gbxLogin.Controls.Add(this.tbxemail);
            this.gbxLogin.Controls.Add(this.label12);
            this.gbxLogin.Controls.Add(this.label11);
            this.gbxLogin.Location = new System.Drawing.Point(245, 268);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(348, 248);
            this.gbxLogin.TabIndex = 30;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Login";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(215, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(102, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbxPW
            // 
            this.tbxPW.Location = new System.Drawing.Point(102, 107);
            this.tbxPW.Name = "tbxPW";
            this.tbxPW.Size = new System.Drawing.Size(188, 20);
            this.tbxPW.TabIndex = 3;
            // 
            // tbxemail
            // 
            this.tbxemail.Location = new System.Drawing.Point(102, 68);
            this.tbxemail.Name = "tbxemail";
            this.tbxemail.Size = new System.Drawing.Size(188, 20);
            this.tbxemail.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Email:";
            // 
            // gbxCuriosidade
            // 
            this.gbxCuriosidade.Controls.Add(this.list_Curiosidades);
            this.gbxCuriosidade.Location = new System.Drawing.Point(35, 413);
            this.gbxCuriosidade.Name = "gbxCuriosidade";
            this.gbxCuriosidade.Size = new System.Drawing.Size(179, 100);
            this.gbxCuriosidade.TabIndex = 29;
            this.gbxCuriosidade.TabStop = false;
            this.gbxCuriosidade.Text = "Curiosidades";
            // 
            // list_Curiosidades
            // 
            this.list_Curiosidades.Location = new System.Drawing.Point(37, 19);
            this.list_Curiosidades.Name = "list_Curiosidades";
            this.list_Curiosidades.Size = new System.Drawing.Size(121, 64);
            this.list_Curiosidades.TabIndex = 9;
            this.list_Curiosidades.UseCompatibleStateImageBehavior = false;
            // 
            // gbx_Equipas
            // 
            this.gbx_Equipas.Controls.Add(this.label2);
            this.gbx_Equipas.Controls.Add(this.listEquipas);
            this.gbx_Equipas.Controls.Add(this.label3);
            this.gbx_Equipas.Controls.Add(this.label8);
            this.gbx_Equipas.Controls.Add(this.label10);
            this.gbx_Equipas.Controls.Add(this.label9);
            this.gbx_Equipas.Location = new System.Drawing.Point(35, 301);
            this.gbx_Equipas.Name = "gbx_Equipas";
            this.gbx_Equipas.Size = new System.Drawing.Size(179, 100);
            this.gbx_Equipas.TabIndex = 28;
            this.gbx_Equipas.TabStop = false;
            this.gbx_Equipas.Text = "Rank Equipas";
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
            this.gbxRank.Location = new System.Drawing.Point(35, 194);
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
            this.tbxpesquisa.Location = new System.Drawing.Point(245, 201);
            this.tbxpesquisa.Name = "tbxpesquisa";
            this.tbxpesquisa.Size = new System.Drawing.Size(266, 20);
            this.tbxpesquisa.TabIndex = 26;
            this.tbxpesquisa.Text = "Pesquisar...";
            // 
            // rbtnCartas
            // 
            this.rbtnCartas.AutoSize = true;
            this.rbtnCartas.Location = new System.Drawing.Point(456, 231);
            this.rbtnCartas.Name = "rbtnCartas";
            this.rbtnCartas.Size = new System.Drawing.Size(55, 17);
            this.rbtnCartas.TabIndex = 25;
            this.rbtnCartas.TabStop = true;
            this.rbtnCartas.Text = "Cartas";
            this.rbtnCartas.UseVisualStyleBackColor = true;
            // 
            // rbtnTorneio
            // 
            this.rbtnTorneio.AutoSize = true;
            this.rbtnTorneio.Location = new System.Drawing.Point(388, 231);
            this.rbtnTorneio.Name = "rbtnTorneio";
            this.rbtnTorneio.Size = new System.Drawing.Size(61, 17);
            this.rbtnTorneio.TabIndex = 24;
            this.rbtnTorneio.TabStop = true;
            this.rbtnTorneio.Text = "Torneio";
            this.rbtnTorneio.UseVisualStyleBackColor = true;
            // 
            // rbtnJogadores
            // 
            this.rbtnJogadores.AutoSize = true;
            this.rbtnJogadores.Location = new System.Drawing.Point(307, 231);
            this.rbtnJogadores.Name = "rbtnJogadores";
            this.rbtnJogadores.Size = new System.Drawing.Size(74, 17);
            this.rbtnJogadores.TabIndex = 23;
            this.rbtnJogadores.TabStop = true;
            this.rbtnJogadores.Text = "Jogadores";
            this.rbtnJogadores.UseVisualStyleBackColor = true;
            // 
            // rbtnArbitro
            // 
            this.rbtnArbitro.AutoSize = true;
            this.rbtnArbitro.Location = new System.Drawing.Point(245, 231);
            this.rbtnArbitro.Name = "rbtnArbitro";
            this.rbtnArbitro.Size = new System.Drawing.Size(55, 17);
            this.rbtnArbitro.TabIndex = 22;
            this.rbtnArbitro.TabStop = true;
            this.rbtnArbitro.Text = "Arbitro";
            this.rbtnArbitro.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(518, 201);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // menustripLogin
            // 
            this.menustripLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menustripLogin.Location = new System.Drawing.Point(0, 0);
            this.menustripLogin.Name = "menustripLogin";
            this.menustripLogin.Size = new System.Drawing.Size(624, 24);
            this.menustripLogin.TabIndex = 20;
            this.menustripLogin.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(25, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(102, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = ":) - Admin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(215, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = ":( - arBRITO!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 544);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.gbxCuriosidade);
            this.Controls.Add(this.gbx_Equipas);
            this.Controls.Add(this.gbxRank);
            this.Controls.Add(this.tbxpesquisa);
            this.Controls.Add(this.rbtnCartas);
            this.Controls.Add(this.rbtnTorneio);
            this.Controls.Add(this.rbtnJogadores);
            this.Controls.Add(this.rbtnArbitro);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.menustripLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.gbxCuriosidade.ResumeLayout(false);
            this.gbx_Equipas.ResumeLayout(false);
            this.gbx_Equipas.PerformLayout();
            this.gbxRank.ResumeLayout(false);
            this.gbxRank.PerformLayout();
            this.menustripLogin.ResumeLayout(false);
            this.menustripLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.GroupBox gbxCuriosidade;
        private System.Windows.Forms.ListView list_Curiosidades;
        private System.Windows.Forms.GroupBox gbx_Equipas;
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
        private System.Windows.Forms.RadioButton rbtnCartas;
        private System.Windows.Forms.RadioButton rbtnTorneio;
        private System.Windows.Forms.RadioButton rbtnJogadores;
        private System.Windows.Forms.RadioButton rbtnArbitro;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MenuStrip menustripLogin;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbxPW;
        private System.Windows.Forms.TextBox tbxemail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
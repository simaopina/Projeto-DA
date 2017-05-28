﻿namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.gbxEdBaralhoADM = new System.Windows.Forms.GroupBox();
            this.cardSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosCartasEdição = new WindowsFormsApp1.BaseDadosCartasEdição();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarAlterações = new System.Windows.Forms.Button();
            this.btnAdicionarBaralho = new System.Windows.Forms.Button();
            this.btnRemoverBaralho = new System.Windows.Forms.Button();
            this.cbxBaralho = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listVBaralho = new System.Windows.Forms.ListView();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHome = new System.Windows.Forms.MenuStrip();
            this.baralhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baralhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cartasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jogadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.novaEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.utilizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioIndividualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torneioEquipaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.baseDadosDataSet_Cards = new WindowsFormsApp1.BaseDadosDataSet_Cards();
            this.baseDadosDataSetCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardSetTableAdapter = new WindowsFormsApp1.BaseDadosCartasEdiçãoTableAdapters.CardSetTableAdapter();
            this.listVCartas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxEdBaralhoADM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosCartasEdição)).BeginInit();
            this.menuStripHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet_Cards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetCardsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxEdBaralhoADM
            // 
            this.gbxEdBaralhoADM.Controls.Add(this.listVCartas);
            this.gbxEdBaralhoADM.Controls.Add(this.label13);
            this.gbxEdBaralhoADM.Controls.Add(this.label12);
            this.gbxEdBaralhoADM.Controls.Add(this.btnCancelar);
            this.gbxEdBaralhoADM.Controls.Add(this.btnGuardarAlterações);
            this.gbxEdBaralhoADM.Controls.Add(this.btnAdicionarBaralho);
            this.gbxEdBaralhoADM.Controls.Add(this.btnRemoverBaralho);
            this.gbxEdBaralhoADM.Controls.Add(this.cbxBaralho);
            this.gbxEdBaralhoADM.Controls.Add(this.label11);
            this.gbxEdBaralhoADM.Controls.Add(this.listVBaralho);
            this.gbxEdBaralhoADM.Location = new System.Drawing.Point(49, 211);
            this.gbxEdBaralhoADM.Name = "gbxEdBaralhoADM";
            this.gbxEdBaralhoADM.Size = new System.Drawing.Size(536, 286);
            this.gbxEdBaralhoADM.TabIndex = 30;
            this.gbxEdBaralhoADM.TabStop = false;
            this.gbxEdBaralhoADM.Text = "Edição Baralho";
            this.gbxEdBaralhoADM.Enter += new System.EventHandler(this.gbxEdBaralhoADM_Enter);
            // 
            // cardSetBindingSource
            // 
            this.cardSetBindingSource.DataMember = "CardSet";
            this.cardSetBindingSource.DataSource = this.baseDadosCartasEdição;
            // 
            // baseDadosCartasEdição
            // 
            this.baseDadosCartasEdição.DataSetName = "BaseDadosCartasEdição";
            this.baseDadosCartasEdição.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(307, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Cartas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 46);
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
            this.btnAdicionarBaralho.Location = new System.Drawing.Point(247, 96);
            this.btnAdicionarBaralho.Name = "btnAdicionarBaralho";
            this.btnAdicionarBaralho.Size = new System.Drawing.Size(45, 37);
            this.btnAdicionarBaralho.TabIndex = 5;
            this.btnAdicionarBaralho.Text = "<";
            this.btnAdicionarBaralho.UseVisualStyleBackColor = false;
            this.btnAdicionarBaralho.Click += new System.EventHandler(this.btnAdicionarBaralho_Click);
            // 
            // btnRemoverBaralho
            // 
            this.btnRemoverBaralho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRemoverBaralho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverBaralho.Location = new System.Drawing.Point(247, 153);
            this.btnRemoverBaralho.Name = "btnRemoverBaralho";
            this.btnRemoverBaralho.Size = new System.Drawing.Size(45, 37);
            this.btnRemoverBaralho.TabIndex = 4;
            this.btnRemoverBaralho.Text = ">";
            this.btnRemoverBaralho.UseVisualStyleBackColor = false;
            this.btnRemoverBaralho.Click += new System.EventHandler(this.btnRemoverBaralho_Click);
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
            // listVBaralho
            // 
            this.listVBaralho.Location = new System.Drawing.Point(27, 62);
            this.listVBaralho.Name = "listVBaralho";
            this.listVBaralho.Size = new System.Drawing.Size(201, 168);
            this.listVBaralho.TabIndex = 0;
            this.listVBaralho.UseCompatibleStateImageBehavior = false;
            this.listVBaralho.View = System.Windows.Forms.View.List;
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
            this.toolStripMenuItem1,
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
            this.baralhoToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.baralhoToolStripMenuItem1.Text = "Baralho";
            this.baralhoToolStripMenuItem1.Click += new System.EventHandler(this.baralhoToolStripMenuItem1_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.editarToolStripMenuItem.Text = "Editar Baralho";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
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
            this.addJogadorToolStripMenuItem,
            this.toolStripSeparator2,
            this.novaEquipaToolStripMenuItem,
            this.toolStripSeparator3,
            this.utilizadoresToolStripMenuItem});
            this.jogadoresToolStripMenuItem.Name = "jogadoresToolStripMenuItem";
            this.jogadoresToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.jogadoresToolStripMenuItem.Text = "Gestão";
            // 
            // addJogadorToolStripMenuItem
            // 
            this.addJogadorToolStripMenuItem.Name = "addJogadorToolStripMenuItem";
            this.addJogadorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.addJogadorToolStripMenuItem.Text = "Jogador";
            this.addJogadorToolStripMenuItem.Click += new System.EventHandler(this.addJogadorToolStripMenuItem_Click);
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
            this.torneioIndividualToolStripMenuItem,
            this.torneioEquipaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.toolStripMenuItem1.Text = "Torneios";
            // 
            // torneioIndividualToolStripMenuItem
            // 
            this.torneioIndividualToolStripMenuItem.Name = "torneioIndividualToolStripMenuItem";
            this.torneioIndividualToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.torneioIndividualToolStripMenuItem.Text = "Torneio Individual";
            this.torneioIndividualToolStripMenuItem.Click += new System.EventHandler(this.torneioIndividualToolStripMenuItem_Click);
            // 
            // torneioEquipaToolStripMenuItem
            // 
            this.torneioEquipaToolStripMenuItem.Name = "torneioEquipaToolStripMenuItem";
            this.torneioEquipaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.torneioEquipaToolStripMenuItem.Text = "Torneio Equipa";
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
            this.pictureBox1.Location = new System.Drawing.Point(25, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // baseDadosDataSet_Cards
            // 
            this.baseDadosDataSet_Cards.DataSetName = "BaseDadosDataSet_Cards";
            this.baseDadosDataSet_Cards.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseDadosDataSetCardsBindingSource
            // 
            this.baseDadosDataSetCardsBindingSource.DataSource = this.baseDadosDataSet_Cards;
            this.baseDadosDataSetCardsBindingSource.Position = 0;
            // 
            // cardSetTableAdapter
            // 
            this.cardSetTableAdapter.ClearBeforeFill = true;
            // 
            // listVCartas
            // 
            this.listVCartas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listVCartas.Location = new System.Drawing.Point(306, 62);
            this.listVCartas.Name = "listVCartas";
            this.listVCartas.Size = new System.Drawing.Size(201, 168);
            this.listVCartas.TabIndex = 10;
            this.listVCartas.UseCompatibleStateImageBehavior = false;
            this.listVCartas.View = System.Windows.Forms.View.Details;
            this.listVCartas.SelectedIndexChanged += new System.EventHandler(this.listVCartas_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fação";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lealdade";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Custo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Regras";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ataque";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Defesa";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Imagem";
            // 
            // Edicao_Baralhos_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 539);
            this.Controls.Add(this.gbxEdBaralhoADM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStripHome);
            this.Name = "Edicao_Baralhos_ADM";
            this.Text = "Edicao_Baralhos_ADM";
            this.Load += new System.EventHandler(this.Edicao_Baralhos_ADM_Load);
            this.gbxEdBaralhoADM.ResumeLayout(false);
            this.gbxEdBaralhoADM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosCartasEdição)).EndInit();
            this.menuStripHome.ResumeLayout(false);
            this.menuStripHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet_Cards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSetCardsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEdBaralhoADM;
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
        private System.Windows.Forms.ListView listVBaralho;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem novaEquipaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem utilizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem torneioIndividualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneioEquipaToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbxBaralho;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource baseDadosDataSetCardsBindingSource;
        private BaseDadosDataSet_Cards baseDadosDataSet_Cards;
        private BaseDadosCartasEdição baseDadosCartasEdição;
        private System.Windows.Forms.BindingSource cardSetBindingSource;
        private BaseDadosCartasEdiçãoTableAdapters.CardSetTableAdapter cardSetTableAdapter;
        private System.Windows.Forms.ListView listVCartas;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}
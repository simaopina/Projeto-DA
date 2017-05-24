namespace WindowsFormsApp1
{
    partial class Utilizadores_ADM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar_ADM = new System.Windows.Forms.Button();
            this.btnAlterar_ADM = new System.Windows.Forms.Button();
            this.btnGuardar_ADM = new System.Windows.Forms.Button();
            this.txtbEmail_ADM = new System.Windows.Forms.TextBox();
            this.txtbPassword_ADM = new System.Windows.Forms.TextBox();
            this.txtbNickName_ADM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnAlterar_ARB = new System.Windows.Forms.Button();
            this.txtbNome_ARB = new System.Windows.Forms.TextBox();
            this.btnGuarda_ARB = new System.Windows.Forms.Button();
            this.txtbPassword_ARB = new System.Windows.Forms.TextBox();
            this.txtbNickName_ARB = new System.Windows.Forms.TextBox();
            this.linkLAvatar_ARB = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_ARB = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosDataSet2 = new WindowsFormsApp1.BaseDadosDataSet2();
            this.baseDadosData_ADM = new WindowsFormsApp1.BaseDadosData_ADM();
            this.baseDadosDataADMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userSetTableAdapter = new WindowsFormsApp1.BaseDadosDataSet2TableAdapters.UserSetTableAdapter();
            this.userSetAdministratorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDadosData_administrador = new WindowsFormsApp1.BaseDadosData_administrador();
            this.userSet_AdministratorTableAdapter = new WindowsFormsApp1.BaseDadosData_administradorTableAdapters.UserSet_AdministratorTableAdapter();
            this.userSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userSetTableAdapter1 = new WindowsFormsApp1.BaseDadosData_ADMTableAdapters.UserSetTableAdapter();
            this.userSetAdministratorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userSet_AdministratorTableAdapter1 = new WindowsFormsApp1.BaseDadosData_ADMTableAdapters.UserSet_AdministratorTableAdapter();
            this.listVADM = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ARB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosData_ADM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataADMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetAdministratorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosData_administrador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetAdministratorBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._17813900_1281975635190102_1290798384_n;
            this.pictureBox1.Location = new System.Drawing.Point(21, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(580, 158);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar_ADM);
            this.groupBox1.Controls.Add(this.btnAlterar_ADM);
            this.groupBox1.Controls.Add(this.btnGuardar_ADM);
            this.groupBox1.Controls.Add(this.txtbEmail_ADM);
            this.groupBox1.Controls.Add(this.txtbPassword_ADM);
            this.groupBox1.Controls.Add(this.txtbNickName_ADM);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(21, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 148);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrador";
            // 
            // btnEliminar_ADM
            // 
            this.btnEliminar_ADM.Location = new System.Drawing.Point(136, 117);
            this.btnEliminar_ADM.Name = "btnEliminar_ADM";
            this.btnEliminar_ADM.Size = new System.Drawing.Size(57, 23);
            this.btnEliminar_ADM.TabIndex = 8;
            this.btnEliminar_ADM.Text = "Eliminar";
            this.btnEliminar_ADM.UseVisualStyleBackColor = true;
            // 
            // btnAlterar_ADM
            // 
            this.btnAlterar_ADM.Location = new System.Drawing.Point(73, 117);
            this.btnAlterar_ADM.Name = "btnAlterar_ADM";
            this.btnAlterar_ADM.Size = new System.Drawing.Size(57, 23);
            this.btnAlterar_ADM.TabIndex = 7;
            this.btnAlterar_ADM.Text = "Alterar";
            this.btnAlterar_ADM.UseVisualStyleBackColor = true;
            this.btnAlterar_ADM.Click += new System.EventHandler(this.btnAlterar_ADM_Click);
            // 
            // btnGuardar_ADM
            // 
            this.btnGuardar_ADM.Location = new System.Drawing.Point(10, 117);
            this.btnGuardar_ADM.Name = "btnGuardar_ADM";
            this.btnGuardar_ADM.Size = new System.Drawing.Size(57, 23);
            this.btnGuardar_ADM.TabIndex = 6;
            this.btnGuardar_ADM.Text = "Guardar";
            this.btnGuardar_ADM.UseVisualStyleBackColor = true;
            this.btnGuardar_ADM.Click += new System.EventHandler(this.btnGuardar_ADM_Click);
            // 
            // txtbEmail_ADM
            // 
            this.txtbEmail_ADM.Location = new System.Drawing.Point(78, 79);
            this.txtbEmail_ADM.Name = "txtbEmail_ADM";
            this.txtbEmail_ADM.Size = new System.Drawing.Size(100, 20);
            this.txtbEmail_ADM.TabIndex = 5;
            // 
            // txtbPassword_ADM
            // 
            this.txtbPassword_ADM.Location = new System.Drawing.Point(78, 53);
            this.txtbPassword_ADM.Name = "txtbPassword_ADM";
            this.txtbPassword_ADM.Size = new System.Drawing.Size(100, 20);
            this.txtbPassword_ADM.TabIndex = 4;
            // 
            // txtbNickName_ADM
            // 
            this.txtbNickName_ADM.Location = new System.Drawing.Point(78, 27);
            this.txtbNickName_ADM.Name = "txtbNickName_ADM";
            this.txtbNickName_ADM.Size = new System.Drawing.Size(100, 20);
            this.txtbNickName_ADM.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NickName:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn);
            this.groupBox2.Controls.Add(this.btnAlterar_ARB);
            this.groupBox2.Controls.Add(this.txtbNome_ARB);
            this.groupBox2.Controls.Add(this.btnGuarda_ARB);
            this.groupBox2.Controls.Add(this.txtbPassword_ARB);
            this.groupBox2.Controls.Add(this.txtbNickName_ARB);
            this.groupBox2.Controls.Add(this.linkLAvatar_ARB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(332, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 148);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Árbitro";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(146, 117);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(57, 23);
            this.btn.TabIndex = 11;
            this.btn.Text = "Eliminar";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // btnAlterar_ARB
            // 
            this.btnAlterar_ARB.Location = new System.Drawing.Point(83, 117);
            this.btnAlterar_ARB.Name = "btnAlterar_ARB";
            this.btnAlterar_ARB.Size = new System.Drawing.Size(57, 23);
            this.btnAlterar_ARB.TabIndex = 10;
            this.btnAlterar_ARB.Text = "Alterar";
            this.btnAlterar_ARB.UseVisualStyleBackColor = true;
            // 
            // txtbNome_ARB
            // 
            this.txtbNome_ARB.Location = new System.Drawing.Point(72, 69);
            this.txtbNome_ARB.Name = "txtbNome_ARB";
            this.txtbNome_ARB.Size = new System.Drawing.Size(100, 20);
            this.txtbNome_ARB.TabIndex = 11;
            // 
            // btnGuarda_ARB
            // 
            this.btnGuarda_ARB.Location = new System.Drawing.Point(20, 117);
            this.btnGuarda_ARB.Name = "btnGuarda_ARB";
            this.btnGuarda_ARB.Size = new System.Drawing.Size(57, 23);
            this.btnGuarda_ARB.TabIndex = 9;
            this.btnGuarda_ARB.Text = "Guardar";
            this.btnGuarda_ARB.UseVisualStyleBackColor = true;
            // 
            // txtbPassword_ARB
            // 
            this.txtbPassword_ARB.Location = new System.Drawing.Point(72, 43);
            this.txtbPassword_ARB.Name = "txtbPassword_ARB";
            this.txtbPassword_ARB.Size = new System.Drawing.Size(100, 20);
            this.txtbPassword_ARB.TabIndex = 10;
            // 
            // txtbNickName_ARB
            // 
            this.txtbNickName_ARB.Location = new System.Drawing.Point(72, 17);
            this.txtbNickName_ARB.Name = "txtbNickName_ARB";
            this.txtbNickName_ARB.Size = new System.Drawing.Size(100, 20);
            this.txtbNickName_ARB.TabIndex = 9;
            // 
            // linkLAvatar_ARB
            // 
            this.linkLAvatar_ARB.AutoSize = true;
            this.linkLAvatar_ARB.Location = new System.Drawing.Point(69, 95);
            this.linkLAvatar_ARB.Name = "linkLAvatar_ARB";
            this.linkLAvatar_ARB.Size = new System.Drawing.Size(55, 13);
            this.linkLAvatar_ARB.TabIndex = 4;
            this.linkLAvatar_ARB.TabStop = true;
            this.linkLAvatar_ARB.Text = "linkLabel1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Avatar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "NickName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Adicionar utilizador";
            // 
            // dataGrid_ARB
            // 
            this.dataGrid_ARB.AllowUserToAddRows = false;
            this.dataGrid_ARB.AllowUserToDeleteRows = false;
            this.dataGrid_ARB.AutoGenerateColumns = false;
            this.dataGrid_ARB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_ARB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.usernameDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn1});
            this.dataGrid_ARB.DataSource = this.userSetBindingSource;
            this.dataGrid_ARB.Location = new System.Drawing.Point(332, 246);
            this.dataGrid_ARB.Name = "dataGrid_ARB";
            this.dataGrid_ARB.ReadOnly = true;
            this.dataGrid_ARB.Size = new System.Drawing.Size(240, 100);
            this.dataGrid_ARB.TabIndex = 38;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn1
            // 
            this.passwordDataGridViewTextBoxColumn1.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn1.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn1.Name = "passwordDataGridViewTextBoxColumn1";
            this.passwordDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userSetBindingSource
            // 
            this.userSetBindingSource.DataMember = "UserSet";
            this.userSetBindingSource.DataSource = this.baseDadosDataSet2;
            // 
            // baseDadosDataSet2
            // 
            this.baseDadosDataSet2.DataSetName = "BaseDadosDataSet2";
            this.baseDadosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseDadosData_ADM
            // 
            this.baseDadosData_ADM.DataSetName = "BaseDadosData_ADM";
            this.baseDadosData_ADM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baseDadosDataADMBindingSource
            // 
            this.baseDadosDataADMBindingSource.DataSource = this.baseDadosData_ADM;
            this.baseDadosDataADMBindingSource.Position = 0;
            // 
            // userSetTableAdapter
            // 
            this.userSetTableAdapter.ClearBeforeFill = true;
            // 
            // userSetAdministratorBindingSource
            // 
            this.userSetAdministratorBindingSource.DataMember = "UserSet_Administrator";
            this.userSetAdministratorBindingSource.DataSource = this.baseDadosData_administrador;
            // 
            // baseDadosData_administrador
            // 
            this.baseDadosData_administrador.DataSetName = "BaseDadosData_administrador";
            this.baseDadosData_administrador.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userSet_AdministratorTableAdapter
            // 
            this.userSet_AdministratorTableAdapter.ClearBeforeFill = true;
            // 
            // userSetBindingSource1
            // 
            this.userSetBindingSource1.DataMember = "UserSet";
            this.userSetBindingSource1.DataSource = this.baseDadosDataADMBindingSource;
            // 
            // userSetTableAdapter1
            // 
            this.userSetTableAdapter1.ClearBeforeFill = true;
            // 
            // userSetAdministratorBindingSource1
            // 
            this.userSetAdministratorBindingSource1.DataMember = "UserSet_Administrator";
            this.userSetAdministratorBindingSource1.DataSource = this.baseDadosDataADMBindingSource;
            // 
            // userSet_AdministratorTableAdapter1
            // 
            this.userSet_AdministratorTableAdapter1.ClearBeforeFill = true;
            // 
            // listVADM
            // 
            this.listVADM.Location = new System.Drawing.Point(24, 247);
            this.listVADM.Name = "listVADM";
            this.listVADM.Size = new System.Drawing.Size(206, 99);
            this.listVADM.TabIndex = 39;
            this.listVADM.UseCompatibleStateImageBehavior = false;
            // 
            // Utilizadores_ADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 512);
            this.Controls.Add(this.listVADM);
            this.Controls.Add(this.dataGrid_ARB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Utilizadores_ADM";
            this.Text = "Utilizadores_ADM";
            this.Load += new System.EventHandler(this.Utilizadores_ADM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_ARB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosData_ADM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosDataADMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetAdministratorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDadosData_administrador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userSetAdministratorBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar_ADM;
        private System.Windows.Forms.Button btnAlterar_ADM;
        private System.Windows.Forms.Button btnGuardar_ADM;
        private System.Windows.Forms.TextBox txtbEmail_ADM;
        private System.Windows.Forms.TextBox txtbPassword_ADM;
        private System.Windows.Forms.TextBox txtbNickName_ADM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbPassword_ARB;
        private System.Windows.Forms.TextBox txtbNickName_ARB;
        private System.Windows.Forms.LinkLabel linkLAvatar_ARB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNome_ARB;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAlterar_ARB;
        private System.Windows.Forms.Button btnGuarda_ARB;
        private System.Windows.Forms.DataGridView dataGrid_ARB;
        private System.Windows.Forms.BindingSource baseDadosDataADMBindingSource;
        private BaseDadosData_ADM baseDadosData_ADM;
        private BaseDadosDataSet2 baseDadosDataSet2;
        private System.Windows.Forms.BindingSource userSetBindingSource;
        private BaseDadosDataSet2TableAdapters.UserSetTableAdapter userSetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn1;
        private BaseDadosData_administrador baseDadosData_administrador;
        private System.Windows.Forms.BindingSource userSetAdministratorBindingSource;
        private BaseDadosData_administradorTableAdapters.UserSet_AdministratorTableAdapter userSet_AdministratorTableAdapter;
        private System.Windows.Forms.BindingSource userSetBindingSource1;
        private BaseDadosData_ADMTableAdapters.UserSetTableAdapter userSetTableAdapter1;
        private System.Windows.Forms.BindingSource userSetAdministratorBindingSource1;
        private BaseDadosData_ADMTableAdapters.UserSet_AdministratorTableAdapter userSet_AdministratorTableAdapter1;
        private System.Windows.Forms.ListView listVADM;
    }
}

namespace project_hospital
{
    partial class ClientRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientRegisterForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.clientToolStrip = new System.Windows.Forms.ToolStrip();
            this.homeClientToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.registerClientToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkClientToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clearClientToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showClientTable = new System.Windows.Forms.ToolStripButton();
            this.comboBoxHealthEnsurance = new System.Windows.Forms.ComboBox();
            this.lblHealthEnsurance = new System.Windows.Forms.Label();
            this.dateTimePickerClient = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.userToolStrip = new System.Windows.Forms.ToolStrip();
            this.homeUserToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.registerUserToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkUserToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.clearUserToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showUserTable = new System.Windows.Forms.ToolStripButton();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.dateTimePickerUser = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.groupBoxUserType = new System.Windows.Forms.GroupBox();
            this.rdCompany = new System.Windows.Forms.RadioButton();
            this.rdPatient = new System.Windows.Forms.RadioButton();
            this.rdDoctor = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.clientToolStrip.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.userToolStrip.SuspendLayout();
            this.groupBoxUserType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClient);
            this.tabControl.Controls.Add(this.tabUser);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(519, 469);
            this.tabControl.TabIndex = 0;
            // 
            // tabClient
            // 
            this.tabClient.Controls.Add(this.clientToolStrip);
            this.tabClient.Controls.Add(this.comboBoxHealthEnsurance);
            this.tabClient.Controls.Add(this.lblHealthEnsurance);
            this.tabClient.Controls.Add(this.dateTimePickerClient);
            this.tabClient.Controls.Add(this.label1);
            this.tabClient.Controls.Add(this.textBox3);
            this.tabClient.Controls.Add(this.lblCPF);
            this.tabClient.Controls.Add(this.textBox4);
            this.tabClient.Controls.Add(this.lblClientName);
            this.tabClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabClient.Location = new System.Drawing.Point(4, 27);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(511, 438);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Cliente";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // clientToolStrip
            // 
            this.clientToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.clientToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.clientToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeClientToolStrip,
            this.toolStripSeparator7,
            this.registerClientToolStrip,
            this.toolStripSeparator3,
            this.checkClientToolStrip,
            this.toolStripSeparator2,
            this.clearClientToolStrip,
            this.toolStripSeparator4,
            this.showClientTable});
            this.clientToolStrip.Location = new System.Drawing.Point(3, 3);
            this.clientToolStrip.Name = "clientToolStrip";
            this.clientToolStrip.Size = new System.Drawing.Size(505, 27);
            this.clientToolStrip.TabIndex = 30;
            this.clientToolStrip.Text = "clientToolStrip";
            // 
            // homeClientToolStrip
            // 
            this.homeClientToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeClientToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("homeClientToolStrip.Image")));
            this.homeClientToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeClientToolStrip.Name = "homeClientToolStrip";
            this.homeClientToolStrip.Size = new System.Drawing.Size(29, 24);
            this.homeClientToolStrip.Text = "homeToolStrip";
            this.homeClientToolStrip.Click += new System.EventHandler(this.homeToolStrip_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 27);
            // 
            // registerClientToolStrip
            // 
            this.registerClientToolStrip.Name = "registerClientToolStrip";
            this.registerClientToolStrip.Size = new System.Drawing.Size(72, 24);
            this.registerClientToolStrip.Text = "Cadastrar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // checkClientToolStrip
            // 
            this.checkClientToolStrip.Name = "checkClientToolStrip";
            this.checkClientToolStrip.Size = new System.Drawing.Size(62, 24);
            this.checkClientToolStrip.Text = "Conferir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // clearClientToolStrip
            // 
            this.clearClientToolStrip.Name = "clearClientToolStrip";
            this.clearClientToolStrip.Size = new System.Drawing.Size(55, 24);
            this.clearClientToolStrip.Text = "Limpar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // showClientTable
            // 
            this.showClientTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showClientTable.Image = ((System.Drawing.Image)(resources.GetObject("showClientTable.Image")));
            this.showClientTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showClientTable.Name = "showClientTable";
            this.showClientTable.Size = new System.Drawing.Size(29, 24);
            this.showClientTable.Text = "Visualizar";
            this.showClientTable.ToolTipText = "Visualizar";
            this.showClientTable.Click += new System.EventHandler(this.showClientTable_Click);
            // 
            // comboBoxHealthEnsurance
            // 
            this.comboBoxHealthEnsurance.FormattingEnabled = true;
            this.comboBoxHealthEnsurance.Items.AddRange(new object[] {
            "Bradesco Saúde",
            "Sul América",
            "Hapvida",
            "Unimed",
            "PlanServ"});
            this.comboBoxHealthEnsurance.Location = new System.Drawing.Point(174, 270);
            this.comboBoxHealthEnsurance.Name = "comboBoxHealthEnsurance";
            this.comboBoxHealthEnsurance.Size = new System.Drawing.Size(171, 28);
            this.comboBoxHealthEnsurance.TabIndex = 18;
            this.comboBoxHealthEnsurance.Text = "Nenhum";
            // 
            // lblHealthEnsurance
            // 
            this.lblHealthEnsurance.AutoSize = true;
            this.lblHealthEnsurance.Location = new System.Drawing.Point(196, 230);
            this.lblHealthEnsurance.Name = "lblHealthEnsurance";
            this.lblHealthEnsurance.Size = new System.Drawing.Size(126, 20);
            this.lblHealthEnsurance.TabIndex = 17;
            this.lblHealthEnsurance.Text = "Plano de Saúde";
            // 
            // dateTimePickerClient
            // 
            this.dateTimePickerClient.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerClient.Location = new System.Drawing.Point(174, 363);
            this.dateTimePickerClient.Name = "dateTimePickerClient";
            this.dateTimePickerClient.Size = new System.Drawing.Size(171, 27);
            this.dateTimePickerClient.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data do Cadastro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(174, 171);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 27);
            this.textBox3.TabIndex = 13;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(238, 133);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 20);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(174, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 27);
            this.textBox4.TabIndex = 11;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(233, 52);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(53, 20);
            this.lblClientName.TabIndex = 10;
            this.lblClientName.Text = "Nome";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.userToolStrip);
            this.tabUser.Controls.Add(this.lblRegisterDate);
            this.tabUser.Controls.Add(this.dateTimePickerUser);
            this.tabUser.Controls.Add(this.textBox2);
            this.tabUser.Controls.Add(this.lblPassword);
            this.tabUser.Controls.Add(this.textBox1);
            this.tabUser.Controls.Add(this.lblUsername);
            this.tabUser.Controls.Add(this.groupBoxUserType);
            this.tabUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUser.Location = new System.Drawing.Point(4, 27);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(511, 438);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "Usuário";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // userToolStrip
            // 
            this.userToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.userToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeUserToolStrip,
            this.toolStripSeparator8,
            this.registerUserToolStrip,
            this.toolStripSeparator1,
            this.checkUserToolStrip,
            this.toolStripSeparator5,
            this.clearUserToolStrip,
            this.toolStripSeparator6,
            this.showUserTable});
            this.userToolStrip.Location = new System.Drawing.Point(3, 3);
            this.userToolStrip.Name = "userToolStrip";
            this.userToolStrip.Size = new System.Drawing.Size(505, 27);
            this.userToolStrip.TabIndex = 31;
            this.userToolStrip.Text = "userToolStrip";
            // 
            // homeUserToolStrip
            // 
            this.homeUserToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeUserToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("homeUserToolStrip.Image")));
            this.homeUserToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeUserToolStrip.Name = "homeUserToolStrip";
            this.homeUserToolStrip.Size = new System.Drawing.Size(29, 24);
            this.homeUserToolStrip.Text = "homeToolStrip";
            this.homeUserToolStrip.Click += new System.EventHandler(this.homeUserToolStrip_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // registerUserToolStrip
            // 
            this.registerUserToolStrip.Name = "registerUserToolStrip";
            this.registerUserToolStrip.Size = new System.Drawing.Size(72, 24);
            this.registerUserToolStrip.Text = "Cadastrar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // checkUserToolStrip
            // 
            this.checkUserToolStrip.Name = "checkUserToolStrip";
            this.checkUserToolStrip.Size = new System.Drawing.Size(62, 24);
            this.checkUserToolStrip.Text = "Conferir";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // clearUserToolStrip
            // 
            this.clearUserToolStrip.Name = "clearUserToolStrip";
            this.clearUserToolStrip.Size = new System.Drawing.Size(55, 24);
            this.clearUserToolStrip.Text = "Limpar";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // showUserTable
            // 
            this.showUserTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showUserTable.Image = ((System.Drawing.Image)(resources.GetObject("showUserTable.Image")));
            this.showUserTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showUserTable.Name = "showUserTable";
            this.showUserTable.Size = new System.Drawing.Size(29, 24);
            this.showUserTable.Text = "Visualizar";
            this.showUserTable.Click += new System.EventHandler(this.showUserTable_Click);
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Location = new System.Drawing.Point(189, 336);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(141, 20);
            this.lblRegisterDate.TabIndex = 9;
            this.lblRegisterDate.Text = "Data do Cadastro";
            // 
            // dateTimePickerUser
            // 
            this.dateTimePickerUser.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerUser.Location = new System.Drawing.Point(190, 374);
            this.dateTimePickerUser.Name = "dateTimePickerUser";
            this.dateTimePickerUser.Size = new System.Drawing.Size(138, 27);
            this.dateTimePickerUser.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 27);
            this.textBox2.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(231, 127);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 27);
            this.textBox1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(226, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Usuário";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBoxUserType
            // 
            this.groupBoxUserType.Controls.Add(this.rdCompany);
            this.groupBoxUserType.Controls.Add(this.rdPatient);
            this.groupBoxUserType.Controls.Add(this.rdDoctor);
            this.groupBoxUserType.Location = new System.Drawing.Point(65, 211);
            this.groupBoxUserType.Name = "groupBoxUserType";
            this.groupBoxUserType.Size = new System.Drawing.Size(389, 100);
            this.groupBoxUserType.TabIndex = 7;
            this.groupBoxUserType.TabStop = false;
            this.groupBoxUserType.Text = "Tipo de Usuário";
            // 
            // rdCompany
            // 
            this.rdCompany.AutoSize = true;
            this.rdCompany.Location = new System.Drawing.Point(254, 43);
            this.rdCompany.Name = "rdCompany";
            this.rdCompany.Size = new System.Drawing.Size(97, 24);
            this.rdCompany.TabIndex = 6;
            this.rdCompany.Text = "Empresa";
            this.rdCompany.UseVisualStyleBackColor = true;
            // 
            // rdPatient
            // 
            this.rdPatient.AutoSize = true;
            this.rdPatient.Checked = true;
            this.rdPatient.Location = new System.Drawing.Point(20, 43);
            this.rdPatient.Name = "rdPatient";
            this.rdPatient.Size = new System.Drawing.Size(95, 24);
            this.rdPatient.TabIndex = 4;
            this.rdPatient.TabStop = true;
            this.rdPatient.Text = "Paciente";
            this.rdPatient.UseVisualStyleBackColor = true;
            // 
            // rdDoctor
            // 
            this.rdDoctor.AutoSize = true;
            this.rdDoctor.Location = new System.Drawing.Point(143, 43);
            this.rdDoctor.Name = "rdDoctor";
            this.rdDoctor.Size = new System.Drawing.Size(84, 24);
            this.rdDoctor.TabIndex = 5;
            this.rdDoctor.Text = "Médico";
            this.rdDoctor.UseVisualStyleBackColor = true;
            // 
            // ClientRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 469);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientRegisterForm";
            this.Text = "Cadastro";
            this.tabControl.ResumeLayout(false);
            this.tabClient.ResumeLayout(false);
            this.tabClient.PerformLayout();
            this.clientToolStrip.ResumeLayout(false);
            this.clientToolStrip.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.userToolStrip.ResumeLayout(false);
            this.userToolStrip.PerformLayout();
            this.groupBoxUserType.ResumeLayout(false);
            this.groupBoxUserType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.ComboBox comboBoxHealthEnsurance;
        private System.Windows.Forms.Label lblHealthEnsurance;
        private System.Windows.Forms.DateTimePicker dateTimePickerClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerUser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBoxUserType;
        private System.Windows.Forms.RadioButton rdCompany;
        private System.Windows.Forms.RadioButton rdPatient;
        private System.Windows.Forms.RadioButton rdDoctor;
        private System.Windows.Forms.ToolStrip clientToolStrip;
        private System.Windows.Forms.ToolStripLabel registerClientToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel checkClientToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel clearClientToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton showClientTable;
        private System.Windows.Forms.ToolStrip userToolStrip;
        private System.Windows.Forms.ToolStripLabel registerUserToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel checkUserToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel clearUserToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton showUserTable;
        private System.Windows.Forms.ToolStripButton homeClientToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton homeUserToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}

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
            this.tabUser = new System.Windows.Forms.TabPage();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.rdPatient = new System.Windows.Forms.RadioButton();
            this.rdDoctor = new System.Windows.Forms.RadioButton();
            this.rdCompany = new System.Windows.Forms.RadioButton();
            this.groupBoxUserType = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblClientName = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblHealthEnsurance = new System.Windows.Forms.Label();
            this.comboBoxHealthEnsurance = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabClient.SuspendLayout();
            this.tabUser.SuspendLayout();
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
            this.tabClient.Controls.Add(this.comboBoxHealthEnsurance);
            this.tabClient.Controls.Add(this.lblHealthEnsurance);
            this.tabClient.Controls.Add(this.dateTimePicker2);
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
            // tabUser
            // 
            this.tabUser.Controls.Add(this.lblRegisterDate);
            this.tabUser.Controls.Add(this.dateTimePicker1);
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
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(226, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(67, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Usuário";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(190, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 27);
            this.textBox1.TabIndex = 1;
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
            // rdPatient
            // 
            this.rdPatient.AutoSize = true;
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
            this.rdDoctor.TabStop = true;
            this.rdDoctor.Text = "Médico";
            this.rdDoctor.UseVisualStyleBackColor = true;
            // 
            // rdCompany
            // 
            this.rdCompany.AutoSize = true;
            this.rdCompany.Location = new System.Drawing.Point(254, 43);
            this.rdCompany.Name = "rdCompany";
            this.rdCompany.Size = new System.Drawing.Size(97, 24);
            this.rdCompany.TabIndex = 6;
            this.rdCompany.TabStop = true;
            this.rdCompany.Text = "Empresa";
            this.rdCompany.UseVisualStyleBackColor = true;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.Location = new System.Drawing.Point(194, 336);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(141, 20);
            this.lblRegisterDate.TabIndex = 9;
            this.lblRegisterDate.Text = "Data do Cadastro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data do Cadastro";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(190, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 27);
            this.textBox3.TabIndex = 13;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(238, 125);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 20);
            this.lblCPF.TabIndex = 12;
            this.lblCPF.Text = "CPF";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(190, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(138, 27);
            this.textBox4.TabIndex = 11;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(233, 34);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(53, 20);
            this.lblClientName.TabIndex = 10;
            this.lblClientName.Text = "Nome";
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 350);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(319, 27);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // lblHealthEnsurance
            // 
            this.lblHealthEnsurance.AutoSize = true;
            this.lblHealthEnsurance.Location = new System.Drawing.Point(196, 216);
            this.lblHealthEnsurance.Name = "lblHealthEnsurance";
            this.lblHealthEnsurance.Size = new System.Drawing.Size(126, 20);
            this.lblHealthEnsurance.TabIndex = 17;
            this.lblHealthEnsurance.Text = "Plano de Saúde";
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
            this.comboBoxHealthEnsurance.Location = new System.Drawing.Point(190, 258);
            this.comboBoxHealthEnsurance.Name = "comboBoxHealthEnsurance";
            this.comboBoxHealthEnsurance.Size = new System.Drawing.Size(138, 28);
            this.comboBoxHealthEnsurance.TabIndex = 18;
            this.comboBoxHealthEnsurance.Text = "Nenhum";
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
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.groupBoxUserType.ResumeLayout(false);
            this.groupBoxUserType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.ComboBox comboBoxHealthEnsurance;
        private System.Windows.Forms.Label lblHealthEnsurance;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBoxUserType;
        private System.Windows.Forms.RadioButton rdCompany;
        private System.Windows.Forms.RadioButton rdPatient;
        private System.Windows.Forms.RadioButton rdDoctor;
    }
}
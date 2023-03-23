namespace project_hospital
{
    partial class RegisterUserForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblUserame = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.rdClient = new System.Windows.Forms.RadioButton();
            this.rdDoctor = new System.Windows.Forms.RadioButton();
            this.rdCompany = new System.Windows.Forms.RadioButton();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnCheckEqual = new FontAwesome.Sharp.IconButton();
            this.btnAddUser = new FontAwesome.Sharp.IconButton();
            this.desktopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(280, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 30);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(280, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 30);
            this.textBox1.TabIndex = 6;
            // 
            // lblUserame
            // 
            this.lblUserame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserame.AutoSize = true;
            this.lblUserame.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblUserame.Location = new System.Drawing.Point(147, 55);
            this.lblUserame.Name = "lblUserame";
            this.lblUserame.Size = new System.Drawing.Size(106, 40);
            this.lblUserame.TabIndex = 4;
            this.lblUserame.Text = "Usuário";
            // 
            // desktopPanel
            // 
            this.desktopPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desktopPanel.Controls.Add(this.btnPanel);
            this.desktopPanel.Controls.Add(this.panel1);
            this.desktopPanel.Controls.Add(this.textBox3);
            this.desktopPanel.Controls.Add(this.textBox2);
            this.desktopPanel.Controls.Add(this.lblUserType);
            this.desktopPanel.Controls.Add(this.textBox1);
            this.desktopPanel.Controls.Add(this.lblConfirmPassword);
            this.desktopPanel.Controls.Add(this.lblPassword);
            this.desktopPanel.Controls.Add(this.lblUserame);
            this.desktopPanel.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopPanel.Location = new System.Drawing.Point(0, 0);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(800, 450);
            this.desktopPanel.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblPassword.Location = new System.Drawing.Point(147, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 40);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Senha";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(38, 189);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(216, 40);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirmar Senha";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(280, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 30);
            this.textBox3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.rdCompany);
            this.panel1.Controls.Add(this.rdDoctor);
            this.panel1.Controls.Add(this.rdClient);
            this.panel1.Location = new System.Drawing.Point(312, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 127);
            this.panel1.TabIndex = 7;
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblUserType.Location = new System.Drawing.Point(57, 294);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(197, 40);
            this.lblUserType.TabIndex = 4;
            this.lblUserType.Text = "Tipo de Usuário";
            // 
            // rdClient
            // 
            this.rdClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdClient.AutoSize = true;
            this.rdClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdClient.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdClient.Location = new System.Drawing.Point(15, 3);
            this.rdClient.Name = "rdClient";
            this.rdClient.Size = new System.Drawing.Size(122, 40);
            this.rdClient.TabIndex = 5;
            this.rdClient.TabStop = true;
            this.rdClient.Text = "Paciente";
            this.rdClient.UseVisualStyleBackColor = true;
            // 
            // rdDoctor
            // 
            this.rdDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdDoctor.AutoSize = true;
            this.rdDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdDoctor.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDoctor.Location = new System.Drawing.Point(15, 43);
            this.rdDoctor.Name = "rdDoctor";
            this.rdDoctor.Size = new System.Drawing.Size(108, 40);
            this.rdDoctor.TabIndex = 5;
            this.rdDoctor.TabStop = true;
            this.rdDoctor.Text = "Médico";
            this.rdDoctor.UseVisualStyleBackColor = true;
            // 
            // rdCompany
            // 
            this.rdCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdCompany.AutoSize = true;
            this.rdCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdCompany.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCompany.Location = new System.Drawing.Point(15, 83);
            this.rdCompany.Name = "rdCompany";
            this.rdCompany.Size = new System.Drawing.Size(123, 40);
            this.rdCompany.TabIndex = 5;
            this.rdCompany.TabStop = true;
            this.rdCompany.Text = "Empresa";
            this.rdCompany.UseVisualStyleBackColor = true;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnCheckEqual);
            this.btnPanel.Controls.Add(this.btnAddUser);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPanel.Location = new System.Drawing.Point(628, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(172, 450);
            this.btnPanel.TabIndex = 8;
            // 
            // btnCheckEqual
            // 
            this.btnCheckEqual.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheckEqual.FlatAppearance.BorderSize = 0;
            this.btnCheckEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheckEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckEqual.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnCheckEqual.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnCheckEqual.IconColor = System.Drawing.Color.Black;
            this.btnCheckEqual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckEqual.Location = new System.Drawing.Point(0, 0);
            this.btnCheckEqual.Name = "btnCheckEqual";
            this.btnCheckEqual.Size = new System.Drawing.Size(172, 225);
            this.btnCheckEqual.TabIndex = 4;
            this.btnCheckEqual.Text = "Verificar";
            this.btnCheckEqual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckEqual.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnAddUser.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAddUser.IconColor = System.Drawing.Color.Black;
            this.btnAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddUser.Location = new System.Drawing.Point(0, 225);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(172, 225);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "Adicionar ";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // RegisterUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.desktopPanel);
            this.Name = "RegisterUserForm";
            this.Text = "Cadastrar Usuário";
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblUserame;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdCompany;
        private System.Windows.Forms.RadioButton rdDoctor;
        private System.Windows.Forms.RadioButton rdClient;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Panel btnPanel;
        private FontAwesome.Sharp.IconButton btnCheckEqual;
        private FontAwesome.Sharp.IconButton btnAddUser;
    }
}
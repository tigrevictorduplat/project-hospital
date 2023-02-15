namespace project_hospital
{
    partial class AppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.panel = new System.Windows.Forms.Panel();
            this.comboBoxHealthEnsurance = new System.Windows.Forms.ComboBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.lblDescription);
            this.panel.Controls.Add(this.comboBoxHealthEnsurance);
            this.panel.Controls.Add(this.lblServiceName);
            this.panel.Controls.Add(this.dateTimeAppointment);
            this.panel.Controls.Add(this.lblAppointmentDate);
            this.panel.Controls.Add(this.textBox3);
            this.panel.Controls.Add(this.lblCPF);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(420, 450);
            this.panel.TabIndex = 0;
            // 
            // comboBoxHealthEnsurance
            // 
            this.comboBoxHealthEnsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHealthEnsurance.FormattingEnabled = true;
            this.comboBoxHealthEnsurance.Items.AddRange(new object[] {
            "Bradesco Saúde",
            "Sul América",
            "Hapvida",
            "Unimed",
            "PlanServ"});
            this.comboBoxHealthEnsurance.Location = new System.Drawing.Point(141, 153);
            this.comboBoxHealthEnsurance.Name = "comboBoxHealthEnsurance";
            this.comboBoxHealthEnsurance.Size = new System.Drawing.Size(138, 28);
            this.comboBoxHealthEnsurance.TabIndex = 26;
            this.comboBoxHealthEnsurance.Text = "Nenhum";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(178, 114);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(65, 20);
            this.lblServiceName.TabIndex = 25;
            this.lblServiceName.Text = "Serviço";
            // 
            // dateTimeAppointment
            // 
            this.dateTimeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAppointment.Location = new System.Drawing.Point(51, 366);
            this.dateTimeAppointment.Name = "dateTimeAppointment";
            this.dateTimeAppointment.Size = new System.Drawing.Size(319, 27);
            this.dateTimeAppointment.TabIndex = 24;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(123, 327);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(175, 20);
            this.lblAppointmentDate.TabIndex = 23;
            this.lblAppointmentDate.Text = "Data do Agendamento";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(141, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 27);
            this.textBox3.TabIndex = 22;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(189, 29);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 20);
            this.lblCPF.TabIndex = 21;
            this.lblCPF.Text = "CPF";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(167, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 20);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Descrição";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 239);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 69);
            this.textBox1.TabIndex = 28;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentForm";
            this.Text = "Agendamento";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox comboBoxHealthEnsurance;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDescription;
    }
}
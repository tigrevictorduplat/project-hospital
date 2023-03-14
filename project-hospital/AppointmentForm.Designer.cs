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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.scheduleToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.checkToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAppointmentTable = new System.Windows.Forms.ToolStripButton();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboBoxServices = new System.Windows.Forms.ComboBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.txtBoxCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.homeToolStrip = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.toolStrip);
            this.panel.Controls.Add(this.txtBoxDescription);
            this.panel.Controls.Add(this.lblDescription);
            this.panel.Controls.Add(this.comboBoxServices);
            this.panel.Controls.Add(this.lblServiceName);
            this.panel.Controls.Add(this.dateTimeAppointment);
            this.panel.Controls.Add(this.lblAppointmentDate);
            this.panel.Controls.Add(this.txtBoxCPF);
            this.panel.Controls.Add(this.lblCPF);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(420, 450);
            this.panel.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStrip,
            this.toolStripSeparator4,
            this.scheduleToolStrip,
            this.toolStripSeparator3,
            this.checkToolStrip,
            this.toolStripSeparator1,
            this.clearToolStrip,
            this.toolStripSeparator2,
            this.showAppointmentTable});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(420, 27);
            this.toolStrip.TabIndex = 29;
            this.toolStrip.Text = "toolStrip";
            // 
            // scheduleToolStrip
            // 
            this.scheduleToolStrip.Name = "scheduleToolStrip";
            this.scheduleToolStrip.Size = new System.Drawing.Size(66, 24);
            this.scheduleToolStrip.Text = "Agendar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // checkToolStrip
            // 
            this.checkToolStrip.Name = "checkToolStrip";
            this.checkToolStrip.Size = new System.Drawing.Size(62, 24);
            this.checkToolStrip.Text = "Conferir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // clearToolStrip
            // 
            this.clearToolStrip.Name = "clearToolStrip";
            this.clearToolStrip.Size = new System.Drawing.Size(55, 24);
            this.clearToolStrip.Text = "Limpar";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // showAppointmentTable
            // 
            this.showAppointmentTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.showAppointmentTable.Image = ((System.Drawing.Image)(resources.GetObject("showAppointmentTable.Image")));
            this.showAppointmentTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showAppointmentTable.Name = "showAppointmentTable";
            this.showAppointmentTable.Size = new System.Drawing.Size(29, 24);
            this.showAppointmentTable.Text = "Visualizar";
            this.showAppointmentTable.Click += new System.EventHandler(this.showAppointmentTable_Click);
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(91, 255);
            this.txtBoxDescription.Multiline = true;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(239, 69);
            this.txtBoxDescription.TabIndex = 28;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(167, 216);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 20);
            this.lblDescription.TabIndex = 27;
            this.lblDescription.Text = "Descrição";
            // 
            // comboBoxServices
            // 
            this.comboBoxServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxServices.FormattingEnabled = true;
            this.comboBoxServices.Items.AddRange(new object[] {
            "Bradesco Saúde",
            "Sul América",
            "Hapvida",
            "Unimed",
            "PlanServ"});
            this.comboBoxServices.Location = new System.Drawing.Point(141, 169);
            this.comboBoxServices.Name = "comboBoxServices";
            this.comboBoxServices.Size = new System.Drawing.Size(138, 28);
            this.comboBoxServices.TabIndex = 26;
            this.comboBoxServices.Text = "Nenhum";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.Location = new System.Drawing.Point(178, 130);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(65, 20);
            this.lblServiceName.TabIndex = 25;
            this.lblServiceName.Text = "Serviço";
            // 
            // dateTimeAppointment
            // 
            this.dateTimeAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAppointment.Location = new System.Drawing.Point(51, 383);
            this.dateTimeAppointment.Name = "dateTimeAppointment";
            this.dateTimeAppointment.Size = new System.Drawing.Size(319, 27);
            this.dateTimeAppointment.TabIndex = 24;
            // 
            // lblAppointmentDate
            // 
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDate.Location = new System.Drawing.Point(123, 344);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(175, 20);
            this.lblAppointmentDate.TabIndex = 23;
            this.lblAppointmentDate.Text = "Data do Agendamento";
            // 
            // txtBoxCPF
            // 
            this.txtBoxCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPF.Location = new System.Drawing.Point(141, 84);
            this.txtBoxCPF.Name = "txtBoxCPF";
            this.txtBoxCPF.Size = new System.Drawing.Size(138, 27);
            this.txtBoxCPF.TabIndex = 22;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(189, 45);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 20);
            this.lblCPF.TabIndex = 21;
            this.lblCPF.Text = "CPF";
            // 
            // homeToolStrip
            // 
            this.homeToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStrip.Image")));
            this.homeToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeToolStrip.Name = "homeToolStrip";
            this.homeToolStrip.Size = new System.Drawing.Size(29, 24);
            this.homeToolStrip.Text = "homeToolStrip";
            this.homeToolStrip.Click += new System.EventHandler(this.homeToolStrip_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox comboBoxServices;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.TextBox txtBoxCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel clearToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel checkToolStrip;
        private System.Windows.Forms.ToolStripButton showAppointmentTable;
        private System.Windows.Forms.ToolStripLabel scheduleToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton homeToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}
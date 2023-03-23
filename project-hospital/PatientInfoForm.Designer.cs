namespace project_hospital
{
    partial class PatientInfoForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.iconDoctor = new FontAwesome.Sharp.IconPictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPatientsNumber = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.colDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.iconDoctor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.dataPanel.SuspendLayout();
            this.desktopPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 40);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nome do Paciente";
            // 
            // iconDoctor
            // 
            this.iconDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.iconDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.iconDoctor.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.iconDoctor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.iconDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDoctor.IconSize = 142;
            this.iconDoctor.Location = new System.Drawing.Point(606, 143);
            this.iconDoctor.Name = "iconDoctor";
            this.iconDoctor.Size = new System.Drawing.Size(147, 142);
            this.iconDoctor.TabIndex = 3;
            this.iconDoctor.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(137, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "00";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(316, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "00";
            // 
            // lblPatientsNumber
            // 
            this.lblPatientsNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPatientsNumber.AutoSize = true;
            this.lblPatientsNumber.BackColor = System.Drawing.Color.White;
            this.lblPatientsNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPatientsNumber.Location = new System.Drawing.Point(36, 195);
            this.lblPatientsNumber.Name = "lblPatientsNumber";
            this.lblPatientsNumber.Size = new System.Drawing.Size(37, 32);
            this.lblPatientsNumber.TabIndex = 2;
            this.lblPatientsNumber.Text = "00";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Serviços Marcados";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Consultas Totais";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultas Mensais";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.searchButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchButton.IconSize = 36;
            this.searchButton.Location = new System.Drawing.Point(606, 48);
            this.searchButton.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(147, 48);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Buscar";
            this.searchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.textBox1.Location = new System.Drawing.Point(48, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Digite o nome do(a) paciente ...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDoctor,
            this.colService,
            this.colDate,
            this.colPrice});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(800, 118);
            this.dataGridView.TabIndex = 1;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataGridView);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(0, 332);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(800, 118);
            this.dataPanel.TabIndex = 6;
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.desktopPanel.Controls.Add(this.label8);
            this.desktopPanel.Controls.Add(this.iconDoctor);
            this.desktopPanel.Controls.Add(this.label7);
            this.desktopPanel.Controls.Add(this.label5);
            this.desktopPanel.Controls.Add(this.lblPatientsNumber);
            this.desktopPanel.Controls.Add(this.label6);
            this.desktopPanel.Controls.Add(this.label4);
            this.desktopPanel.Controls.Add(this.label1);
            this.desktopPanel.Controls.Add(this.searchButton);
            this.desktopPanel.Controls.Add(this.textBox1);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.desktopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.desktopPanel.Location = new System.Drawing.Point(0, 0);
            this.desktopPanel.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(800, 332);
            this.desktopPanel.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.dataPanel);
            this.mainPanel.Controls.Add(this.desktopPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 450);
            this.mainPanel.TabIndex = 1;
            // 
            // colDoctor
            // 
            this.colDoctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDoctor.HeaderText = "Médicos";
            this.colDoctor.MinimumWidth = 6;
            this.colDoctor.Name = "colDoctor";
            this.colDoctor.ReadOnly = true;
            // 
            // colService
            // 
            this.colService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colService.HeaderText = "Serviço Marcado";
            this.colService.MinimumWidth = 6;
            this.colService.Name = "colService";
            this.colService.ReadOnly = true;
            // 
            // colDate
            // 
            this.colDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDate.HeaderText = "Data da Consulta";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPrice.HeaderText = "Custo Serviço";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "PatientInfoForm";
            this.Text = "Consultar Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.iconDoctor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.dataPanel.ResumeLayout(false);
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconPictureBox iconDoctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPatientsNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
    }
}
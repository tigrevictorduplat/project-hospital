namespace project_hospital
{
    partial class RegisterServiceForm
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
            this.lblServiceName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.btnAddService = new FontAwesome.Sharp.IconButton();
            this.btnCheckEqual = new FontAwesome.Sharp.IconButton();
            this.desktopPanel.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServiceName
            // 
            this.lblServiceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblServiceName.Location = new System.Drawing.Point(299, 21);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(213, 40);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Nome do Serviço";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(299, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 27);
            this.textBox1.TabIndex = 1;
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblServiceDescription.Location = new System.Drawing.Point(275, 142);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(260, 40);
            this.lblServiceDescription.TabIndex = 0;
            this.lblServiceDescription.Text = "Descrição do Serviço";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(299, 211);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 81);
            this.textBox2.TabIndex = 1;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblServicePrice.Location = new System.Drawing.Point(301, 321);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(209, 40);
            this.lblServicePrice.TabIndex = 0;
            this.lblServicePrice.Text = "Preço do Serviço";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(299, 390);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 27);
            this.textBox3.TabIndex = 1;
            // 
            // desktopPanel
            // 
            this.desktopPanel.Controls.Add(this.textBox3);
            this.desktopPanel.Controls.Add(this.lblServicePrice);
            this.desktopPanel.Controls.Add(this.btnPanel);
            this.desktopPanel.Controls.Add(this.lblServiceName);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopPanel.Location = new System.Drawing.Point(0, 0);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(800, 450);
            this.desktopPanel.TabIndex = 2;
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.btnCheckEqual);
            this.btnPanel.Controls.Add(this.btnAddService);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPanel.Location = new System.Drawing.Point(628, 0);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(172, 450);
            this.btnPanel.TabIndex = 3;
            // 
            // btnAddService
            // 
            this.btnAddService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddService.FlatAppearance.BorderSize = 0;
            this.btnAddService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnAddService.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAddService.IconColor = System.Drawing.Color.Black;
            this.btnAddService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddService.Location = new System.Drawing.Point(0, 225);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(172, 225);
            this.btnAddService.TabIndex = 2;
            this.btnAddService.Text = "Adicionar ";
            this.btnAddService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddService.UseVisualStyleBackColor = true;
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
            // RegisterServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.desktopPanel);
            this.Name = "RegisterServiceForm";
            this.Text = "Cadastro de Serviço";
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel desktopPanel;
        private FontAwesome.Sharp.IconButton btnAddService;
        private System.Windows.Forms.Panel btnPanel;
        private FontAwesome.Sharp.IconButton btnCheckEqual;
    }
}
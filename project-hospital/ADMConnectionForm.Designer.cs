namespace project_hospital
{
    partial class ADMConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMConnectionForm));
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblCurrentPageTitle = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserame = new System.Windows.Forms.Label();
            this.topBarExit = new FontAwesome.Sharp.IconPictureBox();
            this.topBarResize = new FontAwesome.Sharp.IconPictureBox();
            this.topBarMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.currentPageIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnAttemptConnection = new FontAwesome.Sharp.IconButton();
            this.desktopPanel.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBarExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // desktopPanel
            // 
            this.desktopPanel.Controls.Add(this.panelTopBar);
            this.desktopPanel.Controls.Add(this.btnAttemptConnection);
            this.desktopPanel.Controls.Add(this.txtPassword);
            this.desktopPanel.Controls.Add(this.txtUsername);
            this.desktopPanel.Controls.Add(this.lblPassword);
            this.desktopPanel.Controls.Add(this.lblUserame);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 0);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(406, 412);
            this.desktopPanel.TabIndex = 0;
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.panelTopBar.Controls.Add(this.lblCurrentPageTitle);
            this.panelTopBar.Controls.Add(this.topBarExit);
            this.panelTopBar.Controls.Add(this.topBarResize);
            this.panelTopBar.Controls.Add(this.topBarMinimize);
            this.panelTopBar.Controls.Add(this.currentPageIcon);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(406, 50);
            this.panelTopBar.TabIndex = 13;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // lblCurrentPageTitle
            // 
            this.lblCurrentPageTitle.AutoSize = true;
            this.lblCurrentPageTitle.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(172)))));
            this.lblCurrentPageTitle.Location = new System.Drawing.Point(58, 17);
            this.lblCurrentPageTitle.Name = "lblCurrentPageTitle";
            this.lblCurrentPageTitle.Size = new System.Drawing.Size(120, 23);
            this.lblCurrentPageTitle.TabIndex = 1;
            this.lblCurrentPageTitle.Text = "Login do Sistema";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(85, 238);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(238, 25);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(230)))), ((int)(((byte)(232)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(85, 133);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(238, 25);
            this.txtUsername.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblPassword.Location = new System.Drawing.Point(159, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(88, 32);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Senha";
            // 
            // lblUserame
            // 
            this.lblUserame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserame.AutoSize = true;
            this.lblUserame.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.lblUserame.Location = new System.Drawing.Point(151, 77);
            this.lblUserame.Name = "lblUserame";
            this.lblUserame.Size = new System.Drawing.Size(101, 32);
            this.lblUserame.TabIndex = 10;
            this.lblUserame.Text = "Usuário";
            // 
            // topBarExit
            // 
            this.topBarExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.topBarExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.topBarExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topBarExit.Location = new System.Drawing.Point(352, 9);
            this.topBarExit.Name = "topBarExit";
            this.topBarExit.Size = new System.Drawing.Size(32, 32);
            this.topBarExit.TabIndex = 0;
            this.topBarExit.TabStop = false;
            this.topBarExit.Click += new System.EventHandler(this.topBarExit_Click);
            // 
            // topBarResize
            // 
            this.topBarResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.topBarResize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarResize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.topBarResize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarResize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topBarResize.Location = new System.Drawing.Point(314, 9);
            this.topBarResize.Name = "topBarResize";
            this.topBarResize.Size = new System.Drawing.Size(32, 32);
            this.topBarResize.TabIndex = 0;
            this.topBarResize.TabStop = false;
            this.topBarResize.Click += new System.EventHandler(this.topBarResize_Click);
            // 
            // topBarMinimize
            // 
            this.topBarMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.topBarMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.topBarMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topBarMinimize.Location = new System.Drawing.Point(276, 9);
            this.topBarMinimize.Name = "topBarMinimize";
            this.topBarMinimize.Size = new System.Drawing.Size(32, 32);
            this.topBarMinimize.TabIndex = 0;
            this.topBarMinimize.TabStop = false;
            this.topBarMinimize.Click += new System.EventHandler(this.topBarMinimize_Click);
            // 
            // currentPageIcon
            // 
            this.currentPageIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.currentPageIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(172)))));
            this.currentPageIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.currentPageIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(172)))));
            this.currentPageIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentPageIcon.Location = new System.Drawing.Point(20, 9);
            this.currentPageIcon.Name = "currentPageIcon";
            this.currentPageIcon.Size = new System.Drawing.Size(32, 32);
            this.currentPageIcon.TabIndex = 0;
            this.currentPageIcon.TabStop = false;
            // 
            // btnAttemptConnection
            // 
            this.btnAttemptConnection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAttemptConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAttemptConnection.FlatAppearance.BorderSize = 0;
            this.btnAttemptConnection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAttemptConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttemptConnection.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttemptConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnAttemptConnection.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnAttemptConnection.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnAttemptConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAttemptConnection.Location = new System.Drawing.Point(85, 304);
            this.btnAttemptConnection.Name = "btnAttemptConnection";
            this.btnAttemptConnection.Size = new System.Drawing.Size(238, 60);
            this.btnAttemptConnection.TabIndex = 2;
            this.btnAttemptConnection.Text = "Conectar";
            this.btnAttemptConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttemptConnection.UseVisualStyleBackColor = false;
            this.btnAttemptConnection.Click += new System.EventHandler(this.btnAttemptConnection_Click);
            // 
            // ADMConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(406, 412);
            this.Controls.Add(this.desktopPanel);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(424, 459);
            this.Name = "ADMConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexão Banco de Dados";
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBarExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel desktopPanel;
        private FontAwesome.Sharp.IconButton btnAttemptConnection;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserame;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblCurrentPageTitle;
        private FontAwesome.Sharp.IconPictureBox topBarExit;
        private FontAwesome.Sharp.IconPictureBox topBarResize;
        private FontAwesome.Sharp.IconPictureBox topBarMinimize;
        private FontAwesome.Sharp.IconPictureBox currentPageIcon;
    }
}
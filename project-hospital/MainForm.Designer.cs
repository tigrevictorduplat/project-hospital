
namespace project_hospital
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.subMenuViewPanel = new System.Windows.Forms.Panel();
            this.btnViewPatientsTable = new FontAwesome.Sharp.IconButton();
            this.btnViewServicesTable = new FontAwesome.Sharp.IconButton();
            this.btnViewDoctorsTable = new FontAwesome.Sharp.IconButton();
            this.btnViewTable = new FontAwesome.Sharp.IconButton();
            this.btnAppointment = new FontAwesome.Sharp.IconButton();
            this.subMenuRegisterPanel = new System.Windows.Forms.Panel();
            this.btnUserRegister = new FontAwesome.Sharp.IconButton();
            this.btnPatientRegister = new FontAwesome.Sharp.IconButton();
            this.btnServiceRegister = new FontAwesome.Sharp.IconButton();
            this.btnRegistrer = new FontAwesome.Sharp.IconButton();
            this.panelHomeIcon = new System.Windows.Forms.Panel();
            this.btnLogoHome = new System.Windows.Forms.PictureBox();
            this.hospitalLogo = new System.Windows.Forms.PictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblCurrentPageTitle = new System.Windows.Forms.Label();
            this.topBarExit = new FontAwesome.Sharp.IconPictureBox();
            this.topBarResize = new FontAwesome.Sharp.IconPictureBox();
            this.topBarMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.currentPageIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelSideBar.SuspendLayout();
            this.subMenuViewPanel.SuspendLayout();
            this.subMenuRegisterPanel.SuspendLayout();
            this.panelHomeIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogoHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalLogo)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBarExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPageIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(1)))), ((int)(((byte)(30)))));
            this.panelSideBar.Controls.Add(this.subMenuViewPanel);
            this.panelSideBar.Controls.Add(this.btnViewTable);
            this.panelSideBar.Controls.Add(this.btnAppointment);
            this.panelSideBar.Controls.Add(this.subMenuRegisterPanel);
            this.panelSideBar.Controls.Add(this.btnRegistrer);
            this.panelSideBar.Controls.Add(this.panelHomeIcon);
            this.panelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(214, 538);
            this.panelSideBar.TabIndex = 4;
            // 
            // subMenuViewPanel
            // 
            this.subMenuViewPanel.Controls.Add(this.btnViewPatientsTable);
            this.subMenuViewPanel.Controls.Add(this.btnViewServicesTable);
            this.subMenuViewPanel.Controls.Add(this.btnViewDoctorsTable);
            this.subMenuViewPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuViewPanel.Location = new System.Drawing.Point(0, 375);
            this.subMenuViewPanel.Name = "subMenuViewPanel";
            this.subMenuViewPanel.Size = new System.Drawing.Size(214, 90);
            this.subMenuViewPanel.TabIndex = 7;
            // 
            // btnViewPatientsTable
            // 
            this.btnViewPatientsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnViewPatientsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewPatientsTable.FlatAppearance.BorderSize = 0;
            this.btnViewPatientsTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPatientsTable.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatientsTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnViewPatientsTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewPatientsTable.IconColor = System.Drawing.Color.White;
            this.btnViewPatientsTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewPatientsTable.IconSize = 24;
            this.btnViewPatientsTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPatientsTable.Location = new System.Drawing.Point(0, 60);
            this.btnViewPatientsTable.Name = "btnViewPatientsTable";
            this.btnViewPatientsTable.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnViewPatientsTable.Size = new System.Drawing.Size(214, 30);
            this.btnViewPatientsTable.TabIndex = 9;
            this.btnViewPatientsTable.Text = "Pacientes";
            this.btnViewPatientsTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewPatientsTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewPatientsTable.UseVisualStyleBackColor = false;
            this.btnViewPatientsTable.Click += new System.EventHandler(this.btnViewPatientsTable_Click);
            // 
            // btnViewServicesTable
            // 
            this.btnViewServicesTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnViewServicesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewServicesTable.FlatAppearance.BorderSize = 0;
            this.btnViewServicesTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewServicesTable.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewServicesTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnViewServicesTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewServicesTable.IconColor = System.Drawing.Color.White;
            this.btnViewServicesTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewServicesTable.IconSize = 24;
            this.btnViewServicesTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewServicesTable.Location = new System.Drawing.Point(0, 30);
            this.btnViewServicesTable.Name = "btnViewServicesTable";
            this.btnViewServicesTable.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnViewServicesTable.Size = new System.Drawing.Size(214, 30);
            this.btnViewServicesTable.TabIndex = 7;
            this.btnViewServicesTable.Text = "Serviços";
            this.btnViewServicesTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewServicesTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewServicesTable.UseVisualStyleBackColor = false;
            this.btnViewServicesTable.Click += new System.EventHandler(this.btnViewServicesTable_Click);
            // 
            // btnViewDoctorsTable
            // 
            this.btnViewDoctorsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnViewDoctorsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewDoctorsTable.FlatAppearance.BorderSize = 0;
            this.btnViewDoctorsTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDoctorsTable.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDoctorsTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnViewDoctorsTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnViewDoctorsTable.IconColor = System.Drawing.Color.White;
            this.btnViewDoctorsTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewDoctorsTable.IconSize = 24;
            this.btnViewDoctorsTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDoctorsTable.Location = new System.Drawing.Point(0, 0);
            this.btnViewDoctorsTable.Name = "btnViewDoctorsTable";
            this.btnViewDoctorsTable.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnViewDoctorsTable.Size = new System.Drawing.Size(214, 30);
            this.btnViewDoctorsTable.TabIndex = 8;
            this.btnViewDoctorsTable.Text = "Médicos";
            this.btnViewDoctorsTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDoctorsTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewDoctorsTable.UseVisualStyleBackColor = false;
            this.btnViewDoctorsTable.Click += new System.EventHandler(this.btnViewDoctorsTable_Click);
            // 
            // btnViewTable
            // 
            this.btnViewTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewTable.FlatAppearance.BorderSize = 0;
            this.btnViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTable.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTable.ForeColor = System.Drawing.Color.White;
            this.btnViewTable.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnViewTable.IconColor = System.Drawing.Color.White;
            this.btnViewTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnViewTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTable.Location = new System.Drawing.Point(0, 315);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnViewTable.Size = new System.Drawing.Size(214, 60);
            this.btnViewTable.TabIndex = 6;
            this.btnViewTable.Text = "Consultar";
            this.btnViewTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppointment.FlatAppearance.BorderSize = 0;
            this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointment.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAppointment.IconChar = FontAwesome.Sharp.IconChar.CalendarPlus;
            this.btnAppointment.IconColor = System.Drawing.Color.White;
            this.btnAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Location = new System.Drawing.Point(0, 255);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAppointment.Size = new System.Drawing.Size(214, 60);
            this.btnAppointment.TabIndex = 5;
            this.btnAppointment.Text = "Agendamento";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // subMenuRegisterPanel
            // 
            this.subMenuRegisterPanel.Controls.Add(this.btnUserRegister);
            this.subMenuRegisterPanel.Controls.Add(this.btnPatientRegister);
            this.subMenuRegisterPanel.Controls.Add(this.btnServiceRegister);
            this.subMenuRegisterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuRegisterPanel.Location = new System.Drawing.Point(0, 164);
            this.subMenuRegisterPanel.Name = "subMenuRegisterPanel";
            this.subMenuRegisterPanel.Size = new System.Drawing.Size(214, 91);
            this.subMenuRegisterPanel.TabIndex = 2;
            // 
            // btnUserRegister
            // 
            this.btnUserRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnUserRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserRegister.FlatAppearance.BorderSize = 0;
            this.btnUserRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserRegister.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnUserRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserRegister.IconColor = System.Drawing.Color.White;
            this.btnUserRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserRegister.IconSize = 24;
            this.btnUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRegister.Location = new System.Drawing.Point(0, 60);
            this.btnUserRegister.Name = "btnUserRegister";
            this.btnUserRegister.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnUserRegister.Size = new System.Drawing.Size(214, 30);
            this.btnUserRegister.TabIndex = 2;
            this.btnUserRegister.Text = "Usuário";
            this.btnUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserRegister.UseVisualStyleBackColor = false;
            this.btnUserRegister.Click += new System.EventHandler(this.btnUserRegister_Click);
            // 
            // btnPatientRegister
            // 
            this.btnPatientRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnPatientRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientRegister.FlatAppearance.BorderSize = 0;
            this.btnPatientRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientRegister.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnPatientRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPatientRegister.IconColor = System.Drawing.Color.White;
            this.btnPatientRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPatientRegister.IconSize = 24;
            this.btnPatientRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientRegister.Location = new System.Drawing.Point(0, 30);
            this.btnPatientRegister.Name = "btnPatientRegister";
            this.btnPatientRegister.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnPatientRegister.Size = new System.Drawing.Size(214, 30);
            this.btnPatientRegister.TabIndex = 3;
            this.btnPatientRegister.Text = "Paciente";
            this.btnPatientRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientRegister.UseVisualStyleBackColor = false;
            this.btnPatientRegister.Click += new System.EventHandler(this.btnPatientRegister_Click);
            // 
            // btnServiceRegister
            // 
            this.btnServiceRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.btnServiceRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServiceRegister.FlatAppearance.BorderSize = 0;
            this.btnServiceRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRegister.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.btnServiceRegister.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnServiceRegister.IconColor = System.Drawing.Color.White;
            this.btnServiceRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServiceRegister.IconSize = 24;
            this.btnServiceRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceRegister.Location = new System.Drawing.Point(0, 0);
            this.btnServiceRegister.Name = "btnServiceRegister";
            this.btnServiceRegister.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnServiceRegister.Size = new System.Drawing.Size(214, 30);
            this.btnServiceRegister.TabIndex = 4;
            this.btnServiceRegister.Text = "Serviço";
            this.btnServiceRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServiceRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServiceRegister.UseVisualStyleBackColor = false;
            this.btnServiceRegister.Click += new System.EventHandler(this.btnServiceRegister_Click);
            // 
            // btnRegistrer
            // 
            this.btnRegistrer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrer.FlatAppearance.BorderSize = 0;
            this.btnRegistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrer.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrer.ForeColor = System.Drawing.Color.White;
            this.btnRegistrer.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegistrer.IconColor = System.Drawing.Color.White;
            this.btnRegistrer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrer.Location = new System.Drawing.Point(0, 104);
            this.btnRegistrer.Name = "btnRegistrer";
            this.btnRegistrer.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRegistrer.Size = new System.Drawing.Size(214, 60);
            this.btnRegistrer.TabIndex = 1;
            this.btnRegistrer.Text = "Cadastrar";
            this.btnRegistrer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrer.UseVisualStyleBackColor = true;
            this.btnRegistrer.Click += new System.EventHandler(this.btnRegistrer_Click);
            // 
            // panelHomeIcon
            // 
            this.panelHomeIcon.Controls.Add(this.btnLogoHome);
            this.panelHomeIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHomeIcon.Location = new System.Drawing.Point(0, 0);
            this.panelHomeIcon.Name = "panelHomeIcon";
            this.panelHomeIcon.Size = new System.Drawing.Size(214, 104);
            this.panelHomeIcon.TabIndex = 0;
            // 
            // btnLogoHome
            // 
            this.btnLogoHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogoHome.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoHome.Image")));
            this.btnLogoHome.Location = new System.Drawing.Point(49, 4);
            this.btnLogoHome.Name = "btnLogoHome";
            this.btnLogoHome.Size = new System.Drawing.Size(123, 97);
            this.btnLogoHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogoHome.TabIndex = 5;
            this.btnLogoHome.TabStop = false;
            this.btnLogoHome.Click += new System.EventHandler(this.btnLogoHome_Click);
            // 
            // hospitalLogo
            // 
            this.hospitalLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hospitalLogo.Image = ((System.Drawing.Image)(resources.GetObject("hospitalLogo.Image")));
            this.hospitalLogo.Location = new System.Drawing.Point(390, 91);
            this.hospitalLogo.Name = "hospitalLogo";
            this.hospitalLogo.Size = new System.Drawing.Size(400, 400);
            this.hospitalLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hospitalLogo.TabIndex = 5;
            this.hospitalLogo.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(208)))));
            this.panelDesktop.Controls.Add(this.panelTopBar);
            this.panelDesktop.Controls.Add(this.hospitalLogo);
            this.panelDesktop.Controls.Add(this.panelSideBar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1022, 538);
            this.panelDesktop.TabIndex = 0;
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
            this.panelTopBar.Location = new System.Drawing.Point(214, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(808, 50);
            this.panelTopBar.TabIndex = 8;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            // 
            // lblCurrentPageTitle
            // 
            this.lblCurrentPageTitle.AutoSize = true;
            this.lblCurrentPageTitle.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(172)))));
            this.lblCurrentPageTitle.Location = new System.Drawing.Point(58, 17);
            this.lblCurrentPageTitle.Name = "lblCurrentPageTitle";
            this.lblCurrentPageTitle.Size = new System.Drawing.Size(48, 23);
            this.lblCurrentPageTitle.TabIndex = 1;
            this.lblCurrentPageTitle.Text = "Home";
            // 
            // topBarExit
            // 
            this.topBarExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.topBarExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(1)))), ((int)(((byte)(25)))));
            this.topBarExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.topBarExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(229)))), ((int)(((byte)(232)))));
            this.topBarExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.topBarExit.Location = new System.Drawing.Point(754, 9);
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
            this.topBarResize.Location = new System.Drawing.Point(716, 9);
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
            this.topBarMinimize.Location = new System.Drawing.Point(678, 9);
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
            this.currentPageIcon.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            this.currentPageIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(172)))));
            this.currentPageIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentPageIcon.Location = new System.Drawing.Point(20, 9);
            this.currentPageIcon.Name = "currentPageIcon";
            this.currentPageIcon.Size = new System.Drawing.Size(32, 32);
            this.currentPageIcon.TabIndex = 0;
            this.currentPageIcon.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 538);
            this.Controls.Add(this.panelDesktop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1040, 585);
            this.Name = "MainForm";
            this.Text = "Hospital Santo Arnaldo";
            this.panelSideBar.ResumeLayout(false);
            this.subMenuViewPanel.ResumeLayout(false);
            this.subMenuRegisterPanel.ResumeLayout(false);
            this.panelHomeIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogoHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalLogo)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topBarExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topBarMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPageIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private FontAwesome.Sharp.IconButton btnViewPatientsTable;
        private FontAwesome.Sharp.IconButton btnViewDoctorsTable;
        private FontAwesome.Sharp.IconButton btnViewServicesTable;
        private FontAwesome.Sharp.IconButton btnViewTable;
        private FontAwesome.Sharp.IconButton btnAppointment;
        private FontAwesome.Sharp.IconButton btnRegistrer;
        private System.Windows.Forms.PictureBox hospitalLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Label lblCurrentPageTitle;
        private FontAwesome.Sharp.IconPictureBox currentPageIcon;
        private FontAwesome.Sharp.IconButton btnServiceRegister;
        private FontAwesome.Sharp.IconButton btnPatientRegister;
        private FontAwesome.Sharp.IconButton btnUserRegister;
        private System.Windows.Forms.Panel panelHomeIcon;
        private System.Windows.Forms.PictureBox btnLogoHome;
        private System.Windows.Forms.Panel subMenuRegisterPanel;
        private System.Windows.Forms.Panel subMenuViewPanel;
        private FontAwesome.Sharp.IconPictureBox topBarExit;
        private FontAwesome.Sharp.IconPictureBox topBarResize;
        private FontAwesome.Sharp.IconPictureBox topBarMinimize;
    }
}


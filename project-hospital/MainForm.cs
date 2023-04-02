using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MySql.Data.MySqlClient;

namespace project_hospital
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderPanel;
        private Form currentChildForm;
        private MySqlConnection connection;
        public MainForm()
        {
            InitializeComponent();
            InitialSettings();
        }

        private void InitialSettings()
        {
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(6, 60);
            panelSideBar.Controls.Add(leftBorderPanel);
            //Hide SubMenus
            subMenuRegisterPanel.Visible = false;
            subMenuViewPanel.Visible = false;
            //Hide Form Border
            this.Text = "";
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        public void setConnection( MySqlConnection con)
        {
            this.connection = con;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //Closing Last Open Form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblCurrentPageTitle.Text = childForm.Text;
        }

        #region Top Bar Controls
        private void topBarExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void topBarResize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            } else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void topBarMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
                private extern static void ReleaseCapture();
                [DllImport("user32.DLL", EntryPoint = "SendMessage")]
                private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
                private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
        #endregion
           
        #region Register Section
        private void btnServiceRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterServiceForm());
            
        }
        private void btnPatientRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterPatientForm());
            
        }
        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterUserForm());
           
        }
        #endregion
        
        #region View Table Section
        private void btnViewDoctorsTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoctorsInfoForm());
        }
        private void btnViewServicesTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ServicesInfoForm());
        }
        private void btnViewPatientsTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PatientInfoForm());
        }
        #endregion
        
        #region Button Transform
                private void ActivateButton(object senderBtn)
                {
                    if (senderBtn != null)
                    {
                        DisableButton();
                        Color activecolor = Color.FromArgb(81, 1, 23);
                        //Changing Button
                        currentButton = (IconButton)senderBtn;
                        currentButton.BackColor = Color.FromArgb(251, 229, 232);
                        currentButton.ForeColor = activecolor;
                        currentButton.TextAlign = ContentAlignment.MiddleCenter;
                        currentButton.IconColor = activecolor;
                        currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                        currentButton.ImageAlign = ContentAlignment.MiddleRight;
                        //Changing Left Border
                        leftBorderPanel.BackColor = activecolor;
                        leftBorderPanel.Location = new Point(0, currentButton.Location.Y);
                        leftBorderPanel.Visible = true;
                        leftBorderPanel.BringToFront();
                        //Changing Current Window Icon
                        currentPageIcon.IconChar = currentButton.IconChar;
                        lblCurrentPageTitle.Text = currentButton.Text;
                
                    }
                }
                private void DisableButton()
                {
                    if (currentButton != null)
                    {
                        //Returning Button
                        currentButton.BackColor = Color.FromArgb(100, 1, 30);
                        currentButton.ForeColor = Color.White;
                        currentButton.TextAlign = ContentAlignment.MiddleLeft;
                        currentButton.IconColor = Color.White;
                        currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                        currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                
                    }
                }
                #endregion
                
        #region Menu Buttons
        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(subMenuRegisterPanel);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            HideSubMenus();
            ActivateButton(sender);
            OpenChildForm(new AppointmentsForm());
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubMenu(subMenuViewPanel);
        }

        private void ResetMenu()
        {
            DisableButton();
            HideSubMenus();
            leftBorderPanel.Visible = false;
            //Changing Current Window Icon
            currentPageIcon.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            lblCurrentPageTitle.Text = "Home";

        }

        private void btnLogoHome_Click(object sender, EventArgs e)
        {
            ResetMenu();
            if (currentChildForm != null)
            {
                //Closing Last Open Form
                currentChildForm.Close();
            }
        }
        #endregion
        
        #region Submenu Configuration
        private void HideSubMenus()
        {
            if (subMenuRegisterPanel.Visible == true)
            {
                subMenuRegisterPanel.Visible = false;
            }
            if (subMenuViewPanel.Visible == true)
            {          
                subMenuViewPanel.Visible = false;
            }
        }
        private void showSubMenu(Panel subPanel)
        {
            if(subPanel.Visible == false)
            {
                HideSubMenus();
                subPanel.Visible = true;
            } else
            {
                subPanel.Visible = false;
            }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace project_hospital
{
    public partial class MainForm : Form
    {
        private IconButton currentButton;
        private Panel leftBorderPanel;
        public MainForm()
        {
            InitializeComponent();
            leftBorderPanel = new Panel();
            leftBorderPanel.Size = new Size(6, 60);
            panelSideBar.Controls.Add(leftBorderPanel);
        }

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
        private void ResetMenu()
        {
            DisableButton();
            leftBorderPanel.Visible = false;
            //Changing Current Window Icon
            currentPageIcon.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            lblCurrentPageTitle.Text = "Home";

        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLogoHome_Click(object sender, EventArgs e)
        {
            ResetMenu();
        }
    }
}

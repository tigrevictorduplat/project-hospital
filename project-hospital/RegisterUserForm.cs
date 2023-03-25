using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_hospital
{
    public partial class RegisterUserForm : Form
    {
        public RegisterUserForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
           
            string password = txtPassword.Text;
            string confirmPasswor = txtConfirmPassword.Text;
            if (password != confirmPasswor) {
                MessageBox.Show("As senhas não coincidem!");
            }
            string username = txtUsername.Text;
            string checkedButton = radioPanel.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked).Text;

            
        }
    }
}

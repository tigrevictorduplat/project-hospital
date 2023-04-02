using MySql.Data.MySqlClient;
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
        private MySqlConnection registerConnection;
        public RegisterUserForm()
        {
            InitializeComponent();
        }
        public void setConnection(MySqlConnection con)
        {
            this.registerConnection = con;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                //Getting User Data
                string password = txtPassword.Text;
            string confirmPasswor = txtConfirmPassword.Text;
            if (password != confirmPasswor) {
                throw new UnmatchingRegisterPasswordException("As senhas não coincidem!");
            }
            string username = txtUsername.Text;
            string userType = radioPanel.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked).Text;
            DateTime dateTime = DateTime.Now;
                registerConnection.Open();
                Console.WriteLine("Conexão Verificada");
                string sqlQuery =
                    "INSERT INTO tbl_user " +
                    "(password, register_date, user_type, username) " +
                    $" VALUES('{password}','{dateTime.ToString()}','{userType}','{username}'); ";
                MySqlCommand cmd = new MySqlCommand(sqlQuery,registerConnection);
                cmd.ExecuteReader();
                MessageBox.Show("Valores Inseridos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (registerConnection!= null) { registerConnection.Close(); }
            }

        }

    }
}

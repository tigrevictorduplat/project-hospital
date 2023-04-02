using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
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
                    "(password, register_date, user_type, username)" +
                    $" VALUES('{password}','{dateTime.ToString()}','{userType}','{username}'); ";
                MySqlCommand cmd = new MySqlCommand(sqlQuery,registerConnection);
                cmd.ExecuteReader();
                Console.WriteLine("Valores Inseridos!");
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
        private void btnCheckEqual_Click(object sender, EventArgs e)
        {
               try
               {
                   //Getting User Data
                   string password = txtPassword.Text;
                   string username = txtUsername.Text;
                   string userType = radioPanel.Controls.OfType<RadioButton>()
                                              .FirstOrDefault(r => r.Checked).Text;
                   registerConnection.Open();
                   Console.WriteLine("Conexão Verificada");
                string sqlQuery =
                    "SELECT * FROM tbl_user AS U " +
                    $"WHERE U.`password` LIKE '%{password}%' " +
                    $"AND U.`user_type` LIKE '%{userType}%' " +
                    $"AND U.`username` LIKE '%{username}%';";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, registerConnection);
                MySqlDataReader sqlData = cmd.ExecuteReader();
                /*
                 *  Código que compara os dados recebidos e verifica se existe um cadastro
                 */

               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
               finally
               {
                   if (registerConnection != null) { registerConnection.Close(); }
               }
        }
    }
}

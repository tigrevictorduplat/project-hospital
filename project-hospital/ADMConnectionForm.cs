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
using MySql.Data.MySqlClient;

namespace project_hospital
{
    public partial class ADMConnectionForm : Form
    {
        MySqlConnection connection;
        public ADMConnectionForm()
        {
            InitializeComponent();
            //Hide Form Border
            this.Text = "";
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
            }
            else
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
        private void btnAttemptConnection_Click(object sender, EventArgs e)
        {
            try {
                string datasource = "datasource=localhost;" +
                   $"username={txtUsername.Text};" +
                   $"password={txtPassword.Text};" +
                   "database=dbhospital;";

                connection = new MySqlConnection(datasource);
                connection.Open();
                Console.WriteLine("Conexão Verificada");
                connection.Close();
                //Opening Main Menu
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.setConnection(connection);
                mainForm.Show();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                if (connection != null) { connection.Close(); }
                
            }
        }

    }
}

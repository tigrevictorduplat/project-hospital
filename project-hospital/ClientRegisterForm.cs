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

namespace project_hospital
{
    public partial class ClientRegisterForm : Form
    {
        Thread th;
        public ClientRegisterForm()
        {
            InitializeComponent();
        }

        private void showClientTable_Click(object sender, EventArgs e)
        {
            TableViewerForm tableViewer = new TableViewerForm();
            tableViewer.ShowDialog();
        }

        private void showUserTable_Click(object sender, EventArgs e)
        {
            TableViewerForm tableViewer = new TableViewerForm();
            tableViewer.ShowDialog();
        }

        public void runMainForm()
        {
            Application.Run(new MainForm());

        }

        private void homeToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(runMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void homeUserToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(runMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

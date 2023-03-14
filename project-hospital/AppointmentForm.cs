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
    public partial class AppointmentForm : Form
    {
        Thread th;
        public AppointmentForm()
        {
            InitializeComponent();
        }
        public void runMainForm()
        {
            Application.Run(new MainForm());

        }

        private void showAppointmentTable_Click(object sender, EventArgs e)
        {
            TableViewerForm tableViewer = new TableViewerForm();
            tableViewer.ShowDialog();
        }

        private void homeToolStrip_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(runMainForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

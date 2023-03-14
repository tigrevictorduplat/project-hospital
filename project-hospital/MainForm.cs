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
    public partial class MainForm : Form
    {
        Thread th;

        public MainForm()
        {
            InitializeComponent();
        }

        public void runAppointment()
        {
            Application.Run( new AppointmentForm());
        }
        public void runClientRegister()
        {
            Application.Run(new ClientRegisterForm());
                        
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(runAppointment);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(runClientRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}

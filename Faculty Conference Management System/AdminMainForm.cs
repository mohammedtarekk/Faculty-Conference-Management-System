using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Conference_Management_System
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AssignBT_Click(object sender, EventArgs e)
        {
            new Admin_form();
            //new AssignPaperForm().Show();
            this.Hide();
        }

        private void BookAppointmentBT_Click(object sender, EventArgs e)
        {
            new BookAppointmentForm().Show();
            this.Hide();
        }

        private void AdminMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

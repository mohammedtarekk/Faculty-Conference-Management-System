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
    public partial class BookAppointmentForm : Form
    {
        public BookAppointmentForm()
        {
            InitializeComponent();
        }

        private void BookAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AdminMainForm().Show();
        }
    }
}

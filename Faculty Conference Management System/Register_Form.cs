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
    public partial class Register_Form : Form
    {
        public Register_Form()
        {
            InitializeComponent();
        }



        private void BunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
           
        }

        private void Exit_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form lf = new Login_Form();
            lf.Show();
        }
    }
}

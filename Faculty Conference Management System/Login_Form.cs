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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
           // Image AutNormalImageTemp = Author_RB_lbl.ImageNormal;

        }

        private void Exit_BT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserID_txt_TextChanged(object sender, EventArgs e)
        {
            UserID_txt.ForeColor = Color.Silver;
        }

        private void UserID_txt_MouseClick(object sender, MouseEventArgs e)
        {
            UserID_txt.Text = "";
            UserID_txt.ForeColor = Color.Silver;
        }

        private void Password_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Password_txt.Text = "";
            Password_txt.ForeColor = Color.Silver;
            Password_txt.PasswordChar = '*';
        }

        private void AuthorRB_OnChange(object sender, EventArgs e)
        {
            //if (AuthorRB.Checked)
               // ReviewerRB.Checked = false;
        }

        private void ReviewerRB_OnChange(object sender, EventArgs e)
        {
           // if (ReviewerRB.Checked)
              //  AuthorRB.Checked = false;
        }

        private void RegisterNowBT_Click(object sender, EventArgs e)
        {
            Register_Form rf = new Register_Form();
            rf.Show();
            this.Hide();
        }
    }
}

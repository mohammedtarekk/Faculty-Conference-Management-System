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
        Connection con=new Connection();

        public Register_Form()
        {
            InitializeComponent();
        }
        private void Exit_BT_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login_Form().Show();
        }

        private void UserID_txt_MouseClick(object sender, MouseEventArgs e)
        {
           // UserID_txt.Text = "";
            UserID_txt.ForeColor = Color.Silver;
        }

        private void Password_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Password_txt.Text = "";
            Password_txt.ForeColor = Color.Silver;
            Password_txt.PasswordChar = '*';
        }

        private void FName_txt_MouseClick(object sender, MouseEventArgs e)
        {
            FName_txt.Text = "";
            FName_txt.ForeColor = Color.Silver;
        }

        private void LNAME_txt_MouseClick(object sender, MouseEventArgs e)
        {
            LNAME_txt.Text = "";
            LNAME_txt.ForeColor = Color.Silver;
        }

        private void Email_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Email_txt.Text = "";
            Email_txt.ForeColor = Color.Silver;
        }
        private void Address_txt_MouseClick(object sender, MouseEventArgs e)
        {
            Address_txt.Text = "";
            Address_txt.ForeColor = Color.Silver;
        }
        private void DateBirth_txt_MouseClick(object sender, MouseEventArgs e)
        {
            DateBirth_txt.Text = "";
            DateBirth_txt.ForeColor = Color.Silver;
        }
        private void SignUp_bt_Click(object sender, EventArgs e)
        {
            bool res = true;
            if (ReviewerRB.Checked)
                res = con.Signup("Author",FName_txt.Text, LNAME_txt.Text, DateBirth_txt.Text, Address_txt.Text, Password_txt.Text, Email_txt.Text);
            else if(AuthorRB.Checked)
                res = con.Signup("Reviewer", FName_txt.Text, LNAME_txt.Text, DateBirth_txt.Text, Address_txt.Text, Password_txt.Text, Email_txt.Text);
            else if(AdminRB.Checked)
                res = con.Signup("Admin", FName_txt.Text, LNAME_txt.Text, DateBirth_txt.Text, Address_txt.Text, Password_txt.Text, Email_txt.Text);


            if (res)
                MessageBox.Show("You have been registered successfully! Sign in NOW!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Please enter your data correctly.", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (res)
            {
                this.Hide();
                new Login_Form().Show();
            }

        }
        private void UserID_txt_TextChanged(object sender, EventArgs e)
        {
            UserID_txt.ForeColor = Color.Silver;
        }

        private void UserID_txt_Click(object sender, EventArgs e)
        {
            int x = 0;
            Connection c = new Connection();
            if (AuthorRB.Checked)
                x = c.GetNextID("Author");
            else if (ReviewerRB.Checked)
                x = c.GetNextID("Reviewer");
            else if(AdminRB.Checked)
                x = c.GetNextID("Admin");

            UserID_txt.Text = x.ToString();
        }
    }
    
}

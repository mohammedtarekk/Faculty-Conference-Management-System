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
        Connection con=new Connection();
        public Login_Form()
        {
            InitializeComponent();
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

        private void RegisterNowBT_Click(object sender, EventArgs e)
        {
            //new AdminMainForm().Show();
            //new Register_Form().Show();
            //  new ReviewerPage().Show();
            new AuthorPage().Show();
            //new Admin_form().Show();
            this.Hide();
        }
        private void SignIn_bt_Click(object sender, EventArgs e)
        {
            bool found = false;
            bool res = true;
            int type = 0; //0 if author, 1 if reviewer
            if (AuthorRB.Checked)
                res = con.Get_Accounts("Author");
            else if(ReviewerRB.Checked)
            {
                res = con.Get_Accounts("Reviewer");
                type = 1;
            }
            else if(AdminRB.Checked)
            {
                res = con.Get_Accounts("Admin");
                type = 2;
            }

            if (res == true)
            {
                if (type == 0)
                    found = con.check_exist("Author", Convert.ToInt32(UserID_txt.Text), Password_txt.Text);
                else if (type == 1)
                    found = con.check_exist("Reviewer", Convert.ToInt32(UserID_txt.Text), Password_txt.Text);
                else if(type==2)
                    found = con.check_exist("Admin", Convert.ToInt32(UserID_txt.Text), Password_txt.Text);


                if (found == true)
                {
                    MessageBox.Show("Login successfully :)");
                    this.Hide();
                    if (type == 0)
                        new AuthorPage().Show();
                    else
                        new ReviewerPage().Show();
                }
                else
                    MessageBox.Show("Login failed :( ");
            }
            else
                MessageBox.Show("error loading data from oracle");
        }

        private void Login_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

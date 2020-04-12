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
            //Register_Form RegisterFormObject = new Register_Form();
            //RegisterFormObject.Show();
            new AuthorPage().Show();
            new ReviewerPage().Show();
           // new Register_Form().Show();
            this.Hide();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_bt_Click(object sender, EventArgs e)
        {
            bool res = true;
            if(AuthorRB.Checked)
                res= con.Get_Accounts('A');
            else
                res= con.Get_Accounts('R');

            if (res == true)
            {
                bool found = con.check_exist(Convert.ToInt32(UserID_txt.Text), Password_txt.Text);
                if (found == true)
                    MessageBox.Show("Login successfully :)");
                else
                    MessageBox.Show("Login failed :( ");
            }
            else
                MessageBox.Show("error loading data from oracle");
        }
    }
}

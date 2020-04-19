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
    public partial class Update_Data : Form
    {
        int id;
        string type;

        public Update_Data(int id, string type)
        {
            this.id = id;
            this.type = type;
            InitializeComponent();
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

        private void Update_Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AdminMainForm().Show();
        }

        private void Update_Data_Load(object sender, EventArgs e)
        {
            Connection con = new Connection();
            DataSet tmpSet;
            if (this.type == "Author")
            {
                string cmd = "select  AUTHOR_FNAME ,AUTHOR_SNAME , AUTHOR_DBIRTH , AUTHOR_EMAIL , AUTHOR_ADDRESS ,AUTHOR_PASSWORD  from author WHERE AUTHOR_ID=:id ";
                try
                {
                    tmpSet = con.DisconnectedExcuteQuery(cmd, "id", this.id.ToString());
                    FName_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[0].ToString();
                    LNAME_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[1].ToString();
                    DateBirth_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[2].ToString();
                    Email_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[3].ToString();
                    Address_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[4].ToString();
                    Password_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[5].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (this.type == "Reviewer")
            {
                string cmd = "select  REVIEWER_FNAME ,REVIEWER_SNAME , REVIEWER_DBIRTH , REVIEWER_EMAIL , REVIEWER_ADDRESS ,REVIEWER_PASSWORD from Reviewer WHERE REVIEWER_ID=:id ";
                try
                {
                    tmpSet = con.DisconnectedExcuteQuery(cmd, "id", this.id.ToString());
                    FName_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[0].ToString();
                    LNAME_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[1].ToString();
                    DateBirth_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[2].ToString();
                    Email_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[3].ToString();
                    Address_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[4].ToString();
                    Password_txt.Text = tmpSet.Tables[0].Rows[0].ItemArray[5].ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Update_BT_Click(object sender, EventArgs e)
        {
            Connection c = new Connection();
            if (this.type == "Author")
            {
                bool check = c.Update_Author_Data(this.id, FName_txt.Text, LNAME_txt.Text, DateBirth_txt.Text, Email_txt.Text, Address_txt.Text, Password_txt.Text);
                if (check == true)
                    MessageBox.Show("Updated successfully :)");
                else
                    MessageBox.Show("Updated failed :(");

            }
            else if (this.type == "Reviewer")
            {
                bool check = c.Update_Reviewer_Data(this.id, FName_txt.Text, LNAME_txt.Text, DateBirth_txt.Text, Email_txt.Text, Address_txt.Text, Password_txt.Text);
                if (check == true)
                    MessageBox.Show("Updated successfully :)");
                else
                    MessageBox.Show("Updated failed :(");

            }
        }
    }
}

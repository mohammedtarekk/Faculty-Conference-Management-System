﻿using System;
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
        private void Update_btn_Click_1(object sender, EventArgs e)
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

        private void Update_Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

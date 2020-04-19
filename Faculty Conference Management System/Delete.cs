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
    public partial class Delete : Form
    {
        private Connection con = new Connection();
        private DataSet set;
        string type;
        public Delete(string type)
        {
            this.type = type;
            InitializeComponent();
           
        }

        private void Delete_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AdminMainForm().Show();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            if (type == "Reviewer")
            {
                string cmd = "select * from Reviewer";
                try
                {
                    set = con.DisconnectedExcuteQuery(cmd);
                    GridView.AutoGenerateColumns = true;
                    GridView.DataSource = set.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (type == "Author")
            {
                string cmd = "select * from Author";
                try
                {
                    set = con.DisconnectedExcuteQuery(cmd);
                    GridView.AutoGenerateColumns = true;
                    GridView.DataSource = set.Tables[0];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete_BT_Click(object sender, EventArgs e)
        {
            if (this.type == "Author")
            {
                bool check = con.Delete_Author(int.Parse(ID_txt.Text));
                if (check == true)
                    MessageBox.Show("Deleted successfully :)");
                else
                    MessageBox.Show("Deleted failed :(");
            }
            else if (this.type == "Reviewer")
            {
                bool check = con.Delete_Reviewer(int.Parse(ID_txt.Text));
                if (check == true)
                    MessageBox.Show("Deleted successfully :)");
                else
                    MessageBox.Show("Deleted failed :(");
            }
            Delete_Load(sender, e);
        }
    }
}

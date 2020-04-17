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
    public partial class AssignPaperForm : Form
    {
        public AssignPaperForm()
        {
            InitializeComponent();
        }

        private void Assign_BT_Click(object sender, EventArgs e)
        { 


            //use after your logic in case of success
            MessageBox.Show("Assignment Done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AssignPaperForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AdminMainForm().Show();
        }
    }
}

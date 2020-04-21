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
    public partial class Crystal_author : Form
    {
        author a;
        public Crystal_author()
        {
            InitializeComponent();
        }

        private void Crystal_author_Load(object sender, EventArgs e)
        {
            a = new author();
            crystalReportViewer1.ReportSource = a;
        }
    }
}

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
    public partial class Crystal_paper : Form
    {
        paper p;
        
        public Crystal_paper()
        {
            InitializeComponent();
        }

        private void Crystal_paper_Load(object sender, EventArgs e)
        {
            p = new paper();         
            p.SetParameterValue(0,ReviewerPage.paper_id);
            crystalReportViewer1.ReportSource = p;
        }
    }
}

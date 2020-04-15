using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Faculty_Conference_Management_System
{
    public partial class SubmitPaper : Form
    {
        public SubmitPaper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Connection c = new Connection();
            OracleCommand cmd = new OracleCommand();
            OracleConnection con = new OracleConnection(c.conStr);
            cmd.Connection = con;
            cmd.CommandText = "insert into PAPER values (:PAPER_TITLE,:PAPER_CONTENT,:)";
            cmd.Parameters.Add("PAPER_TITLE", Title_textBox.Text);
            cmd.Parameters.Add("PAPER_CONTENT", content_textBox.Text);
            int r = cmd.ExecuteNonQuery();
            if (r!=-1)
            {
                MessageBox.Show("Submittion is succussful");
            }
        }
    }
}

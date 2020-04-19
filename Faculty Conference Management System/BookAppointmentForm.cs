using Oracle.DataAccess.Client;
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
    public partial class BookAppointmentForm : Form
    {
        private DataSet set;
        private Connection con = new Connection();
        private string cmd;
        private string selectedPaper;
        private string selectedDate;

        public BookAppointmentForm()
        {
            InitializeComponent();
        }

        private void BookAppointmentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new AdminMainForm().Show();
        }


        private void BookAppointmentForm_Load(object sender, EventArgs e)
        {
            //selecting accepted papers
            cmd = @"select paper.paper_id, paper_title, rev_state 
                    from paper, review
                    where rev_state = 'Accepted'
                    AND paper.paper_id = review.paper_id
                    AND paper.hasconference = 0
                    ORDER BY paper.paper_id ASC";
            try
            {
                set = con.DisconnectedExcuteQuery(cmd);
                AcceptedPapersGrid.AutoGenerateColumns = true;
                AcceptedPapersGrid.DataSource = set.Tables[0];
                AcceptedPapersGrid.Rows[0].Selected = true;


                //selceting available dates
                cmd = "select DAY_DATE, DAY_NAME FROM dates where day_state = 1";
                set = con.DisconnectedExcuteQuery(cmd);
                for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                {
                    DatesCB.Items.Add(set.Tables[0].Rows[i][0]);
                }

                DatesCB.SelectedItem = DatesCB.Items[0];
                selectedDate = DatesCB.SelectedItem.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Finish_BT_Click(object sender, EventArgs e)
        {
            //Update available date
            cmd = "select * FROM DATES where DAY_DATE = :d";
            set = con.DisconnectedExcuteQuery(cmd, "d", selectedDate);
            set.Tables[0].Rows[0][2] = 0;
            con.Update(set);

            //Add new conference
            con.addConference(selectedDate,placesCB.Text,SelectedPaper_txt.Text,durationTxt.Text,selectedPaper);

            OracleConnection connection = new OracleConnection(con.conStr);
            connection.Open();
            OracleCommand cmnd = new OracleCommand();
            cmnd.Connection = connection;
            cmnd.CommandText = @"update paper SET(hasconference) = 1 where paper_id = :i";
            cmnd.Parameters.Add("i", selectedPaper);
            cmnd.CommandType = CommandType.Text;
            cmnd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("conference added successfully");
            BookAppointmentForm_Load(sender, e);
        }

        private void AcceptedPapersGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (AcceptedPapersGrid.SelectedRows.Count != 0)
            {
                selectedPaper = AcceptedPapersGrid.SelectedRows[0].Cells[1].Value.ToString();
                SelectedPaper_txt.Text = selectedPaper;
                selectedPaper = AcceptedPapersGrid.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void durationTxt_MouseClick(object sender, MouseEventArgs e)
        {
            durationTxt.Text = "";
            durationTxt.ForeColor = Color.Silver;
        }
    }
}

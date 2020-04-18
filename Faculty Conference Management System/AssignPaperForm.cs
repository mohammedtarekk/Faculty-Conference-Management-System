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
    public partial class AssignPaperForm : Form
    {
		private DataSet set;
		private Connection con = new Connection();
		private string selectedPaper;
		private string selectedDate;
		private string selectedReviewer;
		private string cmd;

		public AssignPaperForm()
        {
            InitializeComponent();
        }

		private void AssignPaperForm_Load(object sender, EventArgs e)
		{
			try
			{
				//selecting new submitted papers
				cmd = "select PAPER_ID, PAPER_TITLE FROM paper where is_assigned = 0";
				set = con.DisconnectedExcuteQuery(cmd);
				papersGrid.AutoGenerateColumns = true;
				papersGrid.DataSource = set.Tables[0];
				papersGrid.Rows[0].Selected = true;

				//selceting available dates
				cmd = "select DAY_DATE, DAY_NAME FROM dates where day_state = 1";
				set = con.DisconnectedExcuteQuery(cmd);
				datesGrid.AutoGenerateColumns = true;
				datesGrid.DataSource = set.Tables[0];
				datesGrid.Rows[0].Selected = true;
				selectedDate = datesGrid.SelectedRows[0].Cells[0].Value.ToString();

				//selecting available reviewer for the selected date
				DataSet tmp = new DataSet();
				cmd = "select * FROM reviewer_dates where rev_DATE = :d";
				set = con.DisconnectedExcuteQuery(cmd, "d", selectedDate);
				for (int i = 0; i < set.Tables[0].Rows.Count; i++)
				{
					selectedReviewer = set.Tables[0].Rows[i][0].ToString();

					cmd = "select reviewer_id, reviewer_fname, reviewer_sname FROM reviewer where reviewer_id = :r";
					tmp.Merge(con.DisconnectedExcuteQuery(cmd, "r", selectedReviewer));
				}

				reviewersGrid.AutoGenerateColumns = true;
				reviewersGrid.DataSource = tmp.Tables[0];
				reviewersGrid.Rows[0].Selected = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void papersGrid_SelectionChanged(object sender, EventArgs e)
		{
			if (papersGrid.SelectedRows.Count != 0)
			{
				selectedPaper = papersGrid.SelectedRows[0].Cells[1].Value.ToString();
				selectedPaperTxt.Text = selectedPaper;
				selectedPaper = papersGrid.SelectedRows[0].Cells[0].Value.ToString();
			}
		}

		private void datesGrid_SelectionChanged(object sender, EventArgs e)
		{
			if (datesGrid.SelectedRows.Count != 0)
			{
				selectedDate = datesGrid.SelectedRows[0].Cells[0].Value.ToString();

				//selecting available reviewer for the selected date
				DataSet tmp = new DataSet();
				cmd = "select * FROM reviewer_dates where rev_DATE = :d";
				set = con.DisconnectedExcuteQuery(cmd, "d", selectedDate);
				for (int i = 0; i < set.Tables[0].Rows.Count; i++)
				{
					selectedReviewer = set.Tables[0].Rows[i][0].ToString();

					cmd = "select reviewer_id, reviewer_fname, reviewer_sname FROM reviewer where reviewer_id = :r";
					tmp.Merge(con.DisconnectedExcuteQuery(cmd, "r", selectedReviewer));
				}

				reviewersGrid.AutoGenerateColumns = true;
				reviewersGrid.DataSource = tmp.Tables[0];
				reviewersGrid.Rows[0].Selected = true;

				selectedDate = datesGrid.SelectedRows[0].Cells[1].Value.ToString() + "  " + datesGrid.SelectedRows[0].Cells[0].Value.ToString();
				selectedDateTxt.Text = selectedDate;
				selectedDate = datesGrid.SelectedRows[0].Cells[0].Value.ToString();

			}
		}

		private void reviewersGrid_SelectionChanged(object sender, EventArgs e)
		{
			if (reviewersGrid.SelectedRows.Count != 0)
			{
				selectedReviewer = reviewersGrid.SelectedRows[0].Cells[1].Value.ToString() + " " + reviewersGrid.SelectedRows[0].Cells[2].Value.ToString();
				selectedReviewerTxt.Text = selectedReviewer;
				selectedReviewer = reviewersGrid.SelectedRows[0].Cells[0].Value.ToString();
			}
		}

		private void Assign_BT_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you want to assign " + selectedReviewerTxt.Text + " to review the paper " + selectedPaperTxt.Text + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
				== DialogResult.Yes)
			{

				//Insert new row in Review table
				cmd = "select * FROM review";
				set = con.DisconnectedExcuteQuery(cmd, "d", selectedDate);
				set.Tables[0].Rows.Add(Convert.ToInt32(selectedPaper), Convert.ToInt32(selectedReviewer), "Waiting");
				con.Update(set);

				//Update available date
				cmd = "select * FROM DATES where DAY_DATE = :d";
				set = con.DisconnectedExcuteQuery(cmd, "d", selectedDate);
				set.Tables[0].Rows[0][2] = 0;
				con.Update(set);

				//Update isAssigned in paper
				cmd = "select * FROM PAPER where PAPER_ID = :i";
				set = con.DisconnectedExcuteQuery(cmd, "i", selectedPaper);
				set.Tables[0].Rows[0][5] = 1;
				con.Update(set);

				//Remove from Reviewer_Dates
				OracleConnection connection = new OracleConnection(con.conStr);
				connection.Open();
				OracleCommand cmnd = new OracleCommand();
				cmnd.Connection = connection;
				cmnd.CommandText = @"delete FROM REVIEWER_DATES where REV_DATE = :d and REVIEWER_ID = :i";
				cmnd.Parameters.Add("d", selectedDate);
				cmnd.Parameters.Add("i", selectedReviewer);
				cmnd.CommandType = CommandType.Text;
				cmnd.ExecuteNonQuery();
				connection.Close();

				AssignPaperForm_Load(sender, e);

				MessageBox.Show("Reviewer has been assigned successfully", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void AssignPaperForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			new AdminMainForm().Show();
		}
	}
}

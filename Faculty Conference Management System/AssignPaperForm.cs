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
		private string cmd;
		private string selectedPaper;
		private string selectedDate;
		private string selectedReviewer;
		private int numberOfAssignedPapers;

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

				//selecting available reviewer for the selected date
				cmd = "select reviewer_id, reviewer_fname, reviewer_sname, assigned_papers FROM reviewer";
				set = con.DisconnectedExcuteQuery(cmd);
				reviewersGrid.AutoGenerateColumns = true;
				reviewersGrid.DataSource = set.Tables[0];
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
				cmd = "select * FROM review" ;
				set = con.DisconnectedExcuteQuery(cmd);
				set.Tables[0].Rows.Add(Convert.ToInt32(selectedPaper), Convert.ToInt32(selectedReviewer), "Waiting");
				con.Update(set);

				//Update isAssigned in paper
				cmd = "select * FROM PAPER where PAPER_ID = :i";
				set = con.DisconnectedExcuteQuery(cmd, "i", selectedPaper);
				set.Tables[0].Rows[0][5] = 1;
				con.Update(set);

				//increment assigned_papers
				cmd = "select * FROM reviewer where reviewer_id = :i";
				set = con.DisconnectedExcuteQuery(cmd, "i", selectedReviewer);
				numberOfAssignedPapers = Convert.ToInt32(set.Tables[0].Rows[0][7]);
				set.Tables[0].Rows[0][7] = numberOfAssignedPapers + 1;
				con.Update(set);

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

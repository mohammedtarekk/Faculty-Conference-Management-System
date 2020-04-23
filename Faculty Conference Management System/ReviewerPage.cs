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
	public partial class ReviewerPage : Form
	{
		private Connection con = new Connection();
		private DataSet set;
		private int selectedPaper;
		private string cmd;
		private string selectedReviewer;
		public static int paper_id;
		public ReviewerPage()
		{
			InitializeComponent();
		}
		private void Search_BT_Click(object sender, EventArgs e)
		{
			DataSet tmpSet;
			string cmd = @"select paper.paper_id ID,paper_title Title, paper_content Content, category_name Category,author.author_id AuthorID, author_fname AuthorName, reviewer_fname Reviewer
							  from paper, review, reviewer, research_categoryfield, author
                              WHERE paper.paper_id = review.paper_id
                              AND review.reviewer_id = reviewer.reviewer_id
                              AND paper.research_id = research_categoryfield.category_id
                              AND author.author_id = paper.author_id 
							  AND paper.paper_title = :t
			                  ";
			try
			{

				tmpSet = con.DisconnectedExcuteQuery(cmd, "t", searchTxt.Text);

				GridView1.AutoGenerateColumns = true;
				GridView1.DataSource = tmpSet.Tables[0];
				cmd = "select  *  from review WHERE review.paper_id = :t";

				set = con.DisconnectedExcuteQuery(cmd, "t", tmpSet.Tables[0].Rows[0][0].ToString());
				GridView2.AutoGenerateColumns = true;
				GridView2.RowHeadersVisible = false;
				GridView2.DataSource = set.Tables[0];
				GridView2.Columns[0].Visible = false;
				GridView2.Columns[1].Visible = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void ViewAll_BT_Click(object sender, EventArgs e)
		{
			cmd = @"select paper.paper_id ID,paper_title Title, paper_content Content, category_name Category,author.author_id AuthorID, author_fname AuthorName, reviewer.reviewer_id ReviewerID, reviewer_fname Reviewer
							 from paper, review, reviewer, research_categoryfield, author
                              WHERE paper.paper_id = review.paper_id
                              AND review.reviewer_id = reviewer.reviewer_id
                              AND paper.research_id = research_categoryfield.category_id
                              AND author.author_id = paper.author_id
							  AND review.Reviewer_ID=:id
							  ORDER BY paper.paper_id ASC
								";

			try
			{
				GridView1.AutoGenerateColumns = true;
				GridView1.DataSource = con.DisconnectedExcuteQuery(cmd, "id", Connection.Current_ReviewerID.ToString()).Tables[0];
				cmd = "select  *  from review where Reviewer_ID=:id ORDER BY paper_id ASC ";
				set = con.DisconnectedExcuteQuery(cmd, "id",Connection.Current_ReviewerID.ToString());
				GridView2.AutoGenerateColumns = true;
				GridView2.RowHeadersVisible = false;
				GridView2.DataSource = set.Tables[0];
				GridView2.Columns[0].Visible = false;
				GridView2.Columns[1].Visible = false;
				GridView2.Rows[0].Selected = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SaveAll_BT_Click(object sender, EventArgs e)
		{
			con.Update(set);
			MessageBox.Show("Review state is changed successfully");
		}

		private void searchTxt_MouseClick(object sender, MouseEventArgs e)
		{
			searchTxt.Text = "";
			searchTxt.ForeColor = Color.Silver;
		}

		private void searchTxt_TextChanged(object sender, EventArgs e)
		{
			searchTxt.ForeColor = Color.Silver;
		}

		private void Gridview2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//here will be the condition of editing rev_state in search button
			//if(the paper is reviewed by the current reviewer)then enable editing
			//else disable editing
			// w ma3 el salama rawa7 lommak :)
		}

		private void GridView1_SelectionChanged(object sender, EventArgs e)
		{
			if (GridView1.SelectedRows.Count != 0 && GridView1.Rows.Count == GridView2.Rows.Count) 
			{
				selectedPaper = GridView1.SelectedRows[0].Index;
				GridView2.Rows[selectedPaper].Selected = true;
			}
		}

		private void Gridview2_SelectionChanged(object sender, EventArgs e)
		{
			if (GridView2.SelectedRows.Count != 0 && GridView1.Rows.Count == GridView2.Rows.Count)
			{
				selectedPaper = GridView2.SelectedRows[0].Index;
				GridView1.Rows[selectedPaper].Selected = true;

				switch (GridView2.SelectedRows[0].Cells[2].Value)
				{
					case "Accepted":
						acceptRB.Checked = true;
						break;

					case "Rejected":
						rejectRB.Checked = true;
						break;

					case "Waiting":
						acceptRB.Checked = false;
						rejectRB.Checked = false;
						break;
				}
			}
		}

		private void acceptRB_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you accept the selected paper " + GridView1.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
				== DialogResult.Yes)
			{
				GridView2.SelectedRows[0].Cells[2].Value = "Accepted";

				//decrement assigned_papers
				int numberOfAssignedPapers;

				OracleConnection connection = new OracleConnection(con.conStr);
				connection.Open();
				OracleCommand cmd = new OracleCommand();
				cmd.Connection = connection;
				cmd.CommandText = @"select assigned_papers FROM reviewer where reviewer_id = :i";
				cmd.Parameters.Add("i", selectedReviewer);
				cmd.CommandType = CommandType.Text;
				OracleDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					numberOfAssignedPapers = Convert.ToInt32(dr["assigned_papers"]);
					cmd.CommandText = @"update reviewer SET(assigned_papers) = :n where reviewer_id = :i";
					cmd.Parameters.Add("n", numberOfAssignedPapers - 1);
					cmd.Parameters.Add("i", selectedReviewer);
					cmd.ExecuteNonQuery();
				}
				connection.Close();
			}
		}

		private void rejectRB_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure you reject the selected paper " + GridView1.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
				== DialogResult.Yes)
			{
				GridView2.SelectedRows[0].Cells[2].Value = "Rejected";

				//decrement assigned_papers
				int numberOfAssignedPapers;
				OracleConnection connection = new OracleConnection(con.conStr);
				connection.Open();
				OracleCommand cmd = new OracleCommand();
				cmd.Connection = connection;
				cmd.CommandText = @"select assigned_papers FROM reviewer where reviewer_id = :i";
				cmd.Parameters.Add("i", selectedReviewer);
				cmd.CommandType = CommandType.Text;
				OracleDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					numberOfAssignedPapers = Convert.ToInt32(dr["assigned_papers"]);
					cmd.CommandText = @"update reviewer SET(assigned_papers) = :n where reviewer_id = :i";
					cmd.Parameters.Add("n", numberOfAssignedPapers - 1);
					cmd.Parameters.Add("i", selectedReviewer);
					cmd.ExecuteNonQuery();
				}
				connection.Close();
			}
		}

		private void UpdateInfo_BT_Click(object sender, EventArgs e)
		{
			new Update_Data(Connection.Current_ReviewerID, "Reviewer").Show();
		}

		private void ReviewerPage_Load(object sender, EventArgs e)
		{

		}

		private void CrystalReport_BT_Click(object sender, EventArgs e)
		{
			paper_id=Convert.ToInt32( GridView1.SelectedRows[0].Cells[0].Value);
			new Crystal_paper().Show();
		}

		private void ReviewerPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			new Login_Form().Show();
		}
	}
}

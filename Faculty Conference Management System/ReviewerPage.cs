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
			Gridview2.AutoGenerateColumns = true;
			Gridview2.RowHeadersVisible = false;
			Gridview2.DataSource = set.Tables[0];
			Gridview2.Columns[0].Visible = false;
			Gridview2.Columns[1].Visible = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void Exit_BT_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ViewAll_BT_Click(object sender, EventArgs e)
		{
			string cmd = @"select paper.paper_id ID,paper_title Title, paper_content Content, category_name Category,author.author_id AuthorID, author_fname AuthorName, reviewer_fname Reviewer
							 from paper, review, reviewer, research_categoryfield, author
                              WHERE paper.paper_id = review.paper_id
                              AND review.reviewer_id = reviewer.reviewer_id
                              AND paper.research_id = research_categoryfield.category_id
                              AND author.author_id = paper.author_id";

			try
			{
			GridView1.AutoGenerateColumns = true;
			GridView1.DataSource = con.DisconnectedExcuteQuery(cmd).Tables[0];
			cmd = "select  *  from review";
			set = con.DisconnectedExcuteQuery(cmd);
			Gridview2.AutoGenerateColumns = true;
			Gridview2.RowHeadersVisible = false;
			Gridview2.DataSource = set.Tables[0];
			Gridview2.Columns[0].Visible = false;
			Gridview2.Columns[1].Visible = false;
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
	}
}

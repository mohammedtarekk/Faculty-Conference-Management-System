using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Collections;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Faculty_Conference_Management_System
{
	public partial class AuthorPage : Form
	{
		private Connection con = new Connection();
		private DataSet set;
		public AuthorPage()
		{
			InitializeComponent();
			PaperDataPnl.Visible = false;
		}
		private void Search_BT_Click(object sender, EventArgs e)
		{
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
				set = con.DisconnectedExcuteQuery(cmd, "t", searchTxt.Text);

				GridView1.AutoGenerateColumns = true;
				GridView1.DataSource = set.Tables[0];
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"No Data Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void ViewAll_BT_Click(object sender, EventArgs e)
		{
			string cmd = "select * from paper";
			try
				{
				set = con.DisconnectedExcuteQuery(cmd);
				GridView1.AutoGenerateColumns = true;
				GridView1.DataSource = set.Tables[0];
				GridView1.Columns[2].Visible = false;
				GridView1.Columns[3].Visible = false;
				GridView1.Columns[4].Visible = false;
				GridView1.Columns[5].Visible = false;


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

		private void searchTxt_TextChanged(object sender, EventArgs e)
		{
			searchTxt.ForeColor = Color.Silver;
		}

		private void searchTxt_MouseClick(object sender, MouseEventArgs e)
		{
			searchTxt.Text = "";
			searchTxt.ForeColor = Color.Silver;
		}

		//The change he can do is to delete the rejected papers only
		private void SaveAll_BT_Click(object sender, EventArgs e)
		{
			OracleConnection connection = new OracleConnection(con.conStr);
			connection.Open();
			OracleCommand cmd = new OracleCommand();
			cmd.Connection = connection;
			cmd.CommandText = @"delete from review where paper_id = :id";
			cmd.Parameters.Add("id", SelectedPaperID);
			cmd.CommandType = CommandType.Text;
			cmd.ExecuteNonQuery();
			connection.Close();

			con.Update(set);
			PaperDataPnl.Visible = false;
			MessageBox.Show("Changes are saved successfully");
		}

		private int SelectedPaperID;
		private void GridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			SelectedPaperID = Convert.ToInt32(GridView1.SelectedRows[0].Cells[0].Value);
			OracleConnection connection = new OracleConnection(con.conStr);
			connection.Open();
			OracleCommand cmd = new OracleCommand();
			cmd.Connection = connection;
			cmd.CommandText = @"select paper.paper_id ID,paper_title Title, paper_content Content, category_name Category,author.author_id AuthorID, author_fname AuthorName, reviewer.reviewer_id reviewerID, reviewer_fname ReviewerName, rev_state ReviewState
							  from paper, review, reviewer, research_categoryfield, author
                              WHERE paper.paper_id = review.paper_id
                              AND review.reviewer_id = reviewer.reviewer_id
                              AND paper.research_id = research_categoryfield.category_id
                              AND author.author_id = paper.author_id 
							  AND paper.paper_title = :t
			                  ";
			cmd.Parameters.Add("t", GridView1.SelectedRows[0].Cells[1].Value.ToString());
			cmd.CommandType = CommandType.Text;

			OracleDataReader dr = cmd.ExecuteReader();
			while (dr.Read())
			{
				idLbl.Text = dr["ID"].ToString();
				titleLbl.Text = dr["Title"].ToString();
				authorIdLbl.Text = dr["AuthorID"].ToString();
				authorNameLbl.Text = dr["AuthorName"].ToString();
				revIdLbl.Text = dr["reviewerID"].ToString();
				revNameLbl.Text = dr["ReviewerName"].ToString();
				stateLbl.Text = dr["ReviewState"].ToString();
				content_textBox.Text = dr["Content"].ToString();

			}
			connection.Close();
			PaperDataPnl.Visible = true;
		}

		private void Submit_BT_Click(object sender, EventArgs e)
		{
			new SubmitPaper().Show();
		}

		private void PaperDataPnl_Paint(object sender, PaintEventArgs e)
		{

		}

		private void CrystalReport_BT_Click(object sender, EventArgs e)
		{
		}

		private void AuthorPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}

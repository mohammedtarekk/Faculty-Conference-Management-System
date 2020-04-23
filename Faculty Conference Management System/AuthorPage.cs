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

			string cmd = "select * from paper where  paper.author_id =:id ";
			try
				{
				set = con.DisconnectedExcuteQuery(cmd,"id",Connection.Current_AuthorID.ToString());
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

		private void searchTxt_TextChanged(object sender, EventArgs e)
		{
			searchTxt.ForeColor = Color.Silver;
		}

		bool clickedOnce = false;
		private void searchTxt_MouseClick(object sender, MouseEventArgs e)
		{
			if(!clickedOnce)
				searchTxt.Text = "";

			searchTxt.ForeColor = Color.Silver;
			clickedOnce = true;
		}

		public static int SelectedPaperID;
		
		private void Submit_BT_Click(object sender, EventArgs e)
		{
			new SubmitPaper().Show();
		}
		private void AuthorPage_FormClosed(object sender, FormClosedEventArgs e)
		{
			new Login_Form().Show();
		}
    
        private void Update_BT_Click(object sender, EventArgs e)
		{
           
			new UpdateForm(titleLbl.Text,categoryLbl.Text,content_textBox.Text).Show();
		}

		private void GridView1_SelectionChanged(object sender, EventArgs e)
		{
			if(GridView1.SelectedRows.Count != 0)
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
							  AND paper.paper_id = :t
			                  ";
				cmd.Parameters.Add("t", GridView1.SelectedRows[0].Cells[0].Value.ToString());
				cmd.CommandType = CommandType.Text;
				OracleDataReader dr = cmd.ExecuteReader();
				bool flag = dr.Read();
				if (!flag)
				{
						idLbl.Text = GridView1.SelectedRows[0].Cells[0].Value.ToString();
						titleLbl.Text = GridView1.SelectedRows[0].Cells[1].Value.ToString();
					authorIdLbl.Text = GridView1.SelectedRows[0].Cells[4].Value.ToString();
					authorNameLbl.Text = GridView1.SelectedRows[0].Cells[4].Value.ToString(); ;
					revIdLbl.Text = "-";
					revNameLbl.Text = "-";
					stateLbl.Text = "Pending";
					content_textBox.Text = GridView1.SelectedRows[0].Cells[2].Value.ToString(); ;
				}
				while (flag)
				{
					idLbl.Text = dr["ID"].ToString();
					titleLbl.Text = dr["Title"].ToString();
					authorIdLbl.Text = dr["AuthorID"].ToString();
					authorNameLbl.Text = dr["AuthorName"].ToString();
					revIdLbl.Text = dr["reviewerID"].ToString();
					revNameLbl.Text = dr["ReviewerName"].ToString();
					stateLbl.Text = dr["ReviewState"].ToString();
					content_textBox.Text = dr["Content"].ToString();
					categoryLbl.Text = dr["Category"].ToString();
					flag = dr.Read();
				}
				connection.Close();
				PaperDataPnl.Visible = true;
			}
		}
		private void UpdateInfo_BT_Click(object sender, EventArgs e)
		{
			new Update_Data(Connection.Current_AuthorID, "Author").Show();
		}

		private void Delete_BT_Click(object sender, EventArgs e)
		{
            if (stateLbl.Text == "Accepted")
            {
                MessageBox.Show("You can't delete accepted paper :( ", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete the selected paper " + GridView1.SelectedRows[0].Cells[1].Value.ToString() + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    == DialogResult.Yes)
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
                    GridView1.Rows.RemoveAt(GridView1.SelectedRows[0].Index);
                    con.Update(set);

                    ViewAll_BT_Click(sender, e);
                    MessageBox.Show("Changes are saved successfully");

                }
            }

		}

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

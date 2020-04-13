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
			Queue<string> parametersList = new Queue<string>();
			string cmd = @"select paper.paper_id, paper_title, paper_content, category_name,author.author_id, author_fname, reviewer_fname, reviewer_sname, rev_state 
														  from paper
														  INNER JOIN  review ON paper.paper_id = review.paper_id
														  INNER JOIN  reviewer ON  review.reviewer_id = reviewer.reviewer_id
														  INNER JOIN  research_categoryfield ON paper.research_id = research_categoryfield.category_id
														  INNER JOIN  author ON author.author_id = paper.author_id
														  WHERE paper.paper_title = :t
			                                              ";

			parametersList.Enqueue("t");
			parametersList.Enqueue(searchTxt.Text);
			set = con.DisconnectedExcuteQuery(cmd, parametersList);

			GridView1.AutoGenerateColumns = true;
			GridView1.DataSource = set.Tables[0];

		}

		private void Exit_BT_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void ViewAll_BT_Click(object sender, EventArgs e)
		{
			string cmd = @"select paper.paper_id ID,paper_title Title, paper_content Content, category_name Category,author.author_id AuthorID, author_fname AuthorName, reviewer_fname Reviewer, rev_state AcceptenceState 
														  from paper
														  INNER JOIN  review ON paper.paper_id = review.paper_id
														  INNER JOIN  reviewer ON  review.reviewer_id = reviewer.reviewer_id
														  INNER JOIN  research_categoryfield ON paper.research_id = research_categoryfield.category_id
														  INNER JOIN  author ON author.author_id = paper.author_id
			                                              ";
			set = con.DisconnectedExcuteQuery(cmd);

			GridView1.AutoGenerateColumns = true;
			GridView1.DataSource = set.Tables[0];
		}

		private void SaveAll_BT_Click(object sender, EventArgs e)
		{
			con.Update(set);
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
	}
}

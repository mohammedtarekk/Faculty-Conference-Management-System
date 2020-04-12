namespace Faculty_Conference_Management_System
{
	partial class ReviewerPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GridView1 = new System.Windows.Forms.DataGridView();
			this.viewAllBtn = new System.Windows.Forms.Button();
			this.searchBtn = new System.Windows.Forms.Button();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.lable1 = new System.Windows.Forms.Label();
			this.nextDate = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// GridView1
			// 
			this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridView1.Location = new System.Drawing.Point(12, 166);
			this.GridView1.Name = "GridView1";
			this.GridView1.Size = new System.Drawing.Size(940, 225);
			this.GridView1.TabIndex = 0;
			// 
			// viewAllBtn
			// 
			this.viewAllBtn.Location = new System.Drawing.Point(547, 106);
			this.viewAllBtn.Name = "viewAllBtn";
			this.viewAllBtn.Size = new System.Drawing.Size(135, 54);
			this.viewAllBtn.TabIndex = 1;
			this.viewAllBtn.Text = "View all papers";
			this.viewAllBtn.UseVisualStyleBackColor = true;
			this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(151, 106);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(135, 54);
			this.searchBtn.TabIndex = 1;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(292, 124);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(144, 20);
			this.searchTxt.TabIndex = 2;
			// 
			// lable1
			// 
			this.lable1.AutoSize = true;
			this.lable1.Location = new System.Drawing.Point(18, 19);
			this.lable1.Name = "lable1";
			this.lable1.Size = new System.Drawing.Size(130, 13);
			this.lable1.TabIndex = 3;
			this.lable1.Text = "Next conference will be at";
			// 
			// nextDate
			// 
			this.nextDate.AutoSize = true;
			this.nextDate.Location = new System.Drawing.Point(148, 19);
			this.nextDate.Name = "nextDate";
			this.nextDate.Size = new System.Drawing.Size(65, 13);
			this.nextDate.TabIndex = 3;
			this.nextDate.Text = "dd/mm/yyyy";
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(350, 397);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(135, 41);
			this.saveBtn.TabIndex = 4;
			this.saveBtn.Text = "Save Changes";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// ReviewerPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 450);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.nextDate);
			this.Controls.Add(this.lable1);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.viewAllBtn);
			this.Controls.Add(this.GridView1);
			this.Name = "ReviewerPage";
			this.Text = "ReviewerPage";
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridView1;
		private System.Windows.Forms.Button viewAllBtn;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.Label nextDate;
		private System.Windows.Forms.Button saveBtn;
	}
}
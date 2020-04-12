namespace Faculty_Conference_Management_System
{
	partial class AuthorPage
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
			this.nextDate = new System.Windows.Forms.Label();
			this.lable1 = new System.Windows.Forms.Label();
			this.searchTxt = new System.Windows.Forms.TextBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.viewAllBtn = new System.Windows.Forms.Button();
			this.GridView1 = new System.Windows.Forms.DataGridView();
			this.submitBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// nextDate
			// 
			this.nextDate.AutoSize = true;
			this.nextDate.Location = new System.Drawing.Point(138, 19);
			this.nextDate.Name = "nextDate";
			this.nextDate.Size = new System.Drawing.Size(65, 13);
			this.nextDate.TabIndex = 8;
			this.nextDate.Text = "dd/mm/yyyy";
			// 
			// lable1
			// 
			this.lable1.AutoSize = true;
			this.lable1.Location = new System.Drawing.Point(8, 19);
			this.lable1.Name = "lable1";
			this.lable1.Size = new System.Drawing.Size(130, 13);
			this.lable1.TabIndex = 9;
			this.lable1.Text = "Next conference will be at";
			// 
			// searchTxt
			// 
			this.searchTxt.Location = new System.Drawing.Point(153, 120);
			this.searchTxt.Name = "searchTxt";
			this.searchTxt.Size = new System.Drawing.Size(144, 20);
			this.searchTxt.TabIndex = 7;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(12, 102);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(135, 54);
			this.searchBtn.TabIndex = 5;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// viewAllBtn
			// 
			this.viewAllBtn.Location = new System.Drawing.Point(408, 102);
			this.viewAllBtn.Name = "viewAllBtn";
			this.viewAllBtn.Size = new System.Drawing.Size(135, 54);
			this.viewAllBtn.TabIndex = 6;
			this.viewAllBtn.Text = "View all papers";
			this.viewAllBtn.UseVisualStyleBackColor = true;
			this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
			// 
			// GridView1
			// 
			this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridView1.Location = new System.Drawing.Point(12, 162);
			this.GridView1.Name = "GridView1";
			this.GridView1.Size = new System.Drawing.Size(1022, 272);
			this.GridView1.TabIndex = 4;
			// 
			// submitBtn
			// 
			this.submitBtn.Location = new System.Drawing.Point(408, 15);
			this.submitBtn.Name = "submitBtn";
			this.submitBtn.Size = new System.Drawing.Size(135, 54);
			this.submitBtn.TabIndex = 6;
			this.submitBtn.Text = "Submit new paper";
			this.submitBtn.UseVisualStyleBackColor = true;
			// 
			// AuthorPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1046, 446);
			this.Controls.Add(this.nextDate);
			this.Controls.Add(this.lable1);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.submitBtn);
			this.Controls.Add(this.viewAllBtn);
			this.Controls.Add(this.GridView1);
			this.Name = "AuthorPage";
			this.Text = "AuthorPage";
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label nextDate;
		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.Button viewAllBtn;
		private System.Windows.Forms.DataGridView GridView1;
		private System.Windows.Forms.Button submitBtn;
	}
}
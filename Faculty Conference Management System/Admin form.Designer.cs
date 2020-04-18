namespace Faculty_Conference_Management_System
{
	partial class Admin_form
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
			this.datesGrid = new System.Windows.Forms.DataGridView();
			this.reviewersGrid = new System.Windows.Forms.DataGridView();
			this.papersGrid = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.saveBtn = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.selectedPaperTxt = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.selectedDateTxt = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.selectedReviewerTxt = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.datesGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reviewersGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.papersGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// datesGrid
			// 
			this.datesGrid.AllowUserToAddRows = false;
			this.datesGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.datesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datesGrid.Location = new System.Drawing.Point(270, 54);
			this.datesGrid.Name = "datesGrid";
			this.datesGrid.ReadOnly = true;
			this.datesGrid.Size = new System.Drawing.Size(234, 289);
			this.datesGrid.TabIndex = 5;
			this.datesGrid.SelectionChanged += new System.EventHandler(this.datesGrid_SelectionChanged);
			// 
			// reviewersGrid
			// 
			this.reviewersGrid.AllowUserToAddRows = false;
			this.reviewersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.reviewersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.reviewersGrid.Location = new System.Drawing.Point(523, 54);
			this.reviewersGrid.Name = "reviewersGrid";
			this.reviewersGrid.ReadOnly = true;
			this.reviewersGrid.Size = new System.Drawing.Size(234, 289);
			this.reviewersGrid.TabIndex = 5;
			this.reviewersGrid.SelectionChanged += new System.EventHandler(this.reviewersGrid_SelectionChanged);
			// 
			// papersGrid
			// 
			this.papersGrid.AllowUserToAddRows = false;
			this.papersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.papersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.papersGrid.Location = new System.Drawing.Point(15, 54);
			this.papersGrid.Name = "papersGrid";
			this.papersGrid.ReadOnly = true;
			this.papersGrid.Size = new System.Drawing.Size(234, 289);
			this.papersGrid.TabIndex = 5;
			this.papersGrid.SelectionChanged += new System.EventHandler(this.papersGrid_SelectionChanged_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(270, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Available Dates";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(520, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Available Reviewers";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "New submitted papers";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "Assign Reviewer";
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(633, 412);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(124, 45);
			this.saveBtn.TabIndex = 7;
			this.saveBtn.Text = "Save assignment";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(31, 359);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 16);
			this.label5.TabIndex = 6;
			this.label5.Text = "Selected paper: ";
			// 
			// selectedPaperTxt
			// 
			this.selectedPaperTxt.AutoSize = true;
			this.selectedPaperTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedPaperTxt.Location = new System.Drawing.Point(160, 359);
			this.selectedPaperTxt.Name = "selectedPaperTxt";
			this.selectedPaperTxt.Size = new System.Drawing.Size(120, 16);
			this.selectedPaperTxt.TabIndex = 6;
			this.selectedPaperTxt.Text = "No paper selected";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(39, 384);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(115, 16);
			this.label7.TabIndex = 6;
			this.label7.Text = "Selected Date: ";
			// 
			// selectedDateTxt
			// 
			this.selectedDateTxt.AutoSize = true;
			this.selectedDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedDateTxt.Location = new System.Drawing.Point(160, 384);
			this.selectedDateTxt.Name = "selectedDateTxt";
			this.selectedDateTxt.Size = new System.Drawing.Size(111, 16);
			this.selectedDateTxt.TabIndex = 6;
			this.selectedDateTxt.Text = "No date selected";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(13, 412);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(141, 16);
			this.label9.TabIndex = 6;
			this.label9.Text = "Selected reviewer: ";
			// 
			// selectedReviewerTxt
			// 
			this.selectedReviewerTxt.AutoSize = true;
			this.selectedReviewerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.selectedReviewerTxt.Location = new System.Drawing.Point(160, 412);
			this.selectedReviewerTxt.Name = "selectedReviewerTxt";
			this.selectedReviewerTxt.Size = new System.Drawing.Size(135, 16);
			this.selectedReviewerTxt.TabIndex = 6;
			this.selectedReviewerTxt.Text = "No reveiwer selected";
			// 
			// Admin_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 469);
			this.Controls.Add(this.saveBtn);
			this.Controls.Add(this.selectedReviewerTxt);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.selectedDateTxt);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.selectedPaperTxt);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.papersGrid);
			this.Controls.Add(this.reviewersGrid);
			this.Controls.Add(this.datesGrid);
			this.Name = "Admin_form";
			this.Text = "Admin_form";
			this.Load += new System.EventHandler(this.Admin_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.datesGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reviewersGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.papersGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView datesGrid;
		private System.Windows.Forms.DataGridView reviewersGrid;
		private System.Windows.Forms.DataGridView papersGrid;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label selectedPaperTxt;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label selectedDateTxt;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label selectedReviewerTxt;
	}
}
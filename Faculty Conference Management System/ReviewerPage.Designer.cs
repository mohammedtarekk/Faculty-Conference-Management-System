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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewerPage));
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.nextDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPIC = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Gridview2 = new System.Windows.Forms.DataGridView();
            this.CrystalReport_BT = new CustomImageButton.ImageButtonCustom();
            this.SaveAll_BT = new CustomImageButton.ImageButtonCustom();
            this.ViewAll_BT = new CustomImageButton.ImageButtonCustom();
            this.Search_BT = new CustomImageButton.ImageButtonCustom();
            this.dragControl1 = new DragControlDemo.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveAll_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.AllowUserToDeleteRows = false;
            this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.GridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(16, 65);
            this.GridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GridView1.Name = "GridView1";
            this.GridView1.ReadOnly = true;
            this.GridView1.Size = new System.Drawing.Size(816, 358);
            this.GridView1.TabIndex = 0;
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.searchTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchTxt.Location = new System.Drawing.Point(1040, 96);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(193, 18);
            this.searchTxt.TabIndex = 2;
            this.searchTxt.Text = "SEARCH";
            this.searchTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTxt_MouseClick);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lable1.Location = new System.Drawing.Point(16, 22);
            this.lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(206, 19);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Next conference will be at";
            // 
            // nextDate
            // 
            this.nextDate.AutoSize = true;
            this.nextDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(75)))), ((int)(((byte)(68)))));
            this.nextDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextDate.Location = new System.Drawing.Point(251, 21);
            this.nextDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextDate.Name = "nextDate";
            this.nextDate.Size = new System.Drawing.Size(109, 19);
            this.nextDate.TabIndex = 3;
            this.nextDate.Text = "dd/mm/yyyy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPIC
            // 
            this.textBoxPIC.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPIC.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.textBoxPIC.Location = new System.Drawing.Point(1015, 79);
            this.textBoxPIC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPIC.Name = "textBoxPIC";
            this.textBoxPIC.Size = new System.Drawing.Size(255, 55);
            this.textBoxPIC.TabIndex = 7;
            this.textBoxPIC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(460, 441);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "ALL COPYRIGHTS RESERVED TO TEAM ABO NESMA @2020";
            // 
            // Gridview2
            // 
            this.Gridview2.AllowUserToAddRows = false;
            this.Gridview2.AllowUserToDeleteRows = false;
            this.Gridview2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Gridview2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gridview2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview2.Location = new System.Drawing.Point(859, 65);
            this.Gridview2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gridview2.Name = "Gridview2";
            this.Gridview2.Size = new System.Drawing.Size(148, 358);
            this.Gridview2.TabIndex = 16;
            this.Gridview2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview2_CellContentClick);
            this.Gridview2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview2_CellDoubleClick);
            // 
            // CrystalReport_BT
            // 
            this.CrystalReport_BT.BackColor = System.Drawing.Color.Transparent;
            this.CrystalReport_BT.Image = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.Image")));
            this.CrystalReport_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.ImageHover")));
            this.CrystalReport_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.ImageNormal")));
            this.CrystalReport_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.InitialImage")));
            this.CrystalReport_BT.Location = new System.Drawing.Point(1029, 220);
            this.CrystalReport_BT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CrystalReport_BT.Name = "CrystalReport_BT";
            this.CrystalReport_BT.Size = new System.Drawing.Size(232, 80);
            this.CrystalReport_BT.TabIndex = 15;
            this.CrystalReport_BT.TabStop = false;
            // 
            // SaveAll_BT
            // 
            this.SaveAll_BT.BackColor = System.Drawing.Color.Transparent;
            this.SaveAll_BT.Image = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.Image")));
            this.SaveAll_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.ImageHover")));
            this.SaveAll_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.ImageNormal")));
            this.SaveAll_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.InitialImage")));
            this.SaveAll_BT.Location = new System.Drawing.Point(1029, 299);
            this.SaveAll_BT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveAll_BT.Name = "SaveAll_BT";
            this.SaveAll_BT.Size = new System.Drawing.Size(232, 80);
            this.SaveAll_BT.TabIndex = 13;
            this.SaveAll_BT.TabStop = false;
            this.SaveAll_BT.Click += new System.EventHandler(this.SaveAll_BT_Click);
            // 
            // ViewAll_BT
            // 
            this.ViewAll_BT.BackColor = System.Drawing.Color.Transparent;
            this.ViewAll_BT.Image = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.Image")));
            this.ViewAll_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.ImageHover")));
            this.ViewAll_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.ImageNormal")));
            this.ViewAll_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.InitialImage")));
            this.ViewAll_BT.Location = new System.Drawing.Point(1029, 142);
            this.ViewAll_BT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewAll_BT.Name = "ViewAll_BT";
            this.ViewAll_BT.Size = new System.Drawing.Size(232, 80);
            this.ViewAll_BT.TabIndex = 12;
            this.ViewAll_BT.TabStop = false;
            this.ViewAll_BT.Click += new System.EventHandler(this.ViewAll_BT_Click);
            // 
            // Search_BT
            // 
            this.Search_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.Search_BT.Image = ((System.Drawing.Image)(resources.GetObject("Search_BT.Image")));
            this.Search_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("Search_BT.ImageHover")));
            this.Search_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Search_BT.ImageNormal")));
            this.Search_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("Search_BT.InitialImage")));
            this.Search_BT.Location = new System.Drawing.Point(1235, 94);
            this.Search_BT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_BT.Name = "Search_BT";
            this.Search_BT.Size = new System.Drawing.Size(27, 22);
            this.Search_BT.TabIndex = 8;
            this.Search_BT.TabStop = false;
            this.Search_BT.Click += new System.EventHandler(this.Search_BT_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // ReviewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1285, 460);
            this.Controls.Add(this.Gridview2);
            this.Controls.Add(this.CrystalReport_BT);
            this.Controls.Add(this.SaveAll_BT);
            this.Controls.Add(this.ViewAll_BT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Search_BT);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.textBoxPIC);
            this.Controls.Add(this.nextDate);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ReviewerPage";
            this.Text = "Reviewer";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveAll_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView GridView1;
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.Label lable1;
		private System.Windows.Forms.Label nextDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox textBoxPIC;
        private CustomImageButton.ImageButtonCustom Search_BT;
        private DragControlDemo.DragControl dragControl1;
        private System.Windows.Forms.Label label2;
        private CustomImageButton.ImageButtonCustom ViewAll_BT;
        private CustomImageButton.ImageButtonCustom SaveAll_BT;
        private CustomImageButton.ImageButtonCustom CrystalReport_BT;
		private System.Windows.Forms.DataGridView Gridview2;
	}
}
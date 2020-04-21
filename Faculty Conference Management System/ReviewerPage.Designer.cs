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
            this.GridView2 = new System.Windows.Forms.DataGridView();
            this.acceptRB = new System.Windows.Forms.RadioButton();
            this.rejectRB = new System.Windows.Forms.RadioButton();
            this.CrystalReport_BT = new CustomImageButton.ImageButtonCustom();
            this.SaveAll_BT = new CustomImageButton.ImageButtonCustom();
            this.ViewAll_BT = new CustomImageButton.ImageButtonCustom();
            this.Search_BT = new CustomImageButton.ImageButtonCustom();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.UpdateInfo_BT = new CustomImageButton.ImageButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveAll_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateInfo_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView1
            // 
            this.GridView1.AllowUserToAddRows = false;
            this.GridView1.AllowUserToDeleteRows = false;
            this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.GridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(12, 53);
            this.GridView1.MultiSelect = false;
            this.GridView1.Name = "GridView1";
            this.GridView1.ReadOnly = true;
            this.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView1.Size = new System.Drawing.Size(612, 291);
            this.GridView1.TabIndex = 0;
            this.GridView1.SelectionChanged += new System.EventHandler(this.GridView1_SelectionChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.searchTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchTxt.Location = new System.Drawing.Point(780, 27);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(145, 14);
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
            this.lable1.Location = new System.Drawing.Point(12, 18);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(169, 17);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Next conference will be at";
            // 
            // nextDate
            // 
            this.nextDate.AutoSize = true;
            this.nextDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(75)))), ((int)(((byte)(68)))));
            this.nextDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextDate.Location = new System.Drawing.Point(188, 17);
            this.nextDate.Name = "nextDate";
            this.nextDate.Size = new System.Drawing.Size(88, 17);
            this.nextDate.TabIndex = 3;
            this.nextDate.Text = "dd/mm/yyyy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(174, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPIC
            // 
            this.textBoxPIC.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPIC.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.textBoxPIC.Location = new System.Drawing.Point(761, 13);
            this.textBoxPIC.Name = "textBoxPIC";
            this.textBoxPIC.Size = new System.Drawing.Size(191, 45);
            this.textBoxPIC.TabIndex = 7;
            this.textBoxPIC.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(345, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "ALL COPYRIGHTS RESERVED TO TEAM ABO NESMA @2020";
            // 
            // GridView2
            // 
            this.GridView2.AllowUserToAddRows = false;
            this.GridView2.AllowUserToDeleteRows = false;
            this.GridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.GridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView2.Location = new System.Drawing.Point(644, 53);
            this.GridView2.MultiSelect = false;
            this.GridView2.Name = "GridView2";
            this.GridView2.ReadOnly = true;
            this.GridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView2.Size = new System.Drawing.Size(111, 291);
            this.GridView2.TabIndex = 16;
            this.GridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview2_CellDoubleClick);
            this.GridView2.SelectionChanged += new System.EventHandler(this.Gridview2_SelectionChanged);
            // 
            // acceptRB
            // 
            this.acceptRB.AutoSize = true;
            this.acceptRB.BackColor = System.Drawing.Color.Transparent;
            this.acceptRB.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.acceptRB.Location = new System.Drawing.Point(770, 64);
            this.acceptRB.Name = "acceptRB";
            this.acceptRB.Size = new System.Drawing.Size(98, 20);
            this.acceptRB.TabIndex = 17;
            this.acceptRB.Text = "Accept Paper";
            this.acceptRB.UseVisualStyleBackColor = false;
            this.acceptRB.Click += new System.EventHandler(this.acceptRB_Click);
            // 
            // rejectRB
            // 
            this.rejectRB.AutoSize = true;
            this.rejectRB.BackColor = System.Drawing.Color.Transparent;
            this.rejectRB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rejectRB.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rejectRB.Location = new System.Drawing.Point(867, 64);
            this.rejectRB.Name = "rejectRB";
            this.rejectRB.Size = new System.Drawing.Size(94, 20);
            this.rejectRB.TabIndex = 17;
            this.rejectRB.Text = "Reject Paper";
            this.rejectRB.UseVisualStyleBackColor = false;
            this.rejectRB.Click += new System.EventHandler(this.rejectRB_Click);
            // 
            // CrystalReport_BT
            // 
            this.CrystalReport_BT.BackColor = System.Drawing.Color.Transparent;
            this.CrystalReport_BT.Image = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.Image")));
            this.CrystalReport_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.ImageHover")));
            this.CrystalReport_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.ImageNormal")));
            this.CrystalReport_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.InitialImage")));
            this.CrystalReport_BT.Location = new System.Drawing.Point(772, 150);
            this.CrystalReport_BT.Name = "CrystalReport_BT";
            this.CrystalReport_BT.Size = new System.Drawing.Size(174, 65);
            this.CrystalReport_BT.TabIndex = 15;
            this.CrystalReport_BT.TabStop = false;
            this.CrystalReport_BT.Click += new System.EventHandler(this.CrystalReport_BT_Click);
            // 
            // SaveAll_BT
            // 
            this.SaveAll_BT.BackColor = System.Drawing.Color.Transparent;
            this.SaveAll_BT.Image = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.Image")));
            this.SaveAll_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.ImageHover")));
            this.SaveAll_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.ImageNormal")));
            this.SaveAll_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.InitialImage")));
            this.SaveAll_BT.Location = new System.Drawing.Point(772, 263);
            this.SaveAll_BT.Name = "SaveAll_BT";
            this.SaveAll_BT.Size = new System.Drawing.Size(174, 65);
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
            this.ViewAll_BT.Location = new System.Drawing.Point(772, 89);
            this.ViewAll_BT.Name = "ViewAll_BT";
            this.ViewAll_BT.Size = new System.Drawing.Size(174, 65);
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
            this.Search_BT.Location = new System.Drawing.Point(926, 25);
            this.Search_BT.Name = "Search_BT";
            this.Search_BT.Size = new System.Drawing.Size(20, 18);
            this.Search_BT.TabIndex = 8;
            this.Search_BT.TabStop = false;
            this.Search_BT.Click += new System.EventHandler(this.Search_BT_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // UpdateInfo_BT
            // 
            this.UpdateInfo_BT.BackColor = System.Drawing.Color.Transparent;
            this.UpdateInfo_BT.Image = ((System.Drawing.Image)(resources.GetObject("UpdateInfo_BT.Image")));
            this.UpdateInfo_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("UpdateInfo_BT.ImageHover")));
            this.UpdateInfo_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("UpdateInfo_BT.ImageNormal")));
            this.UpdateInfo_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("UpdateInfo_BT.InitialImage")));
            this.UpdateInfo_BT.Location = new System.Drawing.Point(772, 205);
            this.UpdateInfo_BT.Name = "UpdateInfo_BT";
            this.UpdateInfo_BT.Size = new System.Drawing.Size(174, 65);
            this.UpdateInfo_BT.TabIndex = 37;
            this.UpdateInfo_BT.TabStop = false;
            this.UpdateInfo_BT.Click += new System.EventHandler(this.UpdateInfo_BT_Click);
            // 
            // ReviewerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 374);
            this.Controls.Add(this.SaveAll_BT);
            this.Controls.Add(this.UpdateInfo_BT);
            this.Controls.Add(this.rejectRB);
            this.Controls.Add(this.acceptRB);
            this.Controls.Add(this.GridView2);
            this.Controls.Add(this.CrystalReport_BT);
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
            this.MaximizeBox = false;
            this.Name = "ReviewerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reviewer";
            this.Load += new System.EventHandler(this.ReviewerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveAll_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateInfo_BT)).EndInit();
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
		private System.Windows.Forms.DataGridView GridView2;
		private System.Windows.Forms.RadioButton rejectRB;
		private System.Windows.Forms.RadioButton acceptRB;
		private CustomImageButton.ImageButtonCustom UpdateInfo_BT;
	}
}
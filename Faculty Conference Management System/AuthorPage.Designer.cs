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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorPage));
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nextDate = new System.Windows.Forms.Label();
            this.Exit_BT = new CustomImageButton.ImageButtonCustom();
            this.lable1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Search_BT = new CustomImageButton.ImageButtonCustom();
            this.textBoxPIC = new System.Windows.Forms.PictureBox();
            this.ViewAll_BT = new CustomImageButton.ImageButtonCustom();
            this.CrystalReport_BT = new CustomImageButton.ImageButtonCustom();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit_BT = new CustomImageButton.ImageButtonCustom();
            this.dragControl1 = new DragControlDemo.DragControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submit_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.searchTxt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.searchTxt.Location = new System.Drawing.Point(784, 78);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(144, 14);
            this.searchTxt.TabIndex = 7;
            this.searchTxt.Text = "SEARCH";
            this.searchTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTxt_MouseClick);
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // GridView1
            // 
            this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.GridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(12, 58);
            this.GridView1.Name = "GridView1";
            this.GridView1.Size = new System.Drawing.Size(752, 289);
            this.GridView1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 30);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // nextDate
            // 
            this.nextDate.AutoSize = true;
            this.nextDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(75)))), ((int)(((byte)(68)))));
            this.nextDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextDate.Location = new System.Drawing.Point(487, 18);
            this.nextDate.Name = "nextDate";
            this.nextDate.Size = new System.Drawing.Size(88, 17);
            this.nextDate.TabIndex = 15;
            this.nextDate.Text = "dd/mm/yyyy";
            // 
            // Exit_BT
            // 
            this.Exit_BT.BackColor = System.Drawing.Color.Transparent;
            this.Exit_BT.Image = ((System.Drawing.Image)(resources.GetObject("Exit_BT.Image")));
            this.Exit_BT.ImageHover = global::Faculty_Conference_Management_System.Properties.Resources.Close;
            this.Exit_BT.ImageNormal = global::Faculty_Conference_Management_System.Properties.Resources.close_on_hover;
            this.Exit_BT.InitialImage = global::Faculty_Conference_Management_System.Properties.Resources.close_on_hover;
            this.Exit_BT.Location = new System.Drawing.Point(933, 13);
            this.Exit_BT.Name = "Exit_BT";
            this.Exit_BT.Size = new System.Drawing.Size(22, 21);
            this.Exit_BT.TabIndex = 17;
            this.Exit_BT.TabStop = false;
            this.Exit_BT.Click += new System.EventHandler(this.Exit_BT_Click);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lable1.Location = new System.Drawing.Point(311, 19);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(169, 17);
            this.lable1.TabIndex = 16;
            this.lable1.Text = "Next conference will be at";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(473, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Search_BT
            // 
            this.Search_BT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.Search_BT.Image = ((System.Drawing.Image)(resources.GetObject("Search_BT.Image")));
            this.Search_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("Search_BT.ImageHover")));
            this.Search_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Search_BT.ImageNormal")));
            this.Search_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("Search_BT.InitialImage")));
            this.Search_BT.Location = new System.Drawing.Point(930, 76);
            this.Search_BT.Name = "Search_BT";
            this.Search_BT.Size = new System.Drawing.Size(20, 18);
            this.Search_BT.TabIndex = 21;
            this.Search_BT.TabStop = false;
            this.Search_BT.Click += new System.EventHandler(this.Search_BT_Click);
            // 
            // textBoxPIC
            // 
            this.textBoxPIC.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPIC.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.textBoxPIC.Location = new System.Drawing.Point(765, 64);
            this.textBoxPIC.Name = "textBoxPIC";
            this.textBoxPIC.Size = new System.Drawing.Size(191, 45);
            this.textBoxPIC.TabIndex = 20;
            this.textBoxPIC.TabStop = false;
            // 
            // ViewAll_BT
            // 
            this.ViewAll_BT.BackColor = System.Drawing.Color.Transparent;
            this.ViewAll_BT.Image = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.Image")));
            this.ViewAll_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.ImageHover")));
            this.ViewAll_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.ImageNormal")));
            this.ViewAll_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("ViewAll_BT.InitialImage")));
            this.ViewAll_BT.Location = new System.Drawing.Point(776, 113);
            this.ViewAll_BT.Name = "ViewAll_BT";
            this.ViewAll_BT.Size = new System.Drawing.Size(174, 65);
            this.ViewAll_BT.TabIndex = 22;
            this.ViewAll_BT.TabStop = false;
            this.ViewAll_BT.Click += new System.EventHandler(this.ViewAll_BT_Click);
            // 
            // CrystalReport_BT
            // 
            this.CrystalReport_BT.BackColor = System.Drawing.Color.Transparent;
            this.CrystalReport_BT.Image = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.Image")));
            this.CrystalReport_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.ImageHover")));
            this.CrystalReport_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.ImageNormal")));
            this.CrystalReport_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("CrystalReport_BT.InitialImage")));
            this.CrystalReport_BT.Location = new System.Drawing.Point(776, 177);
            this.CrystalReport_BT.Name = "CrystalReport_BT";
            this.CrystalReport_BT.Size = new System.Drawing.Size(174, 65);
            this.CrystalReport_BT.TabIndex = 23;
            this.CrystalReport_BT.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(364, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "ALL COPYRIGHTS RESERVED TO TEAM ABO NESMA @2020";
            // 
            // Submit_BT
            // 
            this.Submit_BT.BackColor = System.Drawing.Color.Transparent;
            this.Submit_BT.Image = ((System.Drawing.Image)(resources.GetObject("Submit_BT.Image")));
            this.Submit_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("Submit_BT.ImageHover")));
            this.Submit_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Submit_BT.ImageNormal")));
            this.Submit_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("Submit_BT.InitialImage")));
            this.Submit_BT.Location = new System.Drawing.Point(776, 241);
            this.Submit_BT.Name = "Submit_BT";
            this.Submit_BT.Size = new System.Drawing.Size(174, 65);
            this.Submit_BT.TabIndex = 25;
            this.Submit_BT.TabStop = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // AuthorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 374);
            this.Controls.Add(this.Submit_BT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrystalReport_BT);
            this.Controls.Add(this.ViewAll_BT);
            this.Controls.Add(this.Search_BT);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nextDate);
            this.Controls.Add(this.Exit_BT);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.textBoxPIC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorPage";
            this.Text = "AuthorPage";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submit_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox searchTxt;
		private System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nextDate;
        private CustomImageButton.ImageButtonCustom Exit_BT;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomImageButton.ImageButtonCustom Search_BT;
        private System.Windows.Forms.PictureBox textBoxPIC;
        private CustomImageButton.ImageButtonCustom ViewAll_BT;
        private CustomImageButton.ImageButtonCustom CrystalReport_BT;
        private System.Windows.Forms.Label label2;
        private CustomImageButton.ImageButtonCustom Submit_BT;
        private DragControlDemo.DragControl dragControl1;
    }
}
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
			this.GridView1 = new System.Windows.Forms.DataGridView();
			this.SaveAll_BT = new CustomImageButton.ImageButtonCustom();
			this.label11 = new System.Windows.Forms.Label();
			this.PaperDataPnl = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.contentTxt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.titleLbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.revNameLbl = new System.Windows.Forms.Label();
			this.authorNameLbl = new System.Windows.Forms.Label();
			this.revIdLbl = new System.Windows.Forms.Label();
			this.authorIdLbl = new System.Windows.Forms.Label();
			this.idLbl = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.categoryLbl = new System.Windows.Forms.Label();
			this.stateLbl = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Exit_BT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Search_BT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Submit_BT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SaveAll_BT)).BeginInit();
			this.PaperDataPnl.SuspendLayout();
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
			// GridView1
			// 
			this.GridView1.AllowUserToAddRows = false;
			this.GridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridView1.Location = new System.Drawing.Point(12, 58);
			this.GridView1.Name = "GridView1";
			this.GridView1.ReadOnly = true;
			this.GridView1.Size = new System.Drawing.Size(234, 289);
			this.GridView1.TabIndex = 4;
			this.GridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridView1_RowHeaderMouseClick);
			// 
			// SaveAll_BT
			// 
			this.SaveAll_BT.BackColor = System.Drawing.Color.Transparent;
			this.SaveAll_BT.Image = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.Image")));
			this.SaveAll_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.ImageHover")));
			this.SaveAll_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.ImageNormal")));
			this.SaveAll_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("SaveAll_BT.InitialImage")));
			this.SaveAll_BT.Location = new System.Drawing.Point(776, 297);
			this.SaveAll_BT.Name = "SaveAll_BT";
			this.SaveAll_BT.Size = new System.Drawing.Size(174, 65);
			this.SaveAll_BT.TabIndex = 26;
			this.SaveAll_BT.TabStop = false;
			this.SaveAll_BT.Click += new System.EventHandler(this.SaveAll_BT_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.DarkGray;
			this.label11.Location = new System.Drawing.Point(376, 155);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(251, 40);
			this.label11.TabIndex = 27;
			this.label11.Text = "Select a paper to show details\r\n                       <--";
			// 
			// PaperDataPnl
			// 
			this.PaperDataPnl.BackColor = System.Drawing.Color.Transparent;
			this.PaperDataPnl.Controls.Add(this.label8);
			this.PaperDataPnl.Controls.Add(this.contentTxt);
			this.PaperDataPnl.Controls.Add(this.label6);
			this.PaperDataPnl.Controls.Add(this.titleLbl);
			this.PaperDataPnl.Controls.Add(this.label3);
			this.PaperDataPnl.Controls.Add(this.revNameLbl);
			this.PaperDataPnl.Controls.Add(this.authorNameLbl);
			this.PaperDataPnl.Controls.Add(this.revIdLbl);
			this.PaperDataPnl.Controls.Add(this.authorIdLbl);
			this.PaperDataPnl.Controls.Add(this.idLbl);
			this.PaperDataPnl.Controls.Add(this.label7);
			this.PaperDataPnl.Controls.Add(this.label4);
			this.PaperDataPnl.Controls.Add(this.categoryLbl);
			this.PaperDataPnl.Controls.Add(this.stateLbl);
			this.PaperDataPnl.Controls.Add(this.label10);
			this.PaperDataPnl.Controls.Add(this.label9);
			this.PaperDataPnl.Controls.Add(this.label5);
			this.PaperDataPnl.Controls.Add(this.label1);
			this.PaperDataPnl.Location = new System.Drawing.Point(263, 58);
			this.PaperDataPnl.Name = "PaperDataPnl";
			this.PaperDataPnl.Size = new System.Drawing.Size(507, 289);
			this.PaperDataPnl.TabIndex = 30;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(3, 131);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(163, 20);
			this.label8.TabIndex = 27;
			this.label8.Text = "Research Category";
			// 
			// contentTxt
			// 
			this.contentTxt.Location = new System.Drawing.Point(96, 172);
			this.contentTxt.Multiline = true;
			this.contentTxt.Name = "contentTxt";
			this.contentTxt.Size = new System.Drawing.Size(346, 101);
			this.contentTxt.TabIndex = 28;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(5, 96);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 20);
			this.label6.TabIndex = 27;
			this.label6.Text = "Reviewer ID";
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.BackColor = System.Drawing.Color.Transparent;
			this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLbl.ForeColor = System.Drawing.Color.Silver;
			this.titleLbl.Location = new System.Drawing.Point(391, 10);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(38, 20);
			this.titleLbl.TabIndex = 27;
			this.titleLbl.Text = "Title";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(296, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(95, 20);
			this.label3.TabIndex = 27;
			this.label3.Text = "Paper Title";
			// 
			// revNameLbl
			// 
			this.revNameLbl.AutoSize = true;
			this.revNameLbl.BackColor = System.Drawing.Color.Transparent;
			this.revNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.revNameLbl.ForeColor = System.Drawing.Color.Silver;
			this.revNameLbl.Location = new System.Drawing.Point(391, 96);
			this.revNameLbl.Name = "revNameLbl";
			this.revNameLbl.Size = new System.Drawing.Size(51, 20);
			this.revNameLbl.TabIndex = 27;
			this.revNameLbl.Text = "Name";
			// 
			// authorNameLbl
			// 
			this.authorNameLbl.AutoSize = true;
			this.authorNameLbl.BackColor = System.Drawing.Color.Transparent;
			this.authorNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.authorNameLbl.ForeColor = System.Drawing.Color.Silver;
			this.authorNameLbl.Location = new System.Drawing.Point(391, 51);
			this.authorNameLbl.Name = "authorNameLbl";
			this.authorNameLbl.Size = new System.Drawing.Size(51, 20);
			this.authorNameLbl.TabIndex = 27;
			this.authorNameLbl.Text = "Name";
			// 
			// revIdLbl
			// 
			this.revIdLbl.AutoSize = true;
			this.revIdLbl.BackColor = System.Drawing.Color.Transparent;
			this.revIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.revIdLbl.ForeColor = System.Drawing.Color.Silver;
			this.revIdLbl.Location = new System.Drawing.Point(118, 96);
			this.revIdLbl.Name = "revIdLbl";
			this.revIdLbl.Size = new System.Drawing.Size(26, 20);
			this.revIdLbl.TabIndex = 27;
			this.revIdLbl.Text = "ID";
			// 
			// authorIdLbl
			// 
			this.authorIdLbl.AutoSize = true;
			this.authorIdLbl.BackColor = System.Drawing.Color.Transparent;
			this.authorIdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.authorIdLbl.ForeColor = System.Drawing.Color.Silver;
			this.authorIdLbl.Location = new System.Drawing.Point(118, 51);
			this.authorIdLbl.Name = "authorIdLbl";
			this.authorIdLbl.Size = new System.Drawing.Size(26, 20);
			this.authorIdLbl.TabIndex = 27;
			this.authorIdLbl.Text = "ID";
			// 
			// idLbl
			// 
			this.idLbl.AutoSize = true;
			this.idLbl.BackColor = System.Drawing.Color.Transparent;
			this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idLbl.ForeColor = System.Drawing.Color.Silver;
			this.idLbl.Location = new System.Drawing.Point(118, 12);
			this.idLbl.Name = "idLbl";
			this.idLbl.Size = new System.Drawing.Size(26, 20);
			this.idLbl.TabIndex = 27;
			this.idLbl.Text = "ID";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(258, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 20);
			this.label7.TabIndex = 27;
			this.label7.Text = "Reviewer Name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(277, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 20);
			this.label4.TabIndex = 27;
			this.label4.Text = "Author Name";
			// 
			// categoryLbl
			// 
			this.categoryLbl.AutoSize = true;
			this.categoryLbl.BackColor = System.Drawing.Color.Transparent;
			this.categoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.categoryLbl.ForeColor = System.Drawing.Color.Silver;
			this.categoryLbl.Location = new System.Drawing.Point(164, 131);
			this.categoryLbl.Name = "categoryLbl";
			this.categoryLbl.Size = new System.Drawing.Size(73, 20);
			this.categoryLbl.TabIndex = 27;
			this.categoryLbl.Text = "Category";
			// 
			// stateLbl
			// 
			this.stateLbl.AutoSize = true;
			this.stateLbl.BackColor = System.Drawing.Color.Transparent;
			this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stateLbl.ForeColor = System.Drawing.Color.Silver;
			this.stateLbl.Location = new System.Drawing.Point(391, 127);
			this.stateLbl.Name = "stateLbl";
			this.stateLbl.Size = new System.Drawing.Size(45, 20);
			this.stateLbl.TabIndex = 27;
			this.stateLbl.Text = "state";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(279, 127);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 20);
			this.label10.TabIndex = 27;
			this.label10.Text = "Review state";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(11, 169);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 20);
			this.label9.TabIndex = 27;
			this.label9.Text = "Content";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(5, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 20);
			this.label5.TabIndex = 27;
			this.label5.Text = "Author ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 27;
			this.label1.Text = "Paper ID";
			// 
			// AuthorPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(964, 374);
			this.Controls.Add(this.PaperDataPnl);
			this.Controls.Add(this.SaveAll_BT);
			this.Controls.Add(this.Submit_BT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CrystalReport_BT);
			this.Controls.Add(this.ViewAll_BT);
			this.Controls.Add(this.Search_BT);
			this.Controls.Add(this.nextDate);
			this.Controls.Add(this.Exit_BT);
			this.Controls.Add(this.lable1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.searchTxt);
			this.Controls.Add(this.GridView1);
			this.Controls.Add(this.textBoxPIC);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label11);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AuthorPage";
			this.Text = "AuthorPage";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Exit_BT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Search_BT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ViewAll_BT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CrystalReport_BT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Submit_BT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SaveAll_BT)).EndInit();
			this.PaperDataPnl.ResumeLayout(false);
			this.PaperDataPnl.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox searchTxt;
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
		private System.Windows.Forms.DataGridView GridView1;
		private CustomImageButton.ImageButtonCustom SaveAll_BT;
		private System.Windows.Forms.Panel PaperDataPnl;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox contentTxt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label titleLbl;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label revNameLbl;
		private System.Windows.Forms.Label authorNameLbl;
		private System.Windows.Forms.Label revIdLbl;
		private System.Windows.Forms.Label authorIdLbl;
		private System.Windows.Forms.Label idLbl;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label categoryLbl;
		private System.Windows.Forms.Label stateLbl;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label11;
	}
}
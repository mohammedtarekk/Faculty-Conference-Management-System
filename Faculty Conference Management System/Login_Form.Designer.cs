namespace Faculty_Conference_Management_System
{
    partial class Login_Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
			this.textBoxPIC = new System.Windows.Forms.PictureBox();
			this.UserID_txt = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.Password_txt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RegisterNowBT = new System.Windows.Forms.PictureBox();
			this.AuthorRB = new System.Windows.Forms.RadioButton();
			this.ReviewerRB = new System.Windows.Forms.RadioButton();
			this.SignIn_bt = new CustomImageButton.ImageButtonCustom();
			this.Reviewer_RB_lbl = new CustomImageButton.ImageButtonCustom();
			this.Author_RB_lbl = new CustomImageButton.ImageButtonCustom();
			this.DragControlStartForm = new DragControlDemo.DragControl();
			this.AdminRB = new System.Windows.Forms.RadioButton();
			this.imageButtonCustom1 = new CustomImageButton.ImageButtonCustom();
			((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterNowBT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SignIn_bt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Reviewer_RB_lbl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Author_RB_lbl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCustom1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxPIC
			// 
			this.textBoxPIC.BackColor = System.Drawing.Color.Transparent;
			this.textBoxPIC.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
			this.textBoxPIC.Location = new System.Drawing.Point(345, 173);
			this.textBoxPIC.Name = "textBoxPIC";
			this.textBoxPIC.Size = new System.Drawing.Size(191, 45);
			this.textBoxPIC.TabIndex = 2;
			this.textBoxPIC.TabStop = false;
			// 
			// UserID_txt
			// 
			this.UserID_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
			this.UserID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.UserID_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UserID_txt.ForeColor = System.Drawing.SystemColors.GrayText;
			this.UserID_txt.Location = new System.Drawing.Point(365, 186);
			this.UserID_txt.Name = "UserID_txt";
			this.UserID_txt.Size = new System.Drawing.Size(159, 14);
			this.UserID_txt.TabIndex = 3;
			this.UserID_txt.Text = "USER  ID";
			this.UserID_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UserID_txt_MouseClick);
			this.UserID_txt.TextChanged += new System.EventHandler(this.UserID_txt_TextChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
			this.pictureBox1.Location = new System.Drawing.Point(345, 213);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(191, 45);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// Password_txt
			// 
			this.Password_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
			this.Password_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Password_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_txt.ForeColor = System.Drawing.SystemColors.GrayText;
			this.Password_txt.Location = new System.Drawing.Point(365, 226);
			this.Password_txt.Name = "Password_txt";
			this.Password_txt.Size = new System.Drawing.Size(159, 14);
			this.Password_txt.TabIndex = 5;
			this.Password_txt.Text = "PASSWORD";
			this.Password_txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Password_txt_MouseClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(199, 359);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(263, 14);
			this.label2.TabIndex = 10;
			this.label2.Text = "ALL COPYRIGHTS RESERVED TO TEAM ABO NESMA @2020";
			// 
			// RegisterNowBT
			// 
			this.RegisterNowBT.BackColor = System.Drawing.Color.Transparent;
			this.RegisterNowBT.Image = global::Faculty_Conference_Management_System.Properties.Resources.RegisterNow;
			this.RegisterNowBT.Location = new System.Drawing.Point(458, 275);
			this.RegisterNowBT.Name = "RegisterNowBT";
			this.RegisterNowBT.Size = new System.Drawing.Size(104, 32);
			this.RegisterNowBT.TabIndex = 13;
			this.RegisterNowBT.TabStop = false;
			this.RegisterNowBT.Click += new System.EventHandler(this.RegisterNowBT_Click);
			// 
			// AuthorRB
			// 
			this.AuthorRB.AutoSize = true;
			this.AuthorRB.BackColor = System.Drawing.Color.Transparent;
			this.AuthorRB.Location = new System.Drawing.Point(346, 258);
			this.AuthorRB.Name = "AuthorRB";
			this.AuthorRB.Size = new System.Drawing.Size(14, 13);
			this.AuthorRB.TabIndex = 14;
			this.AuthorRB.TabStop = true;
			this.AuthorRB.UseVisualStyleBackColor = false;
			// 
			// ReviewerRB
			// 
			this.ReviewerRB.AutoSize = true;
			this.ReviewerRB.BackColor = System.Drawing.Color.Transparent;
			this.ReviewerRB.Location = new System.Drawing.Point(416, 258);
			this.ReviewerRB.Name = "ReviewerRB";
			this.ReviewerRB.Size = new System.Drawing.Size(14, 13);
			this.ReviewerRB.TabIndex = 15;
			this.ReviewerRB.TabStop = true;
			this.ReviewerRB.UseVisualStyleBackColor = false;
			// 
			// SignIn_bt
			// 
			this.SignIn_bt.BackColor = System.Drawing.Color.Transparent;
			this.SignIn_bt.Image = global::Faculty_Conference_Management_System.Properties.Resources.SigninButton;
			this.SignIn_bt.ImageHover = global::Faculty_Conference_Management_System.Properties.Resources.SigninButtonOnHover;
			this.SignIn_bt.ImageNormal = global::Faculty_Conference_Management_System.Properties.Resources.SigninButton;
			this.SignIn_bt.InitialImage = global::Faculty_Conference_Management_System.Properties.Resources.SigninButton;
			this.SignIn_bt.Location = new System.Drawing.Point(135, 237);
			this.SignIn_bt.Name = "SignIn_bt";
			this.SignIn_bt.Size = new System.Drawing.Size(182, 72);
			this.SignIn_bt.TabIndex = 9;
			this.SignIn_bt.TabStop = false;
			this.SignIn_bt.Click += new System.EventHandler(this.SignIn_bt_Click);
			// 
			// Reviewer_RB_lbl
			// 
			this.Reviewer_RB_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Reviewer_RB_lbl.Image = global::Faculty_Conference_Management_System.Properties.Resources.radioReviewer;
			this.Reviewer_RB_lbl.ImageHover = global::Faculty_Conference_Management_System.Properties.Resources.radioReviewerOnHover;
			this.Reviewer_RB_lbl.ImageNormal = global::Faculty_Conference_Management_System.Properties.Resources.radioReviewer;
			this.Reviewer_RB_lbl.InitialImage = global::Faculty_Conference_Management_System.Properties.Resources.radioReviewer;
			this.Reviewer_RB_lbl.Location = new System.Drawing.Point(413, 255);
			this.Reviewer_RB_lbl.Name = "Reviewer_RB_lbl";
			this.Reviewer_RB_lbl.Size = new System.Drawing.Size(64, 20);
			this.Reviewer_RB_lbl.TabIndex = 8;
			this.Reviewer_RB_lbl.TabStop = false;
			// 
			// Author_RB_lbl
			// 
			this.Author_RB_lbl.BackColor = System.Drawing.Color.Transparent;
			this.Author_RB_lbl.Image = global::Faculty_Conference_Management_System.Properties.Resources.radioAuthor;
			this.Author_RB_lbl.ImageHover = global::Faculty_Conference_Management_System.Properties.Resources.radioAuthorOnHover;
			this.Author_RB_lbl.ImageNormal = global::Faculty_Conference_Management_System.Properties.Resources.radioAuthor;
			this.Author_RB_lbl.InitialImage = global::Faculty_Conference_Management_System.Properties.Resources.radioAuthor;
			this.Author_RB_lbl.Location = new System.Drawing.Point(343, 255);
			this.Author_RB_lbl.Name = "Author_RB_lbl";
			this.Author_RB_lbl.Size = new System.Drawing.Size(64, 20);
			this.Author_RB_lbl.TabIndex = 7;
			this.Author_RB_lbl.TabStop = false;
			// 
			// DragControlStartForm
			// 
			this.DragControlStartForm.SelectControl = this;
			// 
			// AdminRB
			// 
			this.AdminRB.AutoSize = true;
			this.AdminRB.BackColor = System.Drawing.Color.Transparent;
			this.AdminRB.Location = new System.Drawing.Point(486, 258);
			this.AdminRB.Name = "AdminRB";
			this.AdminRB.Size = new System.Drawing.Size(14, 13);
			this.AdminRB.TabIndex = 38;
			this.AdminRB.TabStop = true;
			this.AdminRB.UseVisualStyleBackColor = false;
			// 
			// imageButtonCustom1
			// 
			this.imageButtonCustom1.BackColor = System.Drawing.Color.Transparent;
			this.imageButtonCustom1.Image = ((System.Drawing.Image)(resources.GetObject("imageButtonCustom1.Image")));
			this.imageButtonCustom1.ImageHover = ((System.Drawing.Image)(resources.GetObject("imageButtonCustom1.ImageHover")));
			this.imageButtonCustom1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("imageButtonCustom1.ImageNormal")));
			this.imageButtonCustom1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imageButtonCustom1.InitialImage")));
			this.imageButtonCustom1.Location = new System.Drawing.Point(483, 255);
			this.imageButtonCustom1.Name = "imageButtonCustom1";
			this.imageButtonCustom1.Size = new System.Drawing.Size(64, 20);
			this.imageButtonCustom1.TabIndex = 39;
			this.imageButtonCustom1.TabStop = false;
			// 
			// Login_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Faculty_Conference_Management_System.Properties.Resources.BACKGROUNDFINAL;
			this.ClientSize = new System.Drawing.Size(656, 375);
			this.Controls.Add(this.AdminRB);
			this.Controls.Add(this.ReviewerRB);
			this.Controls.Add(this.AuthorRB);
			this.Controls.Add(this.RegisterNowBT);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SignIn_bt);
			this.Controls.Add(this.Reviewer_RB_lbl);
			this.Controls.Add(this.Author_RB_lbl);
			this.Controls.Add(this.Password_txt);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.UserID_txt);
			this.Controls.Add(this.textBoxPIC);
			this.Controls.Add(this.imageButtonCustom1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Login_Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Faculty Conference Management System";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_Form_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterNowBT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SignIn_bt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Reviewer_RB_lbl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Author_RB_lbl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageButtonCustom1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DragControlDemo.DragControl DragControlStartForm;
        private System.Windows.Forms.PictureBox textBoxPIC;
        private System.Windows.Forms.TextBox UserID_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomImageButton.ImageButtonCustom Author_RB_lbl;
        private CustomImageButton.ImageButtonCustom Reviewer_RB_lbl;
        private CustomImageButton.ImageButtonCustom SignIn_bt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox RegisterNowBT;
        private System.Windows.Forms.RadioButton AuthorRB;
        private System.Windows.Forms.RadioButton ReviewerRB;
        private System.Windows.Forms.RadioButton AdminRB;
        private CustomImageButton.ImageButtonCustom imageButtonCustom1;
    }
}


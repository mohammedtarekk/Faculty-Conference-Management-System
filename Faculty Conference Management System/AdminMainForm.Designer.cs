namespace Faculty_Conference_Management_System
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.AssignBT = new System.Windows.Forms.PictureBox();
            this.BookAppointmentBT = new System.Windows.Forms.PictureBox();
            this.Delete_Author_btn = new System.Windows.Forms.Button();
            this.Delete_Reviewer_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AssignBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAppointmentBT)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignBT
            // 
            this.AssignBT.BackColor = System.Drawing.Color.Transparent;
            this.AssignBT.Image = ((System.Drawing.Image)(resources.GetObject("AssignBT.Image")));
            this.AssignBT.InitialImage = ((System.Drawing.Image)(resources.GetObject("AssignBT.InitialImage")));
            this.AssignBT.Location = new System.Drawing.Point(298, 80);
            this.AssignBT.Name = "AssignBT";
            this.AssignBT.Size = new System.Drawing.Size(257, 122);
            this.AssignBT.TabIndex = 32;
            this.AssignBT.TabStop = false;
            this.AssignBT.Click += new System.EventHandler(this.AssignBT_Click);
            // 
            // BookAppointmentBT
            // 
            this.BookAppointmentBT.BackColor = System.Drawing.Color.Transparent;
            this.BookAppointmentBT.Image = ((System.Drawing.Image)(resources.GetObject("BookAppointmentBT.Image")));
            this.BookAppointmentBT.InitialImage = ((System.Drawing.Image)(resources.GetObject("BookAppointmentBT.InitialImage")));
            this.BookAppointmentBT.Location = new System.Drawing.Point(35, 80);
            this.BookAppointmentBT.Name = "BookAppointmentBT";
            this.BookAppointmentBT.Size = new System.Drawing.Size(257, 122);
            this.BookAppointmentBT.TabIndex = 33;
            this.BookAppointmentBT.TabStop = false;
            this.BookAppointmentBT.Click += new System.EventHandler(this.BookAppointmentBT_Click);
            // 
            // Delete_Author_btn
            // 
            this.Delete_Author_btn.Location = new System.Drawing.Point(83, 224);
            this.Delete_Author_btn.Name = "Delete_Author_btn";
            this.Delete_Author_btn.Size = new System.Drawing.Size(130, 37);
            this.Delete_Author_btn.TabIndex = 34;
            this.Delete_Author_btn.Text = "Delete Author ";
            this.Delete_Author_btn.UseVisualStyleBackColor = true;
            this.Delete_Author_btn.Click += new System.EventHandler(this.Delete_Author_btn_Click);
            // 
            // Delete_Reviewer_btn
            // 
            this.Delete_Reviewer_btn.Location = new System.Drawing.Point(338, 224);
            this.Delete_Reviewer_btn.Name = "Delete_Reviewer_btn";
            this.Delete_Reviewer_btn.Size = new System.Drawing.Size(130, 37);
            this.Delete_Reviewer_btn.TabIndex = 35;
            this.Delete_Reviewer_btn.Text = "Delete Reviewer";
            this.Delete_Reviewer_btn.UseVisualStyleBackColor = true;
            this.Delete_Reviewer_btn.Click += new System.EventHandler(this.Delete_Reviewer_btn_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 273);
            this.Controls.Add(this.Delete_Reviewer_btn);
            this.Controls.Add(this.Delete_Author_btn);
            this.Controls.Add(this.BookAppointmentBT);
            this.Controls.Add(this.AssignBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AssignBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAppointmentBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AssignBT;
        private System.Windows.Forms.PictureBox BookAppointmentBT;
        private System.Windows.Forms.Button Delete_Author_btn;
        private System.Windows.Forms.Button Delete_Reviewer_btn;
    }
}
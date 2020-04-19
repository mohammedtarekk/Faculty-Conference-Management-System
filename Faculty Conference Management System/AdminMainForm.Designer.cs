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
            this.DeleteAuthor_BT = new System.Windows.Forms.PictureBox();
            this.DeleteRev_BT = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AssignBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAppointmentBT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAuthor_BT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRev_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignBT
            // 
            this.AssignBT.BackColor = System.Drawing.Color.Transparent;
            this.AssignBT.Image = ((System.Drawing.Image)(resources.GetObject("AssignBT.Image")));
            this.AssignBT.InitialImage = ((System.Drawing.Image)(resources.GetObject("AssignBT.InitialImage")));
            this.AssignBT.Location = new System.Drawing.Point(298, 47);
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
            this.BookAppointmentBT.Location = new System.Drawing.Point(35, 47);
            this.BookAppointmentBT.Name = "BookAppointmentBT";
            this.BookAppointmentBT.Size = new System.Drawing.Size(257, 122);
            this.BookAppointmentBT.TabIndex = 33;
            this.BookAppointmentBT.TabStop = false;
            this.BookAppointmentBT.Click += new System.EventHandler(this.BookAppointmentBT_Click);
            // 
            // DeleteAuthor_BT
            // 
            this.DeleteAuthor_BT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteAuthor_BT.Image = ((System.Drawing.Image)(resources.GetObject("DeleteAuthor_BT.Image")));
            this.DeleteAuthor_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("DeleteAuthor_BT.InitialImage")));
            this.DeleteAuthor_BT.Location = new System.Drawing.Point(298, 175);
            this.DeleteAuthor_BT.Name = "DeleteAuthor_BT";
            this.DeleteAuthor_BT.Size = new System.Drawing.Size(257, 122);
            this.DeleteAuthor_BT.TabIndex = 36;
            this.DeleteAuthor_BT.TabStop = false;
            this.DeleteAuthor_BT.Click += new System.EventHandler(this.DeleteAuthor_BT_Click);
            // 
            // DeleteRev_BT
            // 
            this.DeleteRev_BT.BackColor = System.Drawing.Color.Transparent;
            this.DeleteRev_BT.Image = ((System.Drawing.Image)(resources.GetObject("DeleteRev_BT.Image")));
            this.DeleteRev_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("DeleteRev_BT.InitialImage")));
            this.DeleteRev_BT.Location = new System.Drawing.Point(35, 175);
            this.DeleteRev_BT.Name = "DeleteRev_BT";
            this.DeleteRev_BT.Size = new System.Drawing.Size(257, 122);
            this.DeleteRev_BT.TabIndex = 37;
            this.DeleteRev_BT.TabStop = false;
            this.DeleteRev_BT.Click += new System.EventHandler(this.DeleteRev_BT_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 339);
            this.Controls.Add(this.DeleteRev_BT);
            this.Controls.Add(this.DeleteAuthor_BT);
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
            ((System.ComponentModel.ISupportInitialize)(this.DeleteAuthor_BT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteRev_BT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AssignBT;
        private System.Windows.Forms.PictureBox BookAppointmentBT;
        private System.Windows.Forms.PictureBox DeleteAuthor_BT;
        private System.Windows.Forms.PictureBox DeleteRev_BT;
    }
}
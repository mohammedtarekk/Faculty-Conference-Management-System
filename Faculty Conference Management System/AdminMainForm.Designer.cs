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
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(590, 273);
            this.Controls.Add(this.BookAppointmentBT);
            this.Controls.Add(this.AssignBT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AdminMainForm";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminMainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.AssignBT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookAppointmentBT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AssignBT;
        private System.Windows.Forms.PictureBox BookAppointmentBT;
    }
}
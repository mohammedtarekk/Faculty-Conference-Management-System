namespace Faculty_Conference_Management_System
{
    partial class BookAppointmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookAppointmentForm));
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AcceptedPapersGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectedPaper_txt = new System.Windows.Forms.TextBox();
            this.DatesCB = new System.Windows.Forms.ComboBox();
            this.Finish_BT = new CustomImageButton.ImageButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedPapersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(165, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 14);
            this.label2.TabIndex = 26;
            this.label2.Text = "ALL COPYRIGHTS RESERVED TO TEAM ABO NESMA @2020";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 33);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // AcceptedPapersGrid
            // 
            this.AcceptedPapersGrid.AllowUserToAddRows = false;
            this.AcceptedPapersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.AcceptedPapersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptedPapersGrid.Location = new System.Drawing.Point(12, 52);
            this.AcceptedPapersGrid.Name = "AcceptedPapersGrid";
            this.AcceptedPapersGrid.ReadOnly = true;
            this.AcceptedPapersGrid.Size = new System.Drawing.Size(369, 289);
            this.AcceptedPapersGrid.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(396, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select a date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.pictureBox2.Location = new System.Drawing.Point(387, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 45);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(396, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Selected Paper ID";
            // 
            // SelectedPaper_txt
            // 
            this.SelectedPaper_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.SelectedPaper_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedPaper_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.SelectedPaper_txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SelectedPaper_txt.Location = new System.Drawing.Point(406, 88);
            this.SelectedPaper_txt.Name = "SelectedPaper_txt";
            this.SelectedPaper_txt.ReadOnly = true;
            this.SelectedPaper_txt.Size = new System.Drawing.Size(161, 14);
            this.SelectedPaper_txt.TabIndex = 33;
            this.SelectedPaper_txt.Text = "SELECT PAPER FROM GRID";
            // 
            // DatesCB
            // 
            this.DatesCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.DatesCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatesCB.FormattingEnabled = true;
            this.DatesCB.Location = new System.Drawing.Point(399, 152);
            this.DatesCB.Name = "DatesCB";
            this.DatesCB.Size = new System.Drawing.Size(173, 21);
            this.DatesCB.TabIndex = 34;
            // 
            // Finish_BT
            // 
            this.Finish_BT.BackColor = System.Drawing.Color.Transparent;
            this.Finish_BT.Image = ((System.Drawing.Image)(resources.GetObject("Finish_BT.Image")));
            this.Finish_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("Finish_BT.ImageHover")));
            this.Finish_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Finish_BT.ImageNormal")));
            this.Finish_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("Finish_BT.InitialImage")));
            this.Finish_BT.Location = new System.Drawing.Point(398, 276);
            this.Finish_BT.Name = "Finish_BT";
            this.Finish_BT.Size = new System.Drawing.Size(174, 65);
            this.Finish_BT.TabIndex = 35;
            this.Finish_BT.TabStop = false;
            // 
            // BookAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(591, 372);
            this.Controls.Add(this.Finish_BT);
            this.Controls.Add(this.DatesCB);
            this.Controls.Add(this.SelectedPaper_txt);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AcceptedPapersGrid);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookAppointmentForm";
            this.Text = "Book an appointment";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookAppointmentForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedPapersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Finish_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView AcceptedPapersGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SelectedPaper_txt;
        private System.Windows.Forms.ComboBox DatesCB;
        private CustomImageButton.ImageButtonCustom Finish_BT;
    }
}
namespace Faculty_Conference_Management_System
{
    partial class Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.ID_txt = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete_BT = new CustomImageButton.ImageButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(15, 63);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(569, 228);
            this.GridView.TabIndex = 0;
            // 
            // ID_txt
            // 
            this.ID_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.ID_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_txt.ForeColor = System.Drawing.Color.Silver;
            this.ID_txt.Location = new System.Drawing.Point(90, 26);
            this.ID_txt.Name = "ID_txt";
            this.ID_txt.Size = new System.Drawing.Size(163, 13);
            this.ID_txt.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.pictureBox2.Location = new System.Drawing.Point(72, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 45);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Enter ID";
            // 
            // Delete_BT
            // 
            this.Delete_BT.BackColor = System.Drawing.Color.Transparent;
            this.Delete_BT.Image = ((System.Drawing.Image)(resources.GetObject("Delete_BT.Image")));
            this.Delete_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("Delete_BT.ImageHover")));
            this.Delete_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Delete_BT.ImageNormal")));
            this.Delete_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("Delete_BT.InitialImage")));
            this.Delete_BT.Location = new System.Drawing.Point(419, 297);
            this.Delete_BT.Name = "Delete_BT";
            this.Delete_BT.Size = new System.Drawing.Size(174, 65);
            this.Delete_BT.TabIndex = 36;
            this.Delete_BT.TabStop = false;
            this.Delete_BT.Click += new System.EventHandler(this.Delete_BT_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 358);
            this.Controls.Add(this.Delete_BT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID_txt);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.Text = "Delete";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Delete_FormClosed);
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delete_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox ID_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private CustomImageButton.ImageButtonCustom Delete_BT;
    }
}
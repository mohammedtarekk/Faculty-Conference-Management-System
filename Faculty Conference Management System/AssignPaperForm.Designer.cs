namespace Faculty_Conference_Management_System
{
    partial class AssignPaperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignPaperForm));
            this.PapersGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedPaper_txt = new System.Windows.Forms.TextBox();
            this.textBoxPIC = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Assign_BT = new CustomImageButton.ImageButtonCustom();
            ((System.ComponentModel.ISupportInitialize)(this.PapersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assign_BT)).BeginInit();
            this.SuspendLayout();
            // 
            // PapersGrid
            // 
            this.PapersGrid.AllowUserToAddRows = false;
            this.PapersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.PapersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PapersGrid.Location = new System.Drawing.Point(12, 52);
            this.PapersGrid.Name = "PapersGrid";
            this.PapersGrid.ReadOnly = true;
            this.PapersGrid.Size = new System.Drawing.Size(369, 289);
            this.PapersGrid.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 33);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(464, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 33);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(396, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(369, 289);
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(777, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Selected Paper ID";
            // 
            // SelectedPaper_txt
            // 
            this.SelectedPaper_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.SelectedPaper_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SelectedPaper_txt.Enabled = false;
            this.SelectedPaper_txt.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.SelectedPaper_txt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.SelectedPaper_txt.Location = new System.Drawing.Point(790, 125);
            this.SelectedPaper_txt.Name = "SelectedPaper_txt";
            this.SelectedPaper_txt.ReadOnly = true;
            this.SelectedPaper_txt.Size = new System.Drawing.Size(163, 14);
            this.SelectedPaper_txt.TabIndex = 27;
            this.SelectedPaper_txt.Text = "SELECT PAPER FROM GRID";
            // 
            // textBoxPIC
            // 
            this.textBoxPIC.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPIC.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.textBoxPIC.Location = new System.Drawing.Point(771, 111);
            this.textBoxPIC.Name = "textBoxPIC";
            this.textBoxPIC.Size = new System.Drawing.Size(194, 45);
            this.textBoxPIC.TabIndex = 28;
            this.textBoxPIC.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox1.Location = new System.Drawing.Point(790, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 14);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "SELECT REVIEWER FROM GRID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Faculty_Conference_Management_System.Properties.Resources.textBox_;
            this.pictureBox3.Location = new System.Drawing.Point(771, 178);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 45);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(778, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Selected Reviewer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(365, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 14);
            this.label2.TabIndex = 25;
            this.label2.Text = "ALL COPYRIGHTS RESERVED TO TEAM ABO NESMA @2020";
            // 
            // Assign_BT
            // 
            this.Assign_BT.BackColor = System.Drawing.Color.Transparent;
            this.Assign_BT.Image = ((System.Drawing.Image)(resources.GetObject("Assign_BT.Image")));
            this.Assign_BT.ImageHover = ((System.Drawing.Image)(resources.GetObject("Assign_BT.ImageHover")));
            this.Assign_BT.ImageNormal = ((System.Drawing.Image)(resources.GetObject("Assign_BT.ImageNormal")));
            this.Assign_BT.InitialImage = ((System.Drawing.Image)(resources.GetObject("Assign_BT.InitialImage")));
            this.Assign_BT.Location = new System.Drawing.Point(785, 287);
            this.Assign_BT.Name = "Assign_BT";
            this.Assign_BT.Size = new System.Drawing.Size(174, 65);
            this.Assign_BT.TabIndex = 32;
            this.Assign_BT.TabStop = false;
            this.Assign_BT.Click += new System.EventHandler(this.Assign_BT_Click);
            // 
            // AssignPaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(977, 374);
            this.Controls.Add(this.Assign_BT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectedPaper_txt);
            this.Controls.Add(this.textBoxPIC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PapersGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AssignPaperForm";
            this.Text = "Assign paper to reviewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AssignPaperForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PapersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Assign_BT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PapersGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectedPaper_txt;
        private System.Windows.Forms.PictureBox textBoxPIC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private CustomImageButton.ImageButtonCustom Assign_BT;
        private System.Windows.Forms.Label label2;
    }
}
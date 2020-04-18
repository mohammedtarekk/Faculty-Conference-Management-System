﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faculty_Conference_Management_System
{
    public partial class UpdateForm : Form
    {
        string text;
        bool Bold = false;
        bool Italic = false;
        bool Underline = false;

        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void Title_textBox_TextChanged(object sender, EventArgs e)
        {
            Title_textBox.ForeColor = Color.Silver;
        }

        private void content_textBox_TextChanged(object sender, EventArgs e)
        {
            content_textBox.ForeColor = Color.Silver;

        }

        private void content_textBox_MouseClick(object sender, MouseEventArgs e)
        {
            content_textBox.ForeColor = Color.Silver;

        }

        int b = 0;
        private void Bold_BT_Click(object sender, EventArgs e)
        {
            if (b % 2 == 0)
            {
                Bold = true;
                content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold);

                if (Italic)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Italic);
                else if (Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Underline);
                else if (Italic && Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                Bold_BT.ImageNormal = BoldTemp.ImageHover;
                Bold_BT.ImageHover = BoldTemp.ImageHover;

            }
            else
            {
                Bold = false;

                content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Regular);

                if (Italic)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Italic);
                else if (Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Underline);
                else if (Italic && Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Underline | FontStyle.Italic);

                Bold_BT.ImageNormal = BoldTemp.ImageNormal;
            }

            b++;
        }

        int i = 0;
        private void Italic_BT_Click(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                Italic = true;

                content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Italic);

                if (Bold)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Italic);
                else if (Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Italic | FontStyle.Underline);
                else if (Bold && Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                Italic_BT.ImageNormal = ItalicTemp.ImageHover;
                Italic_BT.ImageHover = ItalicTemp.ImageHover;
            }
            else
            {
                Italic = false;
                content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Regular);

                if (Bold)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold);
                else if (Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Underline);
                else if (Bold && Underline)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Underline);

                Italic_BT.ImageNormal = ItalicTemp.ImageNormal;
            }

            i++;
        }

        int u = 0;
        private void Underline_BT_Click(object sender, EventArgs e)
        {
            if (u % 2 == 0)
            {
                Underline = true;
                content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Underline);

                if (Bold)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Underline);
                else if (Italic)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Underline | FontStyle.Italic);
                else if (Bold && Italic)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                Underline_BT.ImageNormal = UnderlineTemp.ImageHover;
                Underline_BT.ImageHover = UnderlineTemp.ImageHover;

            }
            else
            {
                Underline = false;
                content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Regular);

                if (Bold)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold);
                else if (Italic)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Italic);
                else if (Bold && Italic)
                    content_textBox.SelectionFont = new Font(content_textBox.Font, FontStyle.Bold | FontStyle.Italic);

                Underline_BT.ImageNormal = UnderlineTemp.ImageNormal;
            }

            u++;
        }

        private void ClearText_BT_Click(object sender, EventArgs e)
        {
            text = content_textBox.Text;
            content_textBox.Clear();
        }

        private void Undo_BT_Click(object sender, EventArgs e)
        {
            content_textBox.Text = text;
        }
        private void Categories_combo_Click(object sender, EventArgs e)
        {

        }
    }
}
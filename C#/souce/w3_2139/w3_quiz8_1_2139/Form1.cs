using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w3_quiz8_1_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.TextAlign = ContentAlignment.MiddleRight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                // | 연산자는 현재 스타일에서 폰트 스타일 추가
                Font font = new Font(label4.Font, label4.Font.Style | FontStyle.Bold);
                label4.Font = font;
            }
            else
            {
                // ^(XOR) 연산자는 현재 스타일에서 폰트 스타일 제거
                Font font = new Font(label4.Font, label4.Font.Style ^ FontStyle.Bold);
                label4.Font = font;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Font font = new Font(label4.Font, label4.Font.Style | FontStyle.Underline);
                label4.Font = font;
            }
            else
            {
                Font font = new Font(label4.Font, label4.Font.Style ^ FontStyle.Underline);
                label4.Font = font;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Font font = new Font(label4.Font, label4.Font.Style | FontStyle.Italic);
                label4.Font = font;
            }
            else
            {
                Font font = new Font(label4.Font, label4.Font.Style ^ FontStyle.Italic);
                label4.Font = font;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Font font = new Font(label4.Font, label4.Font.Style | FontStyle.Strikeout);
                label4.Font = font;
            }
            else
            {
                Font font = new Font(label4.Font, label4.Font.Style ^ FontStyle.Strikeout);
                label4.Font = font;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Font font = new Font(label4.Font.FontFamily, 12, label4.Font.Style);
            label4.Font = font;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Font font = new Font(label4.Font.FontFamily, 14, label4.Font.Style);
            label4.Font = font;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Font font = new Font(label4.Font.FontFamily, 18, label4.Font.Style);
            label4.Font = font;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz10_draw_2139
{
    public partial class Form1 : Form
    {
        Color linecolor = Color.Black;
        int linewidth = 1;
        int shapestyle = 0;
        Point start;

        Boolean button_flag = false;
        Boolean eraser_flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void mnu_line_Click(object sender, EventArgs e)
        {
            shapestyle = 1;
        }

        private void mnu_rec_Click(object sender, EventArgs e)
        {
            shapestyle = 2;
        }

        private void mnu_freepen_Click(object sender, EventArgs e)
        {
            shapestyle = 3;
        }

        private void mnu_red_Click(object sender, EventArgs e)
        {
            linecolor = Color.Red;
        }

        private void mnu_yellow_Click(object sender, EventArgs e)
        {
            linecolor = Color.Yellow;
        }

        private void mnu_blue_Click(object sender, EventArgs e)
        {
            linecolor = Color.Blue;
        }

        private void mnu_allclear_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(System.Drawing.SystemColors.Control);
        }

        private void mnu_eraser_Click(object sender, EventArgs e)
        {
            eraser_flag = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '1' && e.KeyChar <= '9')
                linewidth = (int)e.KeyChar - '0';
            else
                MessageBox.Show("입력된 값이 범위를 벗어남!");
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new Point(e.X, e.Y);
            if ((shapestyle == 1 || shapestyle == 2) && MouseButtons.Left == e.Button)
                button_flag = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int width, height;
            Graphics g = CreateGraphics();
            width = Math.Abs(start.X - e.X);
            height = Math.Abs(start.Y - e.Y);
            Pen p = new Pen(linecolor, linewidth);

            if (start.X > e.X)
                start.X = e.X;
            if (start.Y > e.Y)
                start.Y = e.Y;
            if (button_flag == true)
            {
                switch (shapestyle)
                {
                    case 1:
                        g.DrawLine(p, start.X, start.Y, e.X, e.Y); break;
                    case 2:
                        g.DrawRectangle(p, start.X, start.Y, width, height); break;
                }
            }
            button_flag = false;
            eraser_flag = false;
            shapestyle = 3;

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = CreateGraphics();
            Rectangle r = new Rectangle(e.X - 1, e.Y - 1, 1, 1);

            if (shapestyle == 3 && MouseButtons.Left == e.Button)
            {
                Pen p = new Pen(linecolor, linewidth);
                g.DrawRectangle(p, r);
                label2.Text = e.X.ToString();
                label3.Text = e.Y.ToString();
            }
            if (eraser_flag == true && MouseButtons.Left == e.Button)
            {
                Pen p = new Pen(System.Drawing.SystemColors.Control, linewidth);
                g.DrawRectangle(p, r);
                label2.Text = e.X.ToString();
                label3.Text = e.Y.ToString();
            }
        }
    }
}

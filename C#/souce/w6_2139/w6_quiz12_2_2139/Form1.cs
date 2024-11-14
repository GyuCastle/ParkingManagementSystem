using System;
using System.Drawing;
using System.Windows.Forms;

namespace w6_quiz12_2_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Pen p = new Pen(Color.Black);
                Point startPoint = new Point(45, 45);
                Point endPoint = new Point(180, 150);
                g.DrawLine(p, startPoint, endPoint);
                g.DrawLine(p, new Point(190, 60), new Point(65, 170));
                p.Dispose();
            }
            if (radioButton2.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);

                Point[] pts = {new Point(40, 40), new Point(180, 40),
                new Point(180, 180), new Point(40, 180),
                new Point(40, 60), new Point(160, 60),
                new Point(160, 160), new Point(60, 160),
                new Point(60, 80), new Point(140, 80),
                new Point(140, 140), new Point(80, 140),
                new Point(80, 100), new Point(120, 100),
                new Point(120, 120), new Point(100, 120)
                };
                g.DrawLines(new Pen(Color.BlueViolet), pts);
            }
            if (radioButton3.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Rectangle r = new Rectangle(50, 50, 150, 100);
                g.FillRectangle(Brushes.Lime, r);
                g.DrawRectangle(new Pen(Color.Black), r);
            }
            if (radioButton4.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Rectangle r = new Rectangle(50, 50, 150, 100);
                g.FillRectangle(Brushes.Lime, r);
                g.DrawRectangle(new Pen(Color.Black), r);
            }
            if (radioButton5.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Rectangle[] rects = {
                new Rectangle(40, 40, 40, 100),
                new Rectangle(100, 40, 100, 40),
                new Rectangle(100, 100, 100, 40)
};
                g.FillRectangles(Brushes.Blue, rects);
                g.DrawRectangles(Pens.Red, rects);
            }
            if (radioButton6.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Rectangle r = new Rectangle(50, 50, 150, 100);
                g.FillEllipse(Brushes.Cyan, r);
                g.DrawEllipse(Pens.Black, r);
            }
            if (radioButton7.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Rectangle r = new Rectangle(50, 50, 150, 100);
                g.DrawArc(Pens.Red, r, 45, 270);
            }
            if (radioButton8.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Rectangle r = new Rectangle(50, 50, 150, 100);
                g.FillPie(Brushes.LightGreen, r, 45, 270);
                g.DrawPie(Pens.DarkGreen, r, 45, 270);
            }
            if (radioButton9.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Point[] pts = {
                new Point(110, 40), new Point(125, 91),
                new Point(180, 91), new Point(135, 123),
                new Point(152, 172), new Point(110, 141),
                new Point(66, 172), new Point(82, 122),
                new Point(40, 91), new Point(95, 91)
};
                g.FillPolygon(Brushes.Pink, pts);
                g.DrawPolygon(Pens.Purple, pts);
            }
            if (radioButton10.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Point[] pts = {
                new Point(40, 100), new Point(50, 60),
                new Point(60, 50), new Point(70, 60),
                new Point(80, 100), new Point(90, 140),
                new Point(100, 150), new Point(110, 140),
                new Point(120, 100), new Point(130, 60),
                new Point(140, 50), new Point(150, 60),
                new Point(160, 100), new Point(170, 140),
                new Point(180, 150), new Point(190, 140),
                new Point(200, 100)
};
                g.DrawCurve(Pens.Red, pts);
            }
            if (radioButton11.Checked == true)
            {
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                Point[] pts = {
                new Point(115, 30), new Point(140, 90),
                new Point(200, 115), new Point(140, 140),
                new Point(115, 200), new Point(90, 140),
                new Point(30, 115), new Point(90, 90)
};
                g.FillClosedCurve(Brushes.Yellow, pts);
                g.DrawClosedCurve(Pens.Red, pts);
            }
            if (radioButton12.Checked == true)
            {
                Image img = new Bitmap("naver.gif"); // 프로젝트폴더/bin/debug
                Graphics g = CreateGraphics();
                g.Clear(SystemColors.Control);
                g.DrawImage(img, ClientRectangle);
            }
        }
    }
}

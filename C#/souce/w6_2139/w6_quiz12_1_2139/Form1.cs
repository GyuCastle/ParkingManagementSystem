using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w6_quiz12_1_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Random r = new Random();
            Color c = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            Point p = new Point(10, 20);
            Size s = new Size(80, 40);
            Rectangle rect = new Rectangle(p, s);
            Pen pe = new Pen(Color.Red);
            pe.Width = 10;
            g.DrawEllipse(pe, rect);
            //g.DrawEllipse(pe, , );
            g.FillEllipse(new SolidBrush(c), rect);
            Rectangle rect1 = new Rectangle(100, 20, 80, 40);
            g.FillRectangle(new SolidBrush(c), rect1);
        }
    }
}

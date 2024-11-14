using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace quiz10_me1_2139
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics G = this.CreateGraphics();
            G.DrawString("MouseClick", Font, Brushes.Black, e.X, e.Y);
            G.Dispose();
        }

        private void Form1_DoubleClick(object sender, MouseEventArgs e)
        {
            Graphics G = this.CreateGraphics();
            G.DrawString("MouseDoubleClick", Font, Brushes.Black, e.X, e.Y);
            G.Dispose();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            count++;
            Text = count.ToString();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics G = this.CreateGraphics();
            G.DrawString("MouseDown", Font, Brushes.Black, e.X, e.Y);
            G.Dispose();
        }
    }
}

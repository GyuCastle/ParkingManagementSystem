using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex10_1_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새파일NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(새파일NToolStripMenuItem.Text);
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(열기OToolStripMenuItem.Text);
        }

        private void 닫기CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(닫기CToolStripMenuItem.Text);
        }




        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(저장SToolStripMenuItem.Text);
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(다른이름으로저장AToolStripMenuItem.Text);
        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(인쇄PToolStripMenuItem.Text);
        }

        private void 미리보기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(미리보기VToolStripMenuItem.Text);
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(종료XToolStripMenuItem.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multyform2_2139
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 Parent = (Form1)Owner;
            textBox1.Text = Parent.label1.Left.ToString();
            textBox2.Text = Parent.label1.Top.ToString();
            textBox3.Text = Parent.label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 Parent = (Form1)Owner;
            Parent.label1.Left = Convert.ToInt32(textBox1.Text);
            Parent.label1.Top = Convert.ToInt32(textBox2.Text);
            Parent.label1.Text = textBox3.Text;
        }
    }
}

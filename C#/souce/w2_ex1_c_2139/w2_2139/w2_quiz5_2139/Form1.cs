using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w2_quiz5_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddNumbers(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            double result = n1 + n2;
            textBox3.Text = result.ToString();
        }
        private void SubtractNumbers(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            double result =  n1 - n2;
            textBox3.Text = result.ToString();
        }

        private void MultiplyNumbers(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            double result = n1 * n2;
            textBox3.Text = result.ToString();
        }
        private void DivideNumbers(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            if (n2 == 0)
            {
                MessageBox.Show("0으로 나눌 수 없습니다.");
            }
            else
            {
                double result = n1 / n2;
                textBox3.Text = result.ToString();
            }
        }
        private void ModulusNumbers(string num1, string num2)
        {
            double n1 = double.Parse(num1);
            double n2 = double.Parse(num2);
            if (n2 == 0)
            {
                MessageBox.Show("0으로 나눌 수 없습니다.");
            }
            else
            {
                double result = n1 % n2;
                textBox3.Text = result.ToString();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddNumbers(textBox1.Text, textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SubtractNumbers(textBox1.Text, textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MultiplyNumbers(textBox1.Text, textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DivideNumbers(textBox1.Text, textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModulusNumbers(textBox1.Text, textBox2.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

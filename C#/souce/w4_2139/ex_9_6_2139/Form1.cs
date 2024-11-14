using System;
using System.Windows.Forms;

namespace ex_9_6_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("MessageBoxDefaultButton", "Title Bar", 
            MessageBoxButtons.YesNoCancel, 
            MessageBoxIcon.Question, 
            MessageBoxDefaultButton.Button2);

            DialogResult ans = MessageBox.Show("버튼선택", "제목", MessageBoxButtons.YesNo); // DialogResult 객체 중요
            if (ans == DialogResult.Yes)
                label1.Text = "yes";
            else
                label1.Text = "no";
        }

        private void button1_Click(object sender, EventArgs e) // 9_7 예제임 시험 x
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트파일(*.txt)|*.txt|모든파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
        }
    }
}
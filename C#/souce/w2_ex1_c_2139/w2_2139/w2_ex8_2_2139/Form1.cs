using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w2_ex8_2_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }
        private string strTemp;
        private void UpdateLabel(string s, bool b)
        {
            if (b) { label1.Text += s; }
            else
            {
                strTemp = label1.Text;
                int i = strTemp.IndexOf(s); // 처음 위치 반환
                label1.Text = strTemp.Remove(i, s.Length); ; // 처음부터 길이까지 제거 된 텍스트 저장
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked); // Checked를 넣어 준 이유는 체크되면 true, 해제되면 false 반환
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox4.Text, checkBox4.Checked);
        }
    }
}

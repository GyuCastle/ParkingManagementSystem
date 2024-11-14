using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch9_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // 객체 생성과 선언
            form2.ShowDialog(); // form2를 모달 방식으로 띄운다.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // 객체 생성과 선언
            form3.Show(); // form3을 모달리스 방식으로 띄운다.
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multyform1_2139
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // 각 텍스트 박스의 값을 속성으로 설정
        public int LabelX
        {
            get { return Convert.ToInt32(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }
        public int LabelY
        {
            get { return Convert.ToInt32(textBox2.Text); }
            set { textBox2.Text = value.ToString(); }
        }
        public string LabelText
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

    }
}

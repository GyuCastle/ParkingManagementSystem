using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz10_ke1_2139
{
    public partial class Form1 : Form
    {
        private string str;
        public Form1()
        {
            InitializeComponent();
        }
        // 키 입력 시 화면에 키 입력되는 코드
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
             //str += e.KeyChar;
            if (e.ToString() == " ") // 스페이스바 입력 시
            {
                str = ""; // 변수의 문자만 초기화
            }
            else
            {
                str += e.KeyChar;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
        }
    }
}

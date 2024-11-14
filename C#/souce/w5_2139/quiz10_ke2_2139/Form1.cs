using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz10_ke2_2139
{
    public partial class Form1 : Form
    {
        private int x, y;
        public Form1()
        {
            InitializeComponent();
            x = 10; // 초기 원 위치 설정
            y = 10; // 초기 원 위치 설정
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) // KeyDown을 하면 KeyCode에 저장
        {
            switch (e.KeyCode) // 왼쪽을 누르면 Keys.Left를 반환함
            {
                case Keys.Left:
                    x -= 1;
                    break;
                case Keys.Right:
                    x += 1;
                    break;
                case Keys.Up:
                    y -= 1;
                    break;
                case Keys.Down:
                    y += 1;
                    break;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Black, x - 8, y - 8, 16, 16);
        }
    }
}

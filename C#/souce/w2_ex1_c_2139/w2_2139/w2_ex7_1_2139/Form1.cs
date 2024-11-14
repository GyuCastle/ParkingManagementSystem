using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // 폼 안에 버튼과 같은 컨트롤 들이 들어있음

namespace w2_ex7_1_2139
{
    public partial class Form1 : Form // 상속
    {
        public Form1() // 생성자
        {
            InitializeComponent();
            startDateTime = DateTime.Now; // 1. 구조체
        }
        DateTime startDateTime; // 2. 구조체
        public DateTime GetStartDateTime() // 3. 메서드
        {
            return startDateTime;
        }

        private void button1_Click(object sender, EventArgs e) // 4. 이벤트 처리기
        {
            MessageBox.Show(GetStartDateTime().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

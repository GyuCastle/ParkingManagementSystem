using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace quiz10_1_2139
{
    internal class Program : Form //2, 3번 정의 5번 자동 발생
    {
        public Program()
        {
            this.Text = "Program App";
            this.Click += new EventHandler(ClickEvent); // 4번 이벤트  등록
        }
        private void ClickEvent(object sender, EventArgs e) // 1
        {
            MessageBox.Show(" sender = " + sender.GetType());
        }

        static void Main(string[] args)
        {
            Application.Run(new Program());
        }
    }
}

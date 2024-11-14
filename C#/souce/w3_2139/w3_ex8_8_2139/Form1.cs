using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w3_ex8_8_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(listBox1.SelectedItem); // >> 버튼 클릭 시 콤보박스에서는 추가
                // comboBox1.Items.Insert(0, listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem); // >> 버튼 클릭 시 리스트 박스에서는 삭제
                // listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                listBox1.Items.Add(comboBox1.SelectedItem); // << 클릭 시 리스트상자 콤보박스에 추가
                comboBox1.Items.Remove(comboBox1.SelectedItem); // << 클릭 시 선택항목 삭제
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

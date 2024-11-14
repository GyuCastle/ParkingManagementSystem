using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w6_quiz11_1_2139
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                listView1.View = View.LargeIcon;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                listView1.View = View.SmallIcon;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                listView1.View = View.List;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                listView1.View = View.Details;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                listView1.View = View.Tile;
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
                // 각 항목에 대한 부항목을 얻기 위해 SubItems 프로퍼티를 사용
                label1.Text = subItem[0].Text + "의 국가번호는 " + subItem[1].Text + "입니다.";
            }
            label2.Text = listView1.Items[0].Text;
            label3.Text = listView1.Items[0].SubItems[0].Text;

            textBox1.Text = listView1.Items[0].SubItems[0].Text;
            textBox1.Text = listView1.Items[0].SubItems[1].Text;
        }

        private void button1_Click(object sender, EventArgs e) // 삭제 버튼
        {
            if (listView1.SelectedItems.Count <= 0) // SelectedItems.Count : 선택된 아이템
                MessageBox.Show("선택된 항목이 없음!");
            else
                while (listView1.SelectedItems.Count > 0)
                    listView1.Items.Remove(listView1.SelectedItems[0]); // 리스트뷰에서 선택된 첫번째 항목 제거
        }

        private void button2_Click(object sender, EventArgs e) // 추가 버튼
        {
            int count;
            ListViewItem lsvitem;
            if (listView1.Items.Count == 0) // listView1.Items.Count : 리스트 뷰 아이템의 개수(6)
                count = 0;
            else
                count = listView1.Items.Count; //6
            lsvitem = new ListViewItem(textBox1.Text, count); // 텍스트 설정, 인덱스 설정
            listView1.Items.Add(lsvitem); // ListViewItem 추가
            listView1.Items[count].SubItems.Add(textBox2.Text); // 서브아이템 추가(전화번호)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}

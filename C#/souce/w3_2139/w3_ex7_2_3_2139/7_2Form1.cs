using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w3_ex7_2_3_2139
{
    public partial class ex7_2 : Form
    {
        public ex7_2()
        {
            InitializeComponent();
        }

        private void ex7_2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This form is loaded");
        }

        private void ex7_2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("This form is closed");
        }

        private void ex7_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to close?", "Prompt", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

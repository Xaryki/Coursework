using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_14 : Form
    {
        public question_14()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = hScrollBar1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(14, class8.Question_number_14(hScrollBar1));
        }

        private void question_14_Load(object sender, EventArgs e)
        {

        }
    }
}

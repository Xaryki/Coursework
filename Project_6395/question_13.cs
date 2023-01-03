using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_13 : Form
    {
        public question_13()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void question_13_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(13, class8.Question_number_13(hScrollBar1));
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = hScrollBar1.Value.ToString();
        }
    }
}

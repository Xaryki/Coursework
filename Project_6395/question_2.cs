using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_2 : Form
    {
        public question_2()
        {
            InitializeComponent();
        }

        private void question_2_Load(object sender, EventArgs e)
        {

        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(2, class8.Question_number_2(checkBox1, checkBox2, checkBox3, checkBox4));
        }
    }
}

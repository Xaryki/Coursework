using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_3 : Form
    {
        public question_3()
        {
            InitializeComponent();

        }

        private void question_3_Load(object sender, EventArgs e)
        {

        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(3, class8.Question_number_3(textBox1));
        }
    }
}

using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_4 : Form
    {
        public question_4()
        {
            InitializeComponent();
        }

        private void question_4_Load(object sender, EventArgs e)
        {
           
        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(4, class8.Question_number_4(textBox1));
        }
    }
}

using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_16 : Form
    {
        public question_16()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {

            f.change_color(16, class8.Question_number_16(checkedListBox1));
        }

        private void question_16_Load(object sender, EventArgs e)
        {

        }
    }
}

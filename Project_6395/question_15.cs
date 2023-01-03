using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_15 : Form
    {
        public question_15()
        {
            InitializeComponent();
        }

        private void question_15_Load(object sender, EventArgs e)
        {

        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(15, class8.Question_number_15(checkedListBox1));
        }
    }
}

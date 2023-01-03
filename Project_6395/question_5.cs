using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_5 : Form
    {
        public question_5()
        {
            InitializeComponent();
        }

        private void question_5_Load(object sender, EventArgs e)
        {

        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(5, class8.Question_number_5(radioButton1, radioButton2, radioButton3, radioButton4));
        }
    }
}

using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_6 : Form
    {
        public question_6()
        {
            InitializeComponent();
        }

        private void question_6_Load(object sender, EventArgs e)
        {
            
        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(6, class8.Question_number_6(radioButton1, radioButton2, radioButton3, radioButton4));
        }
    }
}

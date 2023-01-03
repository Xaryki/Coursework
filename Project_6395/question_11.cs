using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_11 : Form
    {
        public question_11()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void question_11_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(11, class8.Question_number_11(trackBar1));
        }
    }
}

using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_12 : Form
    {
        public question_12()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void question_12_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(12, class8.Question_number_12(trackBar1));
        }
    }
}

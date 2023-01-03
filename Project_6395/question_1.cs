using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_1 : Form
    {
        public question_1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void question_1_Load(object sender, EventArgs e)
        {

        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            
            f.change_color(1, class8.Question_number_1(checkBox1, checkBox2, checkBox3, checkBox4));
        }
        
        
    }
}

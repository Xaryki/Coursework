using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_10 : Form
    {
        public question_10()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void question_10_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(10, class8.Question_number_10(comboBox1, comboBox2, comboBox3, comboBox4));
        
        }
    }
}

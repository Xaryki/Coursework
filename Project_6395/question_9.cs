using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_9 : Form
    {
        public question_9()
        {
            InitializeComponent();
        }
        public Form_test_1 f;
        private void question_9_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(9, class8.Question_number_9(comboBox1,comboBox2,comboBox3,comboBox4));
        }


        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

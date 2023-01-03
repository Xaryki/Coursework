using System;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class question_8 : Form
    {
        public question_8()
        {
            InitializeComponent();
        }

        private void question_8_Load(object sender, EventArgs e)
        {
            listBox1.SelectedItem = listBox1.Items[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = listBox1.SelectedItem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Text = listBox1.SelectedItem.ToString();
        }
        public Form_test_1 f;
        private void button2_Click(object sender, EventArgs e)
        {
            f.change_color(8, class8.Question_number_8(listBox1, textBox1, textBox2, textBox3, textBox4));
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
namespace Project_6395
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            textBox1.Text = "Введите имя";
            textBox2.Text = "Введите пароль";
            textBox1.ForeColor = Color.Green;
            textBox2.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Form_test_1();
            DB.authorization(f,panel1, textBox1, textBox2);
            
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите имя")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Green;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите имя";
                textBox1.ForeColor = Color.Green;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите пароль";
                textBox2.ForeColor = Color.Green;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите пароль")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Green;
            }
        }
    }
}

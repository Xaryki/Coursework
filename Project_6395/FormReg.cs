using System;
using System.Drawing;
using System.Windows.Forms;
namespace Project_6395
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
            textBox1.Text = "Введите имя";
            textBox2.Text = "Введите пароль";
            textBox4.Text = "Повторно введите пароль";
            textBox1.ForeColor = Color.Green;
            textBox2.ForeColor = Color.Green;
            textBox4.ForeColor = Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == textBox4.Text)
            {
                DB.registration(textBox1.Text, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Регистрация",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Введите пароль")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Green;
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

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Повторно введите пароль")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Green;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Повторно введите пароль";
                textBox4.ForeColor = Color.Green;
            }
        }
    }
}

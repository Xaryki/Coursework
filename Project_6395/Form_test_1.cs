using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project_6395
{
    public partial class Form_test_1 : Form
    {
        //Fields
        private Form activeForm;
        public Form_test_1()
        {
            InitializeComponent();
        }
       
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_1() { f = this}, sender);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_2() { f = this }, sender);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_3() { f = this }, sender);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_4() { f = this }, sender);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_5() { f = this }, sender);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_6() { f = this }, sender);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_7() { f = this }, sender);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_8() { f = this }, sender);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_9() { f = this }, sender);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_10() { f = this }, sender);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_11() { f = this }, sender);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_12() { f = this }, sender);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_13() { f = this }, sender);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_14() { f = this }, sender);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_15() { f = this }, sender);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new question_16() { f = this }, sender);
        }

        private void Form_test_1_Load(object sender, EventArgs e)
        {
           
        }
        public void change_color(int n,int flag)
        {
            if (flag == 0)
            {
                menuStrip1.Items[n-1].BackColor = Color.Red;
                menuStrip1.Items[n - 1].Enabled = false;
            }
            else if (flag == 1)
            {
                menuStrip1.Items[n-1].BackColor = Color.Green;
                menuStrip1.Items[n - 1].Enabled = false;
            }
            else
            {
                menuStrip1.Items[n - 1].BackColor = Color.White;
            }
        }
        public Color current_color(int n)
        {
            return menuStrip1.Items[n - 1].BackColor;
        }
        private void завершитьТестированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите завершить тестирование?","Тестирование", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                menuStrip1.Enabled = false;
                OpenChildForm(new conclusion() { f = this }, sender);
            }
                
        }
    }
}

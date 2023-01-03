using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class conclusion : Form
    {
        public conclusion()
        {
            InitializeComponent();
        }
        public Form_test_1 f;

        public string[] array = new string[17];
        public int summa = 0;
        private void conclusion_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 17; i++)
            {
                Color clr = f.current_color(i);
                if (clr == Color.Green)
                {
                    summa++;
                    array[i] = "Верно";
                }
                else
                {
                    array[i] = "Неверно";
                }
            }
            this.chart1.Series[0].Points.AddXY(1, summa);
            this.chart1.Series[1].Points.AddXY(1, 16 - summa);
            label3.Text = Convert.ToString(summa);
            label5.Text = Convert.ToString(16-summa);
            class8.output_mas(ref dataGridView1, array);
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            class9.Vivod_Excel(array, summa);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            class9.ZapisWord(array, summa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            class9.DeestructBD();
            class9.CreateStructBD();
            class9.AddToBD(array);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            class9.Add_pdf(array, summa);
        }
    }
}

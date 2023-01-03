using System.Windows.Forms;

namespace Project_6395
{
    public class class8
    {
        //Вывод массива в ДГВ
        public static void output_mas(ref DataGridView dgv, params string[] a)
        {
            dgv.RowCount = 2;
            dgv.ColumnCount = a.GetLength(0);
            for (int i = 1; i < a.GetLength(0); i++)
            {
                dgv.Rows[0].Cells[i].Value = "[" + i + "]";
                dgv.Rows[1].Cells[i].Value = a[i];
            }
        }
        
        
        public Form_test_1 f;
        // Код к первому вопросу
        public static int Question_number_1(CheckBox checkBox1, CheckBox checkBox2, CheckBox checkBox3, CheckBox checkBox4)
        {
            if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked && !checkBox4.Checked)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                return 1;
                //f.change_color(1, 1);
            }
            else if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                return 0;
                //f.change_color(1, 0);

                
            }
        }
        // Код ко второму вопросу
        public static int Question_number_2(CheckBox checkBox1, CheckBox checkBox2, CheckBox checkBox3, CheckBox checkBox4)
        {
            if (checkBox1.Checked && checkBox4.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                return 1;
            }
            else if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked))
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                return 0;
            }
        }
        // Код к третьему вопросу
        public static int Question_number_3(TextBox textBox1)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (textBox1.Text.ToLower() == "togaf")
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
                return 0;
            }
        }
        // Код к четвертому вопросу
        public static int Question_number_4(TextBox textBox1)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (textBox1.Text.ToLower() == "fea")
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Enabled = false;
                return 0;
            }
        }
        // Код к пятому вопросу
        public static int Question_number_5(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
        {
            if (radioButton2.Checked)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                return 1;
            }
            else if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                return 0;
            }
        }
        // Код к шестому вопросу
        public static int Question_number_6(RadioButton radioButton1, RadioButton radioButton2, RadioButton radioButton3, RadioButton radioButton4)
        {
            if (radioButton4.Checked)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                return 1;
            }
            else if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked))
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                return 0;
            }
        }
        // Код к седьмому вопросу
        public static int Question_number_7(ListBox listBox1, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            if (textBox1.Text == "BRM" && textBox2.Text == "CRM" && textBox3.Text == "TRM" && textBox4.Text == "DRM")
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Enabled = false;
                return 1;
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Enabled = false;
                return 0;
            }
        }
        // Код к восьмому вопросу
        public static int Question_number_8(ListBox listBox1, TextBox textBox1, TextBox textBox2, TextBox textBox3, TextBox textBox4)
        {
            if (textBox1.Text == "Управление инцидентами" && textBox2.Text == "Управление изменениями" && textBox3.Text == "Управление релизами" && textBox4.Text == "Управление доступностью")
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Enabled = false;
                return 1;
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Enabled = false;
                return 0;
            }
        }
        // Код к девятому вопросу
        public static int Question_number_9(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4)
        {
            if (comboBox1.Text == "Анализ Кепнера и Трего" && comboBox2.Text == "Мозговой штурм" && comboBox4.Text == "Диаграмма Ишикавы" && comboBox3.Text == "Анализ Парето")
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                return 1;
            }
            else if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox4.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                return 0;
            }
        }
        // Код к десятому вопросу
        public static int Question_number_10(ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3, ComboBox comboBox4)
        {
            if (comboBox1.Text == "Виртуализация" && comboBox2.Text == "Виртуальная машина" && comboBox4.Text == "Docker" && comboBox3.Text == "Гипервизор")
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                return 1;
            }
            else if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox4.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                return 0;
            }
        }
        // Код к одиннадцатому вопросу
        public static int Question_number_11(TrackBar trackBar1)
        {
            if (trackBar1.Value == 0)
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;

            }
            else if (trackBar1.Value == 3)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Enabled = false;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Enabled = false;
                return 0;
            }
        }
        // Код к двенадцатому вопросу
        public static int Question_number_12(TrackBar trackBar1)
        {
            if (trackBar1.Value == 0)
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;

            }
            else if (trackBar1.Value == 2)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Enabled = false;
                return 1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                trackBar1.Enabled = false;
                return 0;
            }
        }
        // Код к тринадцатому вопросу
        public static int Question_number_13(HScrollBar hScrollBar1)
        {
            if (hScrollBar1.Value <= 5 && hScrollBar1.Value != 0)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hScrollBar1.Enabled = false;
                return 1;
            }
            else if (hScrollBar1.Value.ToString() == "0")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hScrollBar1.Enabled = false;
                return 0;
            }
        }
        // Код к четырнадцатому вопросу
        public static int Question_number_14(HScrollBar hScrollBar1)
        {
            if (hScrollBar1.Value == 1)
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hScrollBar1.Enabled = false;
                return 1;
            }
            else if (hScrollBar1.Value.ToString() == "0")
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hScrollBar1.Enabled = false;
                return 0;
            }
        }
        // Код к пятнадцатому вопросу
        public static int Question_number_15(CheckedListBox checkedListBox1)
        {
            if (!checkedListBox1.GetItemChecked(0) && !checkedListBox1.GetItemChecked(1) && !checkedListBox1.GetItemChecked(2) && !checkedListBox1.GetItemChecked(3) && !checkedListBox1.GetItemChecked(4) && !checkedListBox1.GetItemChecked(5) && !checkedListBox1.GetItemChecked(6) && checkedListBox1.GetItemChecked(7))
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Enabled = false;
                return 1;
            }
            else if (!checkedListBox1.GetItemChecked(0) && !checkedListBox1.GetItemChecked(1) && !checkedListBox1.GetItemChecked(2) && !checkedListBox1.GetItemChecked(3) && !checkedListBox1.GetItemChecked(4) && !checkedListBox1.GetItemChecked(5) && !checkedListBox1.GetItemChecked(6) && !checkedListBox1.GetItemChecked(7))
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Enabled = false;
                return 0;
            }
        }
        // Код к шестнадцатому вопросу
        public static int Question_number_16(CheckedListBox checkedListBox1)
        {
            if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(1) && checkedListBox1.GetItemChecked(2) && checkedListBox1.GetItemChecked(3))
            {
                MessageBox.Show("Вы ответили правильно !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Enabled = false;
                return 1;
            }
            else if (!checkedListBox1.GetItemChecked(0) && !checkedListBox1.GetItemChecked(1) && !checkedListBox1.GetItemChecked(2) && !checkedListBox1.GetItemChecked(3))
            {
                MessageBox.Show("Надо ответить на вопрос !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else
            {
                MessageBox.Show("Вы ответили неверно, переходим к следующему вопросу !", "Тест", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkedListBox1.Enabled = false;
                return 0;
            }
        }
    }
    
}

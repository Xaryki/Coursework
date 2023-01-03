using System.Windows.Forms;
using System.Data.OleDb;

namespace Project_6395
{
    class DB
    {
        public static OleDbConnection ConnectAccountDataBase()
        {
            string conString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=baza5.mdb";
            var myConnection = new OleDbConnection(conString);
            myConnection.Open();
            return myConnection;
        }
        //Авторизация
        public static void authorization(Form childForm, Panel panel, TextBox t, TextBox t2)
        {
            string query = $"SELECT COUNT(*) FROM [Table5] WHERE(login = '{t.Text}' AND pass = '{t2.Text}')";
            bool flag = false;
            try
            {
                using (OleDbConnection connection = ConnectAccountDataBase())
                {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    if ((int)command.ExecuteScalar() == 1)
                        flag = true;
                }
                MessageBox.Show("Вы успешно вошли!", "Информация",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Ошибка авторизации:\n" + exp.Message, "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (flag)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel.Controls.Add(childForm);
                panel.Tag = childForm;
                childForm.BringToFront();
                panel.Dock = DockStyle.Fill;
                childForm.Show();
            }
        }
        //Регистрация нового аккаунта
        public static void registration(string login, string pass)
        {
            var p = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=baza5.mdb");
            p.Open();
            var c = new OleDbCommand("INSERT INTO[Table5] ([login],[pass])" + $"VALUES('{login}','{pass}')");
            c.Connection = p;
            c.ExecuteNonQuery();
            p.Close();
            MessageBox.Show("Аккаунт успешно создан!", "Информация",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}



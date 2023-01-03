using System;
using System.Data.OleDb;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Project_6395
{
    public class class9
    {
        // Запись в Excel
        public static void Vivod_Excel(string[] arr, int g)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            workbook = excelApp.Workbooks.Add();
            worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
            worksheet.Name = "Результаты";
            worksheet.Cells[1, 1] = "Результаты тестирования";
            worksheet.Cells[2, 1] = "Ваш текущий результат: " + g + "/16";
            int length = arr.Length;
            for (int i = 1; i < length; i++)
            {
                worksheet.Cells[3, i + 1] = "[" + i + "]";
                worksheet.Cells[4, i + 1] = arr[i];
            }
            worksheet.Cells[3, 1] = "Номер вопроса: ";
            worksheet.Cells[4, 1] = "Ответ на вопрос: ";
            excelApp.Visible = true;
            excelApp.UserControl = true;
            MessageBox.Show("Данные успешно записаны в Excel!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Запись в блокнот
        public static void ZapisWord(string[] arr, int g)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            var Wrd = new Microsoft.Office.Interop.Word.Application();
            Wrd.Visible = true;
            var inf = Type.Missing;
            String str;
            var Doc = Wrd.Documents.Add(inf, inf, inf, inf);
            Wrd.Selection.TypeText("Результаты тестирования");
            Object t1 = Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior;
            Object t2 = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;
            int length = arr.Length;
            Wrd.Selection.TypeText('\n' + "Ваш текующий результат: " + g + "/16");
            Microsoft.Office.Interop.Word.Table tbl = Wrd.ActiveDocument.Tables.Add(Wrd.Selection.Range, 2, length, t1, t2);
            for (int i = 1; i < length; i++)
            {
                tbl.Cell(1, i).Range.InsertAfter("[" + Convert.ToString(i) + "]");
                str = String.Format("{0:f2}", arr[i]);
                tbl.Cell(2, i).Range.InsertAfter(str);
            }
            MessageBox.Show("Данные успешно записаны в Word!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Запись в PDF
        public static void Add_pdf(string[] arr, int g)
        {
            var Document = new Document();
            var Zap = PdfWriter.GetInstance(Document, new
            System.IO.FileStream("save_to_pdf.pdf", System.IO.FileMode.Create));
            Document.Open();
            var Shrift = BaseFont.CreateFont(@"C:\WINDOWS\Fonts\times.ttf",
            "CP1251", BaseFont.EMBEDDED);
            var ft = new Font(Shrift, 10, Font.NORMAL, BaseColor.BLUE);
            var tabl = new PdfPTable(1);
            var cell = new PdfPCell();
            cell.HorizontalAlignment = Element.ALIGN_LEFT;
            cell.Colspan = 2;
            cell.Border = 0;
            cell.FixedHeight = 16.0F;
            cell.BackgroundColor = BaseColor.LIGHT_GRAY;
            cell.Colspan = 1;
            cell.Border = 15;
            cell.Phrase = new Phrase("Results", ft);
            tabl.AddCell(cell);
            string temp = "Your current result is " + Convert.ToString(g) + "/16";
            cell.Phrase = new Phrase(temp, ft);
            tabl.AddCell(cell);

            for (int i = 0; i < arr.Length; i++)
            {
                string temp1 = Convert.ToString(i) + " " + Convert.ToString(arr[i]);
                cell.Phrase = new Phrase(temp1, ft);
                tabl.AddCell(cell);
            }
            tabl.TotalWidth = Document.PageSize.Width - 400;
            tabl.WriteSelectedRows(0, -1, 40, Document.PageSize.Height - 30,
            Zap.DirectContent);
            Document.Close();
            Zap.Close();
            MessageBox.Show("Данные успешно записаны в PDF!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Создание структуры базы данных
        public static void CreateStructBD()
        {
            var Connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= save_to_db.mdb");
            Connect.Open();
            String Col = "CREATE TABLE [Matrix] ([Question]counter,[Answer] char(20))";
            var Command = new OleDbCommand(Col, Connect);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (System.Runtime.InteropServices.COMException sit)
            {
                MessageBox.Show(sit.Message);
            }
            Connect.Close();
        }
        // Удаление базы данных
        public static void DeestructBD()
        {
            string connetionString = null;
            OleDbConnection connection;
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            string sql = null;
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= save_to_db.mdb";
            connection = new OleDbConnection(connetionString);
            sql = "drop table Matrix";
            try
            {
                connection.Open();
                oledbAdapter.DeleteCommand = connection.CreateCommand();
                oledbAdapter.DeleteCommand.CommandText = sql;
                oledbAdapter.DeleteCommand.ExecuteNonQuery();
                //MessageBox.Show("Row(s) Deleted !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static void CommBD(String commandString)
        {
            var Connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source= save_to_db.mdb");
            Connection.Open();
            var Command = new OleDbCommand("" + commandString);
            Command.Connection = Connection;
            Command.ExecuteNonQuery();
            Connection.Close();
        }
        // Заполнение базы данных
        public static void AddToBD(string[] arr)
        {
            string b = "";
            var p = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= save_to_db.mdb");
            for (int i = 1; i < 17; i++)
            {
                p.Open();
                var c = new OleDbCommand("INSERT INTO[Matrix] ([Question],[Answer])" + $"VALUES('{i}', '{arr[i]}')");
                c.Connection = p;
                c.ExecuteNonQuery();
                p.Close();
            }
            MessageBox.Show("Данные успешно записаны в базу данных!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

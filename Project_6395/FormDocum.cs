using System;
using System.IO;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class Документация : Form
    {
        public Документация()
        {
            InitializeComponent();
        }

        private void FormDocum_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(Directory.GetCurrentDirectory() + "/txt.mht");
            
        }
    }
}

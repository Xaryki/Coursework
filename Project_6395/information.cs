using System;
using System.IO;
using System.Windows.Forms;

namespace Project_6395
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void information_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(Directory.GetCurrentDirectory() + "/main.mht");
        }
    }
}

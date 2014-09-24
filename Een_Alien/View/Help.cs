using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Een_Alien.View
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            Console.WriteLine(Directory.GetCurrentDirectory() + "\\help.html");
            webBrowser1.Url = new Uri(Directory.GetCurrentDirectory() + "\\help.html");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

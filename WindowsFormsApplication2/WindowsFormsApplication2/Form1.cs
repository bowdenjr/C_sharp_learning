using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{ 


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //This stuff is useful with a browse... button using the executable path object (a text input box).
            string winpath = Environment.GetEnvironmentVariable("windir");
            string path = System.IO.Path.GetDirectoryName(
                              System.Windows.Forms.Application.ExecutablePath);
            */

            //Expand on this by 1. Check Chromium is install, 2. find install directory
            Process.Start("C:\\Users\\897333\\Documents\\2. FILES\\08_INSTALLS\\chrome-win32\\chrome-win32\\chrome.exe");
        }
    }
}

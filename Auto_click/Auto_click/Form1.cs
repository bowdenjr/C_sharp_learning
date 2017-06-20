using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_click
{
    public partial class Form1 : Form
    {
        bool blnClickOn = false;

        public Form1()
        {
            InitializeComponent();
            onbutton.BackColor = Color.Green;
            offbutton.BackColor = Color.Gray;
            offbutton.Enabled = false;
        }

        async public void clicker()
        {
            while (blnClickOn == true)
            {
                await Task.Delay(60000); // Delay one minute
                Application.DoEvents();
                SendKeys.Send("^");
            }
        }

        private void onbutton_Click(object sender, EventArgs e)
        {
            blnClickOn = true;
            offbutton.Enabled = true;
            onbutton.BackColor = Color.Gray;
            offbutton.BackColor = Color.DarkRed;
            onbutton.Enabled = false;
            clicker();
        }

        private void offbutton_Click(object sender, EventArgs e)
        {
            blnClickOn = false;
            onbutton.Enabled = true;
            onbutton.BackColor = Color.Green;
            offbutton.BackColor = Color.Gray;
            offbutton.Enabled = false;
        }

    }
}

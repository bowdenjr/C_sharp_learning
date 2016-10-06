﻿using System;
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
            statusbox.BackColor = Color.Red;
            statusbox.Text = "OFF";
        }


        async public void clicker()
        {
            while (blnClickOn == true)
            {
                await Task.Delay(2000);
                Application.DoEvents();
                SendKeys.Send("^");

            }
        }

        private void onbutton_Click(object sender, EventArgs e)
        {
            blnClickOn = true;
            statusbox.BackColor = Color.Green;
            statusbox.Text = "ON";
            clicker();

        }

        private void offbutton_Click(object sender, EventArgs e)
        {
            blnClickOn = false;
            statusbox.BackColor = Color.Red;
            statusbox.Text = "OFF";


        }

    }
}

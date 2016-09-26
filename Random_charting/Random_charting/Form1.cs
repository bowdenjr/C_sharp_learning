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
using System.Windows.Forms.DataVisualization.Charting;

namespace Random_charting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();  

            List<double> yvals1 = new List<double>();
            
            for(int i = 0; i < 500; i++)
            {

                yvals1.Add(rdn.NextDouble());

            }

            List<double> yvals2 = new List<double>();

            for (int i = 0; i < 500; i++)
            {

                yvals2.Add(rdn.NextDouble());

            }

            chart2.Series["test1"].Points.Clear();
            chart2.Series["test2"].Points.Clear();
            

            for (int i = 0; i < 500; i++)
            {
               chart2.Series["test1"].Points.AddXY
                                (i, yvals1[i]);
               chart2.Series["test2"].Points.AddXY
                                (i, yvals2[i]);
            }

            test1box.Text = Convert.ToString(Math.Round(yvals1.Average(),4));
            test2box.Text = Convert.ToString(Math.Round(yvals2.Average(),4));


            chart2.Series["test1"].ChartType = SeriesChartType.FastLine;
            chart2.Series["test1"].Color = Color.Red;

            chart2.Series["test2"].ChartType = SeriesChartType.FastLine; 
            chart2.Series["test2"].Color = Color.Blue;

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series["test1"].Points.Clear();
            chart2.Series["test2"].Points.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

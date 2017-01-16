using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace WpfApplication2
{
    /// <summary>
    /// Icons made by Icomoon from www.flaticon.com is licensed by CC 3.0 BY
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Application to calculate pay-ins
        // Inputs: trades and parameters, include functionality for groups
        // Want to minimise data cleaning either side of this process. ie align pay-ins with Core format and out format
        // Want flexibility in number of members and currencies but a starting point is the 50 ccy, 100 member format as currently

        // Probably want to specify a class for each member, with associated pay-ins by ccy, time and amount
        // Import trades and parameters from csv files






    }
}

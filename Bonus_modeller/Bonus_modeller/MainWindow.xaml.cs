using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace Bonus_modeller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        [DllImport("Kernel32")]
        public static extern void AllocConsole();

        [DllImport("Kernel32")]
        public static extern void FreeConsole();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnShowConsole_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole();
            Console.WriteLine("Hello World!");
        }

        private void btnHideConsole_Click(object sender, RoutedEventArgs e)
        {
            FreeConsole();
        }


        // Objective of this tool: To generate a visal normal distribution of expected bonus, marking P levels
        // Inputs: Assurance bonus pool, AS performance, My performance (TD/HP/V/C), Historic bonuses and performance
        // Max bonus, Smoothing, Bottom up approach, Make use of 25% max for Manager
        // Calculations: 
        // Output P50, P84, P95, P99 points  in £ amounts, a graph?
        





    }
}

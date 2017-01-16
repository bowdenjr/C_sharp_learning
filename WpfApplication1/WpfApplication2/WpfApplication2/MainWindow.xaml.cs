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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            decode();
        }

/*
To disarm the bomb you have to cut some wires. These wires are either white, black, purple, red, green or orange.
The rules for disarming are simple:
If you cut a white cable you can't cut white or black cable.
If you cut a red cable you have to cut a green one
If you cut a black cable it is not allowed to cut a white, green or orange one
If you cut a orange cable you should cut a red or black one
If you cut a green one you have to cut a orange or white one
If you cut a purple cable you can't cut a purple, green, orange or white cable
If you have anything wrong in the wrong order, the bomb will explode.

 * There can be multiple wires with the same colour and these instructions are for one wire at a time. Once you cut a wire you can forget about the previous ones.

 * Formal Inputs & Outputs

Input description

You will recieve a sequence of wires that were cut in that order and you have to determine if the person was succesfull in disarming the bomb or that it blew up.
 
Input 1

white
red
green
white
 
Input 2

white
orange
green
white
 
Output description

Wheter or not the bomb exploded
Output 1

"Bomb defused"
Output 2

"Boom"   
*/

        public static void decode()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();


        }

        











    }
}

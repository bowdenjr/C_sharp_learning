using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:

            //Division exercise https://www.youtube.com/watch?v=OXTK7cnphYY

            double num01;
            double num02;
                      

            Console.Write("Type a number to be divided: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + num01 / num02);
            Console.ReadKey();
            Console.WriteLine();

            //Return to the beginning
            goto Start;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileloop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int numberofattempts = 0;
            int attempt = 0;

            while(attempt != 6) 
            {
                attempt = numberGen.Next(1, 7);
                Console.WriteLine("Tom rilled: " + attempt + ".");

                numberofattempts++;
            }

            Console.WriteLine("It took Tom " + numberofattempts + " attempts to roll a six.");

        }
    }
}

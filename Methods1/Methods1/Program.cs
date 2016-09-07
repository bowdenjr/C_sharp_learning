using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args) //This is a method called "main", called when the program starts
        {
            //https://www.youtube.com/watch?v=QwygwfqOHsI

            int result = Add(1, 8);

            if (result > 10) { 
                Console.WriteLine("Result is larger than 10");
            }
            else{
                Console.WriteLine("Result is smaller than or equal to 10");
            }
            Console.ReadKey();


        }

        public static int Add(int num01, int num02)
        {

            return (num01 + num02);

        }

       

    }
}

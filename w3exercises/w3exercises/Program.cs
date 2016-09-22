using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3exercises
{

    //http://www.w3resource.com/csharp-exercises/data-types/index.php

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a desired number...");
            string a = Console.ReadLine();
            Console.WriteLine("Enter a desired length...");
            int l = Convert.ToInt32(Console.ReadLine());

            while (l >= 1)
            {

                while (a.Length < l)
                {
                    a = a + a;
                }

                Console.WriteLine(a.Substring(a.Length - l));
                l--;
              
            }

            Console.ReadKey();

        }
    }
}

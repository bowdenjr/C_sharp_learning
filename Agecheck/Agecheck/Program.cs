using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agecheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("That's too bad, you will have to wait a couple of years.");
            } else if (age == 18)
            {
                Console.WriteLine("Barely, made it");
            }else
            {
                Console.WriteLine("You are allowed to enter");
            }

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(utility.CompareValues("Hello","Hello"));
            Console.WriteLine(utility.CompareTypes("Hello", "Type"));

            /// Type this to see what autocompletes... System.Collections.Generic and play with this

            Console.ReadKey();
        }
    }

    class utility
    {
        public static bool CompareValues<T01,T02> (T01 value01, T02 value02) // Checks if two values are equal
        {
            return value01.Equals(value02);
        }
        public static bool CompareTypes<T01, T02>(T01 type01, T02 type02) // Checks 
        {
            return typeof(T01).Equals(typeof(T02));
        }
    }

}


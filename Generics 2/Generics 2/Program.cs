using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using standard dictionary from collections.generic namespace
            Dictionary<string, int> prices = new Dictionary<string, int>(5);
            prices.Add("Watermelon", 5);
            prices.Add("Car", 100000);

            Console.WriteLine(prices["Car"]);

            Console.ReadKey();

        }
    }
}

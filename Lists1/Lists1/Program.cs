using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();


            numbers.Add(13);
            numbers.Add(4);
            numbers.Add(8);

            for (int i = 0; i < numbers.Count; i++)
            { 
                Console.Write(numbers[i]+ ", ");
  
            }


            Console.WriteLine();

            numbers.Remove(3);

            numbers.RemoveAt(1);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + ", ");

            }

            Console.ReadKey();

        }
    }
}

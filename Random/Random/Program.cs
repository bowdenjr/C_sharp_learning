using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rgen = new Random();

            int x = 10;
            int y = 10;

            double[,] randomgrid = new double[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    randomgrid[i, j] = Math.Round(rgen.NextDouble(),1);
                    Console.Write(randomgrid[i, j]+ " ");

                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}

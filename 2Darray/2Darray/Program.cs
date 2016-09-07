using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Darray
{
    class Program
    {
        static void Main(string[] args)
        {

            //multidimensional arrays
            //https://youtu.be/RQ0JHMGiobo?t=16m45
            CreateGrid();

            Console.ReadKey();
        }

        public static void CreateGrid()
        {
            int width = 20;
            int height = 20;

            

            int[,] grid = new int[width, height];

            for(int x = 0; x < width; x++)
            {
                for (int y = 0; y <height; y++)
                {

                    grid[x, y] = x * y;
                    Console.Write(grid[x,y]+ " ");
                    
                }
                Console.WriteLine();
            }

        }

    }
}

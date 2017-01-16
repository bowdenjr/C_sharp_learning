using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Importing_CSVs
{
    class Program
    {
        static void Main()
        {

            //The problem with using arrays is that they need to know how big they are
            //Instead use a list, then convert to an array afterwards

            List<string[]> lines = new List<string[]>();

            
            string strFilename = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\files\\test.csv";
            Console.WriteLine(strFilename);

            foreach (var row in File.ReadLines(@strFilename)) //OPTIONAL: Can use .Skip(1) to skip the headers
            {
                string[] data = row.Split(',');
                lines.Add(data.ToArray());

            }

            string[][] data_array = lines.ToArray();


            Console.ReadKey();



        }

    }
}

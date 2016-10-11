using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{

    //https://youtu.be/RQ0JHMGiobo?list=PLPV2KyIb3jR6ZkG8gZwJYSjnXxmfPAl51
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[3]
            {
                "Tom","Mark","Matt"
            };


            for (int i = 0; i < names.Length; i++)
            {

                Console.Write(names[i] + ", ");

            }



            //foreach(int number in numbers)
            //{
            //    Console.Write(number + ", ");
            //    number = 5;
            //    Console.WriteLine();
            //    Console.WriteLine(numbers[1]);
            //}


            Console.ReadKey();
        }
    }
}

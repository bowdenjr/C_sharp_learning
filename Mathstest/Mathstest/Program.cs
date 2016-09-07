using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathstest
{
    class Program
    {
        static void Main(string[] args)
        {

            Random numberGenerator = new Random();

            //https://www.youtube.com/watch?v=OXTK7cnphYY
            //https://www.youtube.com/watch?v=Qs-LAYkp9YU

            int num01 = numberGenerator.Next(1,11);
            int num02 = numberGenerator.Next(1,11);
            int answer;

            Console.WriteLine("What is " + num01 + " divided by " + num02 + "?");
            answer = Convert.ToInt32(Console.ReadLine());
            if(answer == 25)
            {
                Console.WriteLine("You got it right!");
            } else
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("That's not right!");
                        break;
                    case 2:
                        Console.WriteLine("You are wrong!");
                        break;
                    default:
                        Console.WriteLine("You can do better than that!");
                        break;
                }
           }

            Console.ReadKey();

        }
    }
}

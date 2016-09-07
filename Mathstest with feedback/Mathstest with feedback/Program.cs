using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathstest_with_feedback
{
    class Program
    {
        static void Main(string[] args)
        {

            Start:

            Random numberGenerator = new Random();

            //https://www.youtube.com/watch?v=Qs-LAYkp9YU

            int num01 = numberGenerator.Next(1, 11);
            int num02 = numberGenerator.Next(1, 11);
            

            Console.WriteLine("What is " + num01 + " multiplied by " + num02 + "?");
            int answer = Convert.ToInt32(Console.ReadLine());
            int calcanswer = Convert.ToInt32(num01 * num02);
            int difference = answer - calcanswer;

            if (difference == 0) //correct answer
            {
                Console.WriteLine("You got it right!");
            }
            else if (difference > 0) //incorrect answer
            {
                Console.WriteLine("Your answer is too high, by " + Math.Abs(difference));
            }
            else // answer is too low    
            {
                Console.WriteLine("Your answer is too low, by " + Math.Abs(difference));
            }
                
                
                //int responseIndex = numberGenerator.Next(1, 4);
                
                //switch (responseIndex)
                //{
                //    case 1:
                //        Console.WriteLine("That's not right!");
                //        break;
                //    case 2:
                //        Console.WriteLine("You are wrong!");
                //        break;
                //    default:
                //        Console.WriteLine("You can do better than that!");
                //        break;
                //}

 

            //Ask the user if they want to re-run the program
            Query:
            string rerun;
            Console.WriteLine("Run again? (Y/N)");
            rerun = Console.ReadLine();
            if (rerun == "y" | rerun == "Y"){
                goto Start;
            }else if (rerun =="n" | rerun == "N")
            {
                System.Environment.Exit(1);
            }else
            {
                Console.WriteLine("Error in user input");
                goto Query;
            }

            

        }
    }
}

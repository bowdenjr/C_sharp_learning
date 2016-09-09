using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//https://www.reddit.com/r/dailyprogrammer/comments/5196fi/20160905_challenge_282_easy_unusual_bases/

namespace challenge282
{

    class Program
    {
        static void Main(string[] args)
        {

            start:
            Console.WriteLine("Enter the starting base (either 10 or F)");
            string mode = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the number to be converted");
            double sourcenum = Convert.ToDouble(Console.ReadLine());

            if (mode == "10") //Converting from base10 to baseF
            {
                //Work out the size of the number
                //Loop through fibonacci sum until the sourcenum is less than the fibonacci sum
                //sourcenum example = 20

                bool sumcheck = false;
                int x = 0;

                while(sumcheck == false)
                { 
                    Console.WriteLine(fibsum(x));
                    if (sourcenum < fibsum(x))  {sumcheck = true;}
                    x++;
                }

                Console.WriteLine("Final x = " + x);

            //Generate fibonacci numbers to the size




            //allocate a 1 or a 0, start at highest number, then work down











            }
            else if (mode == "F")  //Converting from baseF to base10
            {











            }
            else //error handling
            {
                Console.WriteLine("Invalid selection, please try again");
                goto start;
            }
            


            


            Console.ReadKey();
        }
        
        static void generatefib(int nth_max) // Generates the fibonacci numbers
        {
            double a = 1;
            double b = 1;
            double c;
            int i = 0;


            while(i<nth_max)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                i++;
            }


        }

        public static double fibsum(int targetsum) //sums to the nth term of the fib sequence
        {
            double a = 1;
            double b = 1;
            double c;
            double sum = 2;
            
            for (int i = 1; i < targetsum; i++)
            {
                c = a + b;
                sum += c;
                a = b;
                b = c;
                
            }

            return sum;
        }

        

    }





}

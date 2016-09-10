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
            string mode = "10";// Convert.ToString(Console.ReadLine())
            Console.WriteLine("Enter the number to be converted");
            int intSourceNum = Convert.ToInt32(Console.ReadLine());

            if (mode == "10") //Converting from base10 to baseF
            {
                //Work out the length of the fib-binary number, by looping through the fibonacci sum until the sourcenum is less than the fibonacci sum
                
                bool sumcheck = false;
                int x = 0;
                
                while(sumcheck == false)
                { 
                    if (intSourceNum < fibsum(x))
                    { 
                        sumcheck = true;
                    } else
                    {                    
                        x++;
                    }
                }

                //Work from the left (largest number, subtract the column header each time)
                //Subtract the fibsum numbers, cycle through x until the variable sum == 0
                int intSourceVary = intSourceNum - fibgen(x);
                double dblOutput = 0;

                //Will always start with a 1
                x--;
                dblOutput = Math.Pow(10, x);

                while (intSourceVary > 0)
                {
                    //Loop through the remaining numbers until intSourceVary == 0
                    if (fibgen(x) <= intSourceVary)
                    {
                        intSourceVary -= fibgen(x);
                        dblOutput += Math.Pow(10, x-1);                        
                    }

                    x--;
                    
                }
                if(intSourceNum == 1) { dblOutput = 1;} //Done to catch the base case of 1, a better solution must exist
                Console.WriteLine("Result = " + dblOutput.ToString("F99").TrimEnd("0".ToCharArray()));







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
            goto start;
        }
        
        static int fibgen(int target) // Generates the nth term of the fibonacci numbers
        {
            int a = 1;
            int b = 1;
            int c;
            int i = 1;
            
            while (i < target)
            {
                c = a + b;
                a = b;
                b = c;
                i++;
            }

            return b;
        }

        static int fibsum(int targetsum) //sums to the nth term of the fib sequence
        {
            int a = 1;
            int b = 1;
            int c;
            int sum = 1;
            
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

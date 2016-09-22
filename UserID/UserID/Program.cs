using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserID
{
    class Program
    {
        static void Main(string[] args)
        {

            string ID = "jbowden";
            string password = "hello";
            int failcounter = 0;

            while(failcounter < 3)
            {
                Console.WriteLine("Please enter User ID");
                string IDentered = Console.ReadLine();
                Console.WriteLine("Please enter password");
                string passwordEntered = Console.ReadLine();

                if (IDentered == ID & passwordEntered == password)
                {
                    Console.WriteLine("Access granted...");
                    Console.ReadKey();
                    return;
                }
                else
                {
                    failcounter++;
                    if(failcounter < 3)
                    { 
                        Console.WriteLine("Error, please try again, failed attmpts = " + failcounter + " of 3");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Exceeded logon attempts, access locked");
                        Console.ReadKey();
                        return;
                    }
                }


            }


            

        }
    }
}

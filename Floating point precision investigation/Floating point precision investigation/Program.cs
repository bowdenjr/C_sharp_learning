using System;

namespace Floating_point_precision_investigation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1.1E+28D;
            double y = 1;

            Console.WriteLine("Beep boop I'm a C# console and I'm using these numbers as Doubles");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("x+y = " + (x+y));
            Console.WriteLine();

            //Compare (using two different methods) x+y, which should be 1,000,...,001.00 and x = 1,000,...,000.00
            Console.WriteLine("Beep boop I've done comparisons on x+y and x and if I think they're the same I'll output True");
            Console.WriteLine(x+y == x); //Simple syntax test for equality
            Console.WriteLine();
            Console.WriteLine("Beep boop, I'm a silly computer");
            
            decimal a = 1.1E+28M;
            decimal b = 1;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Beep boop. However, I have access to 128-bit precise 'Decimal' variales with 28-29 significant digits");
            Console.WriteLine();
            Console.WriteLine("Beep boop I'm a C# console and I'm using these numbers as Decimals");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("a+b = " + (a + b));
            Console.WriteLine();

            Console.WriteLine("Beep boop I've done comparisons on x+y and x and if I think they're the same I'll output True");
            Console.WriteLine(a + b == a); //Simple syntax test for equality
            Console.WriteLine();
            Console.WriteLine("Hurray");
            Console.ReadKey();




        }
    }
}

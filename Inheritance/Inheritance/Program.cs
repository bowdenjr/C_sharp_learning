using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inheritance allows us to share code between classes. eg a Base class shares all of its properties with 
// separate, derived classes. Each instance can re-use code from both Base and Derived classes.

namespace Inheritance
{
    class Animal //Base
    {
        //CLASS VARIABLES
        public string name;
        public int age;
        public float happiness;

        //CLASS METHODS
        public void PrintBase()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }

    class Dog : Animal //Derived
    {
        //CLASS VARIABLES
        public int spotCount;
        


        //CLASS METHODS
        public void Bark()
        {
            Console.WriteLine("Woof!");
            base.happiness += 0.1f; //Adds 0.1 happiness after each bark
        }

    }


    class Cat : Animal //Derived
    {
        //CLASS VARIABLES
        public float cuteness;

        //CLASS METHODS
        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
   
    }




    class Program
    {
        static void Main(string[] args)
        {

            Dog spotty = new Dog();
            spotty.name = "Spotty";
            spotty.age = 4;
            spotty.happiness = 0.6f;
            spotty.spotCount = 200;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("New Happiness: " +spotty.happiness);

            Console.WriteLine();

            Cat heisenberg = new Cat();
            heisenberg.name = "Heisenberg";
            heisenberg.age = 13;
            heisenberg.happiness = 0.2f;
            heisenberg.cuteness = 15;
            heisenberg.PrintBase();
            heisenberg.Meow();
            
            Console.ReadKey();
        }
    }
}

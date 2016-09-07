using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Classes are objects that allow you to specify custom properties and can have certain
//methods applied to them.
//In the example below, we create an Animal class that has 3 properties and a Print() method
//We also count the number of animals within the class constructor


namespace Classes01
{
    class Animal
    {

        //CLASS VARIABLES

        public static int Count = 0;

        public string name;
        public int age;
        public float happiness;

        //CLASS CONSTRUCTORS

        //public Animal()
        //{ 
        //    //default class constructor
        //    name = "Spotty";
        //    age = 6;
        //    happiness = 0.5f;

        //    Count++;
        //}

        public Animal(string _name, int _age, float _happiness) //Another class constructor, use "_" for temp variables
        {
            name = _name;
            age = _age;
            happiness = _happiness;
            Count ++;
        }

        //CLASS METHODS

        public void Print()
        {

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);

        }

    }


    class Program
    {
        public static void Main(string[] args)
        {

            Animal dog = new Animal("Spotty",6,0.5f);
            dog.Print();

            Console.WriteLine();

            Animal cat = new Animal("Mr Beans", 10, 0.8f);
            cat.Print();
            
            Console.WriteLine();

            Animal rabbit = new Animal("Smudge", 6, 1f);
            rabbit.Print();

            Console.WriteLine();
            Console.WriteLine("Num of animals: " + Animal.Count);

            Console.ReadKey();
        }
    }
}

//Notes: There are 3 major types of access modifiers (aka "scope"): private, public, static


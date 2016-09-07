using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUMS
{

    //Think of ENUMS as "custom standard variables"

    enum Breed {Bulldog, Boxer, Chihuahua, Briard}
    
    class Animal //Base
        {
            //CLASS VARIABLES
            public string name;
            public int age;
            public float happiness;

        }

        class Dog : Animal //Derived
        {
            //CLASS VARIABLES
            public Breed breed;

            //CLASS CONSTRUCTOR
            public Dog (string _name, int _age, float _happiness, Breed _breed)
            {
                name = _name;
                age = _age;
                happiness = _happiness;
                breed = _breed;
            }
            

            //CLASS METHODS
                        //CLASS METHODS
            public void PrintBase()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Happiness: " + happiness);

                Console.WriteLine("Breed: " + breed);

            }
        }
    class Program
    {

        static void Main(string[] args)
        {
            Dog hulk = new Dog("Hulk", 6, 0.6f, Breed.Chihuahua);
            hulk.PrintBase();
           
            Console.ReadKey();
        }
        

        
    }
}

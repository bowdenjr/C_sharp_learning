using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The objective here is to make properties of some classes eg health as below, but make these
// properties read-only (ie. "get" only).


namespace Properties
{
    class Program
    {
        //https://www.youtube.com/watch?v=gvQziNULkdY
        class Player
        {
            private int _health = 100; //actual health, private so we can't access
            public int health 
            {
                get //callable, but can't set to it, can only get ie it's read-only
                {
                    return _health;
                }

                set //keeps _health in the range 0 to 100
                { 
                    if (value <= 0)
                    {
                        _health = 0;
                    }
                    else if(value >=100)
                    {
                        _health = 100;
                    }
                    else
                    {
                        _health = value;
                    }
                }
            }


            public void Damage (int _dmg)
            {
                _health -= _dmg;
            }            
        }


        static void Main(string[] args)
        {
            Player Jon = new Player();
            Console.WriteLine(Jon.health);
            Jon.health -= 200;
            Console.WriteLine(Jon.health);
            Jon.health += 400;
            Console.WriteLine(Jon.health);
            Jon.health = 50;
            Console.WriteLine(Jon.health);


            Console.ReadKey();
        }
    }
}

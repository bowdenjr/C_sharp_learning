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
            private int _inthealth = 100; //actual health, private so we can't access
            public int inthealth 
            {
                get //callable, but can't set to it, can only get ie it's read-only
                {
                    return _inthealth;
                }

                set //keeps _health in the range 0 to 100
                { 
                    if (value <= 0)
                    {
                        _inthealth = 0;
                    }
                    else if(value >=100)
                    {
                        _inthealth = 100;
                    }
                    else
                    {
                        _inthealth = value;
                    }
                }
            }


            public void Damage (int _dmg)
            {
                inthealth -= _dmg;
            }


            public void Heal(int _heal)
            {
                inthealth += _heal;
            }
        }


        static void Main(string[] args)
        {
            Player Jon = new Player();
            Console.WriteLine("Starting health = " +Jon.inthealth);
            Jon.Damage(200);
            Console.WriteLine("Take 200 damage = " +Jon.inthealth);
            Jon.Heal(400);
            Console.WriteLine("Heal 400 = " +Jon.inthealth);
            Jon.Damage(30);
            Console.WriteLine("Take small hit = " +Jon.inthealth);


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> meaning = new KeyValuePair<string, int> ("Life", 42); //Created a value type that's paired data together
            meaning.Print();
            Console.ReadKey();
        }
    }

    class KeyValuePair<TKey,TValue> //Usually called just T
    {
        //Create two variables of the types constructed above
        public TKey key;
        public TValue value;

        //Define pair of variables
        public KeyValuePair(TKey _key, TValue _value) 
        {
            key = _key; 
            value = _value;
        }

        //Method for this pair
        public void Print()
        {
            Console.WriteLine("Key = " + key.ToString());
            Console.WriteLine("Value = " + value.ToString());
        }

    }
}

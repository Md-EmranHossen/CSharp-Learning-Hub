using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public  class Person
    {
        public static int Counter;
        public static int id = 0;
        public int Age;

        public  string Name { get; set; }

        static Person()
        {
            Counter = 0;
        }

        public Person()
        {
            Counter++;
        }

        public static void Walk()
        {
        }

        public static void PrintInstanceCount()
        {
            Console.WriteLine(Counter);
        }
    }
}
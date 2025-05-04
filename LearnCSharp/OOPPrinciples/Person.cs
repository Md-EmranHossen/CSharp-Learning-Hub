using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Person : IPerson
    {
        public int age;
        public string name;

        public  void Talk()
        {
            Console.WriteLine("Person Talking");
        }
    }

    public class Product
    {
        public string name;
    }
}

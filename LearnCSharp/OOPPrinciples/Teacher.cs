using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public class Teacher : Person
    {
        public new void Talk()
        {
            Console.WriteLine("Teacher Talking");
        }

        public void Talk(string text)
        {

        }
    }
}

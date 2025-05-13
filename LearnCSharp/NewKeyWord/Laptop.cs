
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewKeyWord
{
    public class Laptop : Product
    {
        public new void ProductName()
        {
            Console.WriteLine("This is a Laptop");
        }
    }
}

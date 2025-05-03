using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Fan
    {
        public void Rotate(bool state)
        {
           if(state)
                Console.WriteLine("Fan rotating");
           else
                Console.WriteLine("Fan off");
        }
    }
}

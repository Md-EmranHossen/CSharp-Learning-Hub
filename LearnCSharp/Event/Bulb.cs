using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Bulb
    {
        public void Light(bool state)
        {
            if (state)
                Console.WriteLine("Light on");
            else
                Console.WriteLine("Light off");
        }
    }
}

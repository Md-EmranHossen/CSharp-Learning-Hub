using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Bus : Vehicle
    {
        public override void StartEngine()
        {
            throw new NotImplementedException();
        }

        public override void StartEngine(double initialSpeed)
        {
            throw new NotImplementedException();
        }
    }
}

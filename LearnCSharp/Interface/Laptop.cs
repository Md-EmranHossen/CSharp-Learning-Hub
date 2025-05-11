
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Laptop : IComputer
    {
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Claculate()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }


        public int GetProcessingPower()
        {
            return 100;
        }
    }
}

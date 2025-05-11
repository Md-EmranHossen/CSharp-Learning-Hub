using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IMachine
    {
        string Model { get; set; }
        void Start();
        void Stop();

        public int GetProcessingPower()
        {
            return 100;
        }

    }
}

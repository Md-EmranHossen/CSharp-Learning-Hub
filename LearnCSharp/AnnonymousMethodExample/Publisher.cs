using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousMethodExample
{
    public class Publisher
    {
        public delegate void MyDelegateType(int a, int b);
        public event MyDelegateType myevEvent;

        public void RaiseEvent(int a, int b)
        {
            if (this.myevEvent != null)
            {
                this.myevEvent(a, b);
            }
        }

    }
}

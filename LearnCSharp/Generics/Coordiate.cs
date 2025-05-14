using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Coordiate<T, Q>
        where T : class, new()  // New keyword means Empty constructor is mendetory
        where Q : struct
    {
        public T X;
        public Q Y;

        public void ThreeDimension<R, S>(R item1, R item2)
        {

        }

        public void Test(T item, Q item2)
        {

        }

        public bool IsSame(T item, Q item2)
        {
            return item.Equals(item2);
        }
    }
}

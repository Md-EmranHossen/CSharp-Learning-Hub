using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFirstAndFirstOrDefault
{
    public class Temporary
    {
        public bool Check(Employee emp)
        {
            return emp.Job == "Developer";
        }
    }
}

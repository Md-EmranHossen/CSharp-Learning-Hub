
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamiterModifier
{
    public  class Test
    {
        // Use params keyword
        public static void Method1(params int[] nums)
        {
            int sum = 0;
            foreach(var num in nums)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }


        public static void Methood2(ref int x)
        {
            x = 8;
        }


        public static void Methood3(in int x)
        {
            // Can not modify in paramer value
            // x = 9;
        }

        public static void Methood4(out int x) // value Type
        {
            // Must set the parameter value
            x = 9;
        }
    }
}

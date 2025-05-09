using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExample
{
    public class Circle : Shape
    {
        public double Radious { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radious * Radious;
        }
    }
}

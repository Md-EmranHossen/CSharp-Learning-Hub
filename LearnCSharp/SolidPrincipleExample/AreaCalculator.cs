using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrincipleExample
{
    public class AreaCalculator
    {
        public int CalculateRectangleArea(int width, int height)
        {
            return width * height;
        }

        public double CalculateCircleArea(int redius)
        {
            return Math.PI * redius * redius;
        }
    }
}

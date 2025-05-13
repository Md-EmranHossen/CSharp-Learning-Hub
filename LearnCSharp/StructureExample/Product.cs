using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureExample
{
    public struct Product : IBaseClass
    {
        public string Name { get; set; }
        public double Price { get; set; }

       
        // In structure Empty constructor is always there.

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }


        public double GetDiscountedPrice(double discount)
        {
            return Price * discount / 100;
        }
    }
}

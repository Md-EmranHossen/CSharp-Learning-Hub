using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    public class Product
    {
        private int Id { get; set; }
        protected string Vendor { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }


        public Product()
        { 
            Id = 0;
            Vendor = string.Empty;
        }

        public virtual double CalculateDiscountedPrice(double amount)
        {
            return Price - (Price * amount / 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devskill.CharpExamples.ClassExamples
{
    internal class Product
    {
        private readonly double _defaultDiscount = 10; // Only chagne in constructor
        private const double PI = 3.1416;  // Never change
        public double Price { get; set; }

        public Product() : this(0)
        {

        }

        public Product(double price) : this(price, 10)
        {

        }

        public Product(double price, double defaultDiscount)
        {
            Price = price;
            _defaultDiscount = defaultDiscount;
        }


        ~Product()
        {

        }

        public double GetDiscount()
        {
            return Price * _defaultDiscount / 100;
        }

        public double GetDiscount(double discount)
        {
            return Price * discount / 100;
        }

        public double GetDiscount(double maxdiscount, double discountAmount)
        {
            double discount = Price * discountAmount / 100;
            if (discount > maxdiscount)
            {
                return maxdiscount;
            }
            else
                return discount;
        }

        public double GetDiscount(int maxdiscount, double discountAmount)
        {
            double discount = Price * discountAmount / 100;
            if (discount > maxdiscount)
            {
                return maxdiscount;
            }
            else
                return discount;
        }
        public double GetDiscount(double discountAmount, int maxdiscount)
        {
            return GetDiscount(maxdiscount, discountAmount);
        }
    }

}

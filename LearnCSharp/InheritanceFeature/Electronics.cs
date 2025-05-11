using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceFeature
{
    public class Electronics : Product
    {
        public string Barcode { get; set; }

        public Electronics()
        {
            Vendor = "DELL";
        }

        public override double CalculateDiscountedPrice(double amount)
        {
            return Price - amount;
        }
    }
}

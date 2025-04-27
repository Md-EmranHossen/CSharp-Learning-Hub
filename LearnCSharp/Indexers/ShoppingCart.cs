using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class ShoppingCart
    {
        private List<Product> products = new List<Product>();
        public Product this[int position]
        {
            get
            {
                return products[position];
            }
            set
            {
                products[position] = value;
            }
        }


        // Access using string
        public Product this[string position]
        {
            get
            {
                return products[int.Parse(position)];
            }
            set
            {
                products[int.Parse(position)] = value;
            }
        }


        // Multipule parameters
        public Product this[int x, double y]
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();

            }
        }
    }
}

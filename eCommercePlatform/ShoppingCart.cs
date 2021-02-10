using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class ShoppingCart
    {
        //Variables
        List<Product> products;
        public double totalCostProducts;

        //ctor
        public ShoppingCart(double totalCostProducts)
        {
            this.totalCostProducts = totalCostProducts;
        }

        //Methods

    }
}

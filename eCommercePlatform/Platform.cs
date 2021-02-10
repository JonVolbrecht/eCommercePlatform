using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    class Platform
    {
        //Variables
        List<Product> inventory;

        //ctor
        public Platform()
        {
            inventory = new List<Product>();
        }

        //Methods
        private Product CreateProduct(int uniqueIdentifier, string name, string category, double price, double averageRating)
        {
            Product product = new Product(uniqueIdentifier, name, category, averageRating);

            return product;

        }
    }
}

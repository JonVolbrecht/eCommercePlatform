using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Consumer
    {
        //Variables
        public string firstName;
        public string lastName;
        ShoppingCart shoppingCart;

        //ctor
        public Consumer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

        }

        //Methods
        public ShoppingCart CreateShoppingCart(double totalCostProducts)
        {
            ShoppingCart shoppingCart = new ShoppingCart(totalCostProducts);

            return shoppingCart;
        }

        private 
    
    
    
    
    
    
    
    
    }

    
}

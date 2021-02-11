using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Product
    {
        //Variables
		public int uniqueIdentifier;
		public string name;
		public string category;
		public double price;
		public double averageRating;
		List<Review> reviews;

        
        //ctor
        public Product(int uniqueIdentifier, string name, string category, double price, double averageRating)
        {
            this.uniqueIdentifier = uniqueIdentifier;
            this.name = name;
            this.category = category;
            this.price = price;
            this.averageRating = averageRating;
        }

        //Methods

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Product
    {
		public int uniqueIdentifier;
		public string name;
		public string category;
		public double price;
		public double averageRating;
		List<Review> reviews;
    }
}

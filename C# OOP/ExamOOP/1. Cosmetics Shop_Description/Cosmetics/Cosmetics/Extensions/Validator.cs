namespace Cosmetics.Extensions
{
    using System;

    public class Validator
    {
        public static void CheckForNullOrEmpty(object obj,string message = null)
        {
            if (obj == null )
	        {
                throw new ArgumentException("Cannot be empty or null");		 
	        }
        }

        public static void CheckNegativeValues(decimal value, string message = null)
        {
            if (value < 0)
            {
                throw new ArgumentException("Cannot be negative value");
            }
        }
     
        public static void CheckIsInRangeProducts(int value, string type, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(string.Format("Product {0} must be between {1} and {2} symbols long!",type,min,max));
            }
        }

        public static void CheckIsInRangeCategories(int value, string type, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(string.Format("Category {0} must be between {1} and {2} symbols long!", type, min, max));
            }
        }
    }
}

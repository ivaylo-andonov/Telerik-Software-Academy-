namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerbleExtensionss
    {
        public static T Sum<T>(this IEnumerable<T> numeralCollection) 
        {
            if (numeralCollection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            T sum = (dynamic)0;

            foreach (var item in numeralCollection)
            {
                sum += (dynamic)item;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> numeralCollection) 
        {
            dynamic product = 1;

            if (numeralCollection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            
            foreach (var item in numeralCollection)
            {
               product *= item;
            }
            return product;
        }

        public static T Min<T>( this IEnumerable<T> collection ) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            T min = collection.Last();
            foreach (var item in collection)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

         public static  T Max<T>( this IEnumerable<T> collection ) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            T max = collection.Last();
            foreach (var item in collection)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Averige<T>( this IEnumerable<T> collection ) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            double result = 0.0;
            result = collection.Aggregate(result,(x,y) => (dynamic)x + y)/ collection.Count();
            return result;
        }
    }
}

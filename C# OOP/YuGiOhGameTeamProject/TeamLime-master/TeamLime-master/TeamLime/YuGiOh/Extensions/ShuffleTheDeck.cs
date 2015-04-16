namespace YuGiOh.Extensions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var array = source.ToArray();
            var n = array.Length;
            for (var i = 0; i < n; i++)
            {
                int r = i + RandomProvider.Instance.Next(0, n - i);
                var temp = array[i];
                array[i] = array[r];
                array[r] = temp;
            }
            return array;
        }
    }
}

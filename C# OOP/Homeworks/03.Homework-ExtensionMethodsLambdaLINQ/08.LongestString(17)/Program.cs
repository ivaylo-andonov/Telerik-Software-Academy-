namespace LongestString
{
    using System.Linq;
    using System;

    class LongestString
    {
        static void Main()
        {
            string[] stringsArray = new string[] { "Telerik", "Jaba", "MO", "Peshou", "Stela","YabaDabaDuuuuuuu" };

            var longestString = (from str in stringsArray
                                 orderby str.Length
                                 select str).LastOrDefault();

            Console.WriteLine("The longest string is:\n");
            Console.WriteLine(longestString);
        }
    }
}
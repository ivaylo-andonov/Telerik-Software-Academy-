namespace _02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class IEnumerableTest
    {
        static void Main()
        {
            // Test the new extensions methods for any collection
            List<int> myList = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                myList.Add(i + 5);
            }
            Console.WriteLine("The items is my collection:\n");
            foreach (var item in myList)
            {
                Console.Write(item + " ");                
            }
            Console.WriteLine();

            Console.Write("\nSum:");
            Console.WriteLine(myList.Sum());
            Console.Write("\nMax:");
            Console.WriteLine(myList.Max());
            Console.Write("\nMin:");
            Console.WriteLine(myList.Min());
            Console.Write("\nAverige:");
            Console.WriteLine(myList.Averige());

        }
    }
}

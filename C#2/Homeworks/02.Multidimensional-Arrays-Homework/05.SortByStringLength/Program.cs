//You are given an array of strings. Write a method that sorts the array
//by the length of its elements (the number of characters composing them).

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number N size of the array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers of array:", n);
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine("Sorted words by length :\n");
        var sortedArray = array.OrderBy(x => x.Length);
        Console.WriteLine(string.Join("\n", sortedArray));

        // SECOND WAY:

        //Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        //Console.WriteLine(string.Join("\n", array));

        // Sorting numbers by last digit:

        //int[] array = Console.ReadLine().Split(',', ' ').Select(x => int.Parse(x)).ToArray();
        //Array.Sort(array, (x , y) => (x%10).CompareTo(y%10));

        //foreach (var item in array)
        //{
        //    Console.WriteLine(item);
        //}
    }
}


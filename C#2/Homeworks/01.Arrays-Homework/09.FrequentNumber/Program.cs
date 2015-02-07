//Write a program that finds the most frequent number in an array.
//Example:
//input	:                                |  result:
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	 | 4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma:\n");
        int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' },
                      StringSplitOptions.RemoveEmptyEntries ).Select(x => int.Parse(x)).ToArray();

        // Create a dictionary to know each number how many times the number appears 
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        // Use loop for the array, if the number doesn`t contain in dict - just add it, if it contain - add the count ( values)
        for (int i = 0; i < array.Length; i++)
        {
            if (!dictionary.ContainsKey(array[i]))
            {
                dictionary.Add(array[i], 1);
            }
            else
            {
                dictionary[array[i]] += 1;
            }
        }
        Console.Write("\nThe most Frequent number is {0} ", dictionary.OrderBy(x => x.Value).Last().Key);
        Console.WriteLine("({0}) times.\n", dictionary.Values.Max());


        // SECOND WAY :

        //var number = (from numbers in array
        //        group numbers by numbers into grouped orderby grouped.Count() descending
        //        select new { Number = grouped.Key, Freq = grouped.Count() }).First();

        //Console.WriteLine("The most frequent number is {0}, ({1}) times.",number.Number,number.Freq);


        // THIRD WAY :

        //int mostFreqNumber = array.GroupBy(v => v).OrderBy(g => g.Count()).Last().Key;
        //Console.WriteLine("The most frequent number is: {0}",mostFreqNumber);

    }
}


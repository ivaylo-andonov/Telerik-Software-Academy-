//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.
//Example:
//input array:	           | S:	| result:
//2, 1, 2, 4, 3, 5, 2, 6   | 14	| yes

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
                        StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        Console.WriteLine("Enter a sum (number S) :");
        int S = int.Parse(Console.ReadLine());

        bool isSubsetSum = false;
        int max = (int)Math.Pow( 2, array.Length);
        
        // Generate all posible combinations
        for (int i = 0; i  < max - 1; i ++)
        {
            int currentSum = 0;
            for (int j = 0; j < array.Length; j++)
            { 
                int mask = 1 << j;         // Going through the binary number from most left position ++ to the right
                int nAndMask = i & mask;   // See the bit( digit by digit ) on j position in the binary number
                int bit = (nAndMask >> j); // Take the bit (current digit) from the binary number and check if its == 1
                if (bit == 1)
                {
                    currentSum += array[j];     
                }
            }
            if (currentSum == S)
            {
                isSubsetSum = true;   
            }
        }
        Console.WriteLine( isSubsetSum == true? "Yes" : "No");


        // SECOND WAY WITH DICTIONARY:

        //long S = long.Parse(Console.ReadLine());
        //int N = Int32.Parse(Console.ReadLine());

        //long[] numbers = new long[N];
        //for (int i = 0; i < N; i++) numbers[i] = long.Parse(Console.ReadLine());

        //Dictionary<long, int> sums = new Dictionary<long, int> { { 0, 1 } };
        //foreach (var currentElement in numbers)
        //{
        //    Dictionary<long, int> copyOfSums = new Dictionary<long, int>(sums);
        //    foreach (KeyValuePair<long, int> pair in copyOfSums)
        //    {
        //        var currentSum = currentElement + pair.Key;
        //        if (!sums.ContainsKey(currentSum)) sums.Add(currentSum, pair.Value);
        //        else sums[currentSum] += pair.Value;
        //    }
        //}
        //sums[0]--; //remove the empty subset
        //Console.WriteLine(sums.ContainsKey(S) ? sums[S] : 0);
    }
}


//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number of elements in the array (number N) :");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        Console.WriteLine("Enter {0} numbers of array:",N);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter a count of elements to sum (number K) :");
        int K = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a needed sum (number S) :");
        int S = int.Parse(Console.ReadLine());

        bool isSubsetSum = false;   
        int max = (int)Math.Pow(2, array.Length);
        int count = 0;
        // Generate all posible combinations
        for (int i = 0; i < max - 1; i++)
        {
            int currentSum = 0;
            int counter = 0;
            for (int j = 0; j < array.Length && !isSubsetSum; j++)
            {
                int mask = 1 << j;         // Going through the binary number from most left position ++ to the right
                int nAndMask = i & mask;   // See the bit( digit by digit ) on j position in the binary number
                int bit = (nAndMask >> j); // Take the bit (current digit) from the binary number and check if its == 1
                if (bit == 1)
                {
                    currentSum += array[j];
                    counter++;               // count how many times we combined
                }
            }
            if ( counter == K && currentSum == S)
            {
                isSubsetSum = true;
                count += counter;
            }
        }
        Console.WriteLine("Result is :");
        Console.WriteLine(isSubsetSum == true ? "Yes" : "No");
        Console.WriteLine("The sum ({0}) contains {1} numbers from the array",S,count);
    }
}


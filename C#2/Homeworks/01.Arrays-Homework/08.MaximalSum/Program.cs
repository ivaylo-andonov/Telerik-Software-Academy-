//Write a program that finds the sequence of maximal sum in given array.
//Example:
//input:                             | result:
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8;  | 2, -1, 6, 4

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma: ");
        int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' }).Select(x => int.Parse(x)).ToArray();

        int biggestSum = int.MinValue;
        int startNum = 0;
        int startIndex = 0;
        int endNum = 0;
        for (int i = 1; i <= array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                int sum = array.Take(i).Sum();
                if (sum <= 0)
                {
                    startIndex = i;
                    sum = 0;
                }
                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    startNum = startIndex;
                    endNum = i+j;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("The sequence with maximal sum is:");
        for (int i = startNum; i < endNum; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}


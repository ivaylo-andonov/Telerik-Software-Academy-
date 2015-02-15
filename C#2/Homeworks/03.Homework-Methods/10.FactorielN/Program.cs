//Write a program to calculate n! for each n in the range [1..100].


using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        CalculateFactorial(n);                       
    }

    private static void CalculateFactorial(int number)
    {
        BigInteger product = 1;
        int[] nums = Enumerable.Range(1, number).ToArray();
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            product *= nums[i];

        }
        Console.WriteLine(product);
    }

   
}


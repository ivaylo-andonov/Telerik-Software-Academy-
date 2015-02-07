//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        BigInteger workingFactorial = factorial;
        BigInteger count = 0;

        while (workingFactorial > 0)
        {
            if (workingFactorial % 10 == 0)
            {
                count++;
                workingFactorial /= 10;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("Trailing zeroes in N!: {0}", count);
        Console.WriteLine("Explaination: {0}", factorial);
        Console.WriteLine();
    }
}


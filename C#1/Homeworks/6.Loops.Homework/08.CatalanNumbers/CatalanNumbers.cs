//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger catalanN;
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorial1N = 1;

        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
        }
        for (int i = 1; i <= n * 2; i++)
        {
            factorial2N *= i;
        }
        for (int i = 1; i <= 1 + n; i++)
        {
            factorial1N *= i;
        }

        catalanN = factorial2N / (factorial1N * factorialN);
        Console.WriteLine(catalanN);
        

    }
}


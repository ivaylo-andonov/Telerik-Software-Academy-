//In combinatorics, the number of ways to choose k different members out of a group of 
//n different elements (also known as the number of combinations) is calculated by the following formula:
//formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialK = 1;
        BigInteger factorialN = 1;
        BigInteger factorialNminusK = 1;
        BigInteger result = 0;

        if (n > 1 && k > 1 && n < 100 && k < 100 && k < n)
        {
            for (uint i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (uint i = 1; i <= k; i++)
            {
                factorialK *= i;
            }
            for (uint i = 1; i <= n - k; i++)
            {
                factorialNminusK *= i;
            }

            result = factorialN / (factorialK * factorialNminusK);
            Console.WriteLine(result);

        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}


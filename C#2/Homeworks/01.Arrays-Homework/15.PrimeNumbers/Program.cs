//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long n = 10000; // 10 000 000 prime numbers is too big number and the console`s buffer will blow/crash during writing numbers
        bool[] isNotPrime = new bool[n];

        for (int i = 2; i < n; i++)
        {
            if (!isNotPrime[i])
            {
                // generate all numbers that are a product
                for (int j = 2; i * j < n; j++)
                {
                    isNotPrime[i * j] = true;
                }
            }
        }

        for (int i = 2; i < n; i++)
        {
            if (!isNotPrime[i])
            {
                Console.Write(i + ",");
            }
        }        
    }
}


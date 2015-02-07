//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class Program
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        byte k = byte.Parse(Console.ReadLine());

        ulong factorialN = 1;
        ulong factorialK = 1;
        ulong result = 0;

        if (n > 1 && k > 1 && n < 100 && k < 100 && k < n)
        {
            for (uint i = 1; i <= n ; i++)
            {
                factorialN *= i;
            }
            for (uint i = 1; i <= k; i++)
            {
                factorialK *= i;
            }

            result = factorialN / factorialK;
            Console.WriteLine(result);
        }
        else
	    {
            Console.WriteLine("Invalid output");
	    }
    }
}


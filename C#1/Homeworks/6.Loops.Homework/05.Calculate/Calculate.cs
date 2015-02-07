//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class Calculate
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double factoriel = 1;
        double S ;
        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
            S = factoriel / Math.Pow(x, i);
            sum += S;
            
        }
        Console.WriteLine("{0:F5}",sum + 1);
    }
}


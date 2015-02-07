//Write a program that reads from the console a positive integer number n (1 = n = 20)
//and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n > 1 && n < 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <= n + i; j++)
                {
                    Console.Write("{0,-3}",j);
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
        Console.WriteLine();
    }
}
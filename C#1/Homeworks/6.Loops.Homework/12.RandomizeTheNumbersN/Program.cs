//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random randomNumbers = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(randomNumbers.Next(1,n + 1) + " ");
        }
        Console.WriteLine();
    }
}


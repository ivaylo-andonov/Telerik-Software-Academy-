//Write a program that enters a number n and after that enters 
//more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < a; i++)
        {
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}


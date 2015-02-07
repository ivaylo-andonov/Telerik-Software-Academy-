//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
//the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a lenght of numbers: ");
        int lenght = int.Parse(Console.ReadLine());

        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0;
        double averige = 0;

        for (int i = 0; i < lenght; i++)
        {
            int number = int.Parse(Console.ReadLine());

            min = Math.Min(min, number);

            max = Math.Max(max, number);

            sum  += number;

            averige = sum / lenght;

        }
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\naverige = {3:F2}",min,max,sum,averige);
    }
}


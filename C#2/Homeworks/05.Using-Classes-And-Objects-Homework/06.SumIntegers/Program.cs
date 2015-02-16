//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.
//Example:
//input	           | output
//"43 68 9 23 318" |	461

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sequence of integers separeted by spaces:");
        string input = Console.ReadLine();
        Console.WriteLine("The sum of separated integers is: {0}",SumSeparetedNumbers(input));
        
    }

    private static long SumSeparetedNumbers(string input)
    {
        long result = 0;
        int[] separetedNumbers = input.Split(' ').Select((x) => int.Parse(x)).ToArray();
        for (int i = 0; i < separetedNumbers.Length; i++)
        {
            result += separetedNumbers[i];
        }
        return result;
    }
}


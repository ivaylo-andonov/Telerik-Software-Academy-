//Write a method that reverses the digits of given decimal number.
//Example:
//input	 output
//256	    652

using System;

class Program
{
    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nReversed number: {0}",ReverseNumber(number));
    }
    private static string ReverseNumber(decimal number)
    {
        string result = string.Empty;
        while (number >1)
        {           
            long digit = (long)number % 10;
            result += digit;
            number /= 10;
        }       
        return result;
    }
}


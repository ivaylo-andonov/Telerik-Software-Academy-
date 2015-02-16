//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose the first numeral system (in range: 2 < n < 16):");
        int firstNumeralSystem = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number in {0}-based numberal system:\n",firstNumeralSystem);
        long input = Math.Abs(long.Parse(Console.ReadLine()));
        Console.WriteLine("Choose the second numeral system into which you want to convert(in range: 2 <s< 16):");
        int secondNumeralSystem = int.Parse(Console.ReadLine());

        long number = input;
        long decimalNumber = 0;       
        int power = 0;
        while (number > 0)
        {
            int digit = (int)number % 10;
            digit *= (int)Math.Pow(firstNumeralSystem, (double)power);
            decimalNumber += digit;
            power++;
            number /= 10;
        }
        StringBuilder str = new StringBuilder();

        while (decimalNumber > 0)
        {                       
             str.Insert(0,decimalNumber % secondNumeralSystem);
            
            decimalNumber /= secondNumeralSystem;
        }
        Console.WriteLine("\n The number {0} in {1}-based numeral system is:\n {2} in {3}-based numeral system\n"
                            ,input,firstNumeralSystem,str.ToString(),secondNumeralSystem);
    }
}


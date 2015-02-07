//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number:");
        string input = Console.ReadLine();
        BigInteger  binaryNum = BigInteger.Parse(input);
        int power = 0;
        BigInteger result = 0;
        while (binaryNum > 0)
        {
            BigInteger digit = (BigInteger)binaryNum % 10;
            digit *= (int)Math.Pow(2,(double)power);
            result += digit;
            power++;
            binaryNum /= 10;
        }
        Console.WriteLine("Decimal: "+ result);
    }
}


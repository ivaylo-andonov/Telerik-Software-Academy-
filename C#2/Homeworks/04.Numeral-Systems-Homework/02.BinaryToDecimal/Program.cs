//Write a program that converts a binary integer number to its decimal form.
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number:");
        string input = Console.ReadLine();
        BigInteger binaryNum = BigInteger.Parse(input);
        int power = 0;
        BigInteger result = 0;
        while (binaryNum > 0)
        {
            BigInteger digit = (BigInteger)binaryNum % 10;
            digit *= (int)Math.Pow(2, (double)power);
            result += digit;
            power++;
            binaryNum /= 10;
        }
        Console.WriteLine("Decimal: " + result.ToString());

        // SECOND WAY

        //Console.Write("Enter unsigned binary number: ");
        //string input = Console.ReadLine();
        //int result = 0;
        //for (int i = 0; i < input.Length; i++)
        //{
        //    result = result * 2;
        //    if (input[i] == '1')
        //        result = result + 1;
        //}
        //Console.WriteLine("Decimal representation of {0} is {1}", input, result);
    }
}


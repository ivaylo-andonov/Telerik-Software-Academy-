//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter positive decimal number: ");
        long input = long.Parse(Console.ReadLine());
        StringBuilder stringBuilder = new StringBuilder();
        Console.Write("Binary representation of {0} is ", input);
        while (input > 0)
        {
            stringBuilder.Insert(0, input % 2); // insert '0' or '1' at beginning of string
            input = input / 2;
        }
        Console.WriteLine(stringBuilder.ToString().PadLeft(32,'0'));


        // SECOND WAY

        //Console.WriteLine("Enter a decimal number :");
        //BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());
        //string reversedResult = "";
        //while (decimalNumber > 0)
        //{
        //    reversedResult += decimalNumber % 2;
        //    decimalNumber /= 2;
        //}

        //string finalResult = "";
        //for (int i = reversedResult.Length - 1; i >= 0; i--)
        //{
        //    finalResult += reversedResult[i];
        //}
        //Console.WriteLine("Binary : " + finalResult.PadLeft(16, '0'));
    }
}


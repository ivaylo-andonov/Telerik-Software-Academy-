//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number :");
        BigInteger decimalNumber = BigInteger.Parse(Console.ReadLine());
        string reversedResult = "";
        if (decimalNumber > 0 )
        {
            while (decimalNumber > 0)
            {
                if (decimalNumber % 2 == 0)
                {
                    reversedResult += "0";
                }
                else if (decimalNumber % 2 != 0)
                {
                    reversedResult += "1";
                }
                decimalNumber /= 2;
            }

            string finalResult = "";
            BigInteger binaryNum = BigInteger.Parse(reversedResult);

            for (int i = 0; i < reversedResult.Length; i++)
            {
                string digit = Convert.ToString(binaryNum % 10);
                finalResult += digit;
                binaryNum /= 10;
            }
            Console.WriteLine("Binary : " + finalResult);
        }
        else
        {
            Console.WriteLine("0");
        }
        
    }
}


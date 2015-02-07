//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number :");
        long decimalNumber = long.Parse(Console.ReadLine());
        string reversedResult = "";

        while (decimalNumber > 0)
        {
           long digit = (long)decimalNumber % 16;
           if (digit == 0)
            {
                reversedResult += "0";
            }
            else if (digit != 0)
            {
                switch (digit)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        reversedResult += Convert.ToString(digit);
                        break;
                    case 10: reversedResult += Convert.ToString("A"); break;
                    case 11: reversedResult += Convert.ToString("B"); break;
                    case 12: reversedResult += Convert.ToString("C"); break;
                    case 13: reversedResult += Convert.ToString("D"); break;
                    case 14: reversedResult += Convert.ToString("E"); break;
                    case 15: reversedResult += Convert.ToString("F"); break;
                }
            }
            decimalNumber /= 16;
        }
        string finalResult = "";
        for (int i = reversedResult.Length - 1; i >= 0; i--)
        {
            finalResult += Convert.ToString(reversedResult[i]);
        }
        Console.WriteLine("Hexadecimal : " + finalResult);
    }
}


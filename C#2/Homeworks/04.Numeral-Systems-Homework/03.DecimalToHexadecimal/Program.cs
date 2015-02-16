//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a decimal number:");
        long number = long.Parse(Console.ReadLine());
        StringBuilder str = new StringBuilder();

        while (number > 0)
        {
            int digit = (int)number % 16;
            switch (digit)
            {
                case 10: str.Insert(0, "A".ToString()); break;
                case 11: str.Insert(0, "B".ToString()); break;
                case 12: str.Insert(0, "C".ToString()); break;
                case 13: str.Insert(0, "D".ToString()); break;
                case 14: str.Insert(0, "E".ToString()); break;
                case 15: str.Insert(0, "F".ToString()); break;
                default: if (digit >= '0' || digit <= '9') str.Insert(0, digit.ToString()); break;
            }
            number /= 16;
        }
        Console.WriteLine("\nHexadecimal numeral representation: {0}\n",str.ToString());
    }
}


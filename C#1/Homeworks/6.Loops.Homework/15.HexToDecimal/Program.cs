//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string input = Console.ReadLine();
        long decimalNumber = 0;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    decimalNumber += (long.Parse(input[i].ToString())) * (long)Math.Pow(16, i);
                    break;
                case 'A':
                    decimalNumber += 10 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'B':
                    decimalNumber += 11 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'C':
                    decimalNumber += 12 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'D':
                    decimalNumber += 13 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'E':
                    decimalNumber += 14 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
                case 'F':
                    decimalNumber += 15 * (long)Math.Pow(16, input.Length - 1 - i);
                    break;
            }
        }
        Console.WriteLine("Decimal: {0}", decimalNumber);
    }
}
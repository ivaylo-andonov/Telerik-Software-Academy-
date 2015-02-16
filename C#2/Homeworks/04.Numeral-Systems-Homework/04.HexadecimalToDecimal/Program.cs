//Write a program to convert hexadecimal numbers to their decimal representation.
using System;
using System.Numerics;

class HexToDec
{
    static void Main()
    {
        Console.Write("Enter some hexadecimal number: ");
        string input = Console.ReadLine().ToUpper();
        BigInteger result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            result = result * 16;
            if (input[i] < '9')
                result = result + (input[i] - 48); // input[i] is a char value. '1'(as char) - 45 = 1 (as int)
            else
                result = result + (input[i] - 55); // input[i] is a char value. 'A'(as char)= 65. 65 - 55 = 10
        }
        Console.WriteLine("Decimal representation of hexadecimal number 0x{0} is {1}", input, result);

        //SECOND WAY

        //Console.Write("Enter a hexadecimal number: ");
        //string input = Console.ReadLine();
        //long decimalNumber = 0;
        //for (int i = input.Length - 1; i >= 0; i--)
        //{
        //    switch (input[i])
        //    {
        //        default: if (input[i] < 10) decimalNumber += (long.Parse(input[i].ToString())) * (long)Math.Pow(16, i); break;
        //        case 'A': decimalNumber += 10 * (long)Math.Pow(16, input.Length - 1 - i); break;
        //        case 'B': decimalNumber += 11 * (long)Math.Pow(16, input.Length - 1 - i); break;
        //        case 'C': decimalNumber += 12 * (long)Math.Pow(16, input.Length - 1 - i); break;
        //        case 'D': decimalNumber += 13 * (long)Math.Pow(16, input.Length - 1 - i); break;
        //        case 'E': decimalNumber += 14 * (long)Math.Pow(16, input.Length - 1 - i); break;
        //        case 'F': decimalNumber += 15 * (long)Math.Pow(16, input.Length - 1 - i); break;
        //    }
        //}
        //Console.WriteLine("Decimal: {0}", decimalNumber);
    }
}
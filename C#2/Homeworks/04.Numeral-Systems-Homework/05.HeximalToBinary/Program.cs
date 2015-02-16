//Write a program to convert hexadecimal numbers to their binay representation.

using System;

class HexToBin
{
    static void Main()
    {
        Console.Write("Enter any hexadecimal number: ");
        string input = Console.ReadLine().ToUpper();
        string result = "";
        int index = 0;
        for (int i = 0; i < input.Length; i++)
        {
            index = input[i] - 48; // convert char to int: '0' -> 0, '9'-> 9 etc.
            if (index > 9) index = index - 7; // A-> 10, B -> 11 etc.
            if (index < 0 || index > 15)
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            result = result + Convert.ToString(index, 2).PadLeft(4, '0') + " ";
        }
        Console.WriteLine("Binary representation ot hexadecimal number 0x{0} is {1}", input, result);
    }
}
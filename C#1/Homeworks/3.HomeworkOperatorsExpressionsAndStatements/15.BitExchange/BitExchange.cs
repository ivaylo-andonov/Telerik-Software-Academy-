//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        uint mask = 7;

        uint rightBits = (number >> 3) & mask;
        uint leftBits = (number >> 24) & mask;

        number = number & ~(mask << 3);
        number = number & ~(mask << 24);

        number = (rightBits << 24) | number;
        number = (leftBits << 3) | number;

        Console.WriteLine(number);
    }
}


//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class BitWiseBit3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = 3;
        n = n >> p;
        n = n & 1;
        Console.WriteLine(n);
    }
}


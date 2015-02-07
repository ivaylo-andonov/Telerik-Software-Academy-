using System;

class Program
{
    static void Main()
    {
        int? nullableOne = null;
        double? nullableTwo = null;
        Console.WriteLine(nullableOne + " " + nullableTwo);
        nullableOne += 5;
        nullableTwo *= 7;
        Console.WriteLine(nullableOne + " " + nullableTwo);

    }
}
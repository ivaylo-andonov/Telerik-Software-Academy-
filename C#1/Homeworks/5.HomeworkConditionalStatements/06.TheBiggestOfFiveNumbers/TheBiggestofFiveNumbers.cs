//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class TheBiggestofFiveNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double maxNum = Math.Max(e , Math.Max(d, Math.Max( c, Math.Max(a, b))));
        Console.WriteLine(maxNum);
    }
}


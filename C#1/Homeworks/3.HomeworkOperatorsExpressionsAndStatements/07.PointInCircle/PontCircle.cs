//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PontCircle
{
    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());            // How to find point in a circle:  X^2 + Y^2 <= Radius^2
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (((x * x) + (y * y)) <= 2 * 2);  
        Console.WriteLine(isInCircle);

    }
}


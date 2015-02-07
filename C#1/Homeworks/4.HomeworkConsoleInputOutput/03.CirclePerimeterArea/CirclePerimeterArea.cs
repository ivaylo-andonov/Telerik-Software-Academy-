//Write a program that reads the radius r of a circle and prints its
//perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        double area = radius * radius * Math.PI;
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine("The circle`s perimeter is {0:F2} and area is : {1:F2}", perimeter, area);
    }
}


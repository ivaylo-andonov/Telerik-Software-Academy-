//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * width + 2 * height;
        double area = width * height;
        Console.WriteLine("Perimeter of rectangle is :{0}\nArea of rectangle is: {1}", perimeter, area);
    }
}


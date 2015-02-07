//Write an expression that checks for given point (x, y) if it is 
//within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInsideOfCircleOutsideOfRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (Math.Pow(x-1,2) + Math.Pow(y - 1,2)) <= 1.5 * 1.5;  // Math.Pow find ^ of number
        bool isInRectangle = (x<=5 && x >= -1) && (y <=1 & y>= -1);           // (x-center_x)^2 + (y-center_y)^2 <= radius^2
        if (isInCircle && !isInRectangle)                                    //  center is the center of the circle for x and y
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }
}
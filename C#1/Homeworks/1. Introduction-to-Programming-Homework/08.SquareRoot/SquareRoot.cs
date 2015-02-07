using System;

class SquareRoot
{
    static void Main()
    {
        Console.WriteLine("Enter the number : ");
        int number = int.Parse(Console.ReadLine());
        double sqrtNumber = Math.Sqrt(number);

        //Console.WriteLine("Square root of " + number + " is " + sqrtNumber);
        Console.WriteLine("Square root of {0} is: {1:##}", number, sqrtNumber);
            
    }
}
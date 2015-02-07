//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.Note: Don’t use arrays and the built-in sorting functionality.

using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        
        if (a > b && a > c)
        {
            if (b > c)
            {
                Console.WriteLine(a +" "+ b +" "+c );
            }
            else if (c > b)
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                Console.WriteLine(b + " " + a + " " + c);
            }
            else if (c > a)
            {
                Console.WriteLine(b + " " + c + " " + a);
            }
        }
        else if (c > a && c > b)
        {
            if (a > b)
            {
                Console.WriteLine(c + " " + a + " " + b);
            }
            else if (b > a)
            {
                Console.WriteLine(c + " " + b + " " + a);
            }
        }
        else 
        {
            Console.WriteLine(a+ " "+ b + " "+ c);
        }
    }
}


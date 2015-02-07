//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater number is : {0}", a > b ? a : b);
    }
}

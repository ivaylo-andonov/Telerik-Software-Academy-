//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter year (YYYY):\n");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Is {0} year a leap?  {1}", year, DateTime.IsLeapYear(year));
    }
}


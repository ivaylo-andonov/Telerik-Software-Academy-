//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first date:");
        int[] firstDate = Console.ReadLine().Split('.').Select(int.Parse).ToArray();

        Console.WriteLine("Enter the second date:");
        int[] secondDate = Console.ReadLine().Split('.').Select(int.Parse).ToArray();

        DateTime dateOne = new DateTime(firstDate[2], firstDate[1], firstDate[0]);
        DateTime dateTwo = new DateTime(secondDate[2], secondDate[1], secondDate[0]);
        
        Console.WriteLine("The days between {0} and {1} are {2}",dateOne.ToShortDateString(),dateTwo.ToShortDateString(), (dateTwo-dateOne).Days);
    }
}


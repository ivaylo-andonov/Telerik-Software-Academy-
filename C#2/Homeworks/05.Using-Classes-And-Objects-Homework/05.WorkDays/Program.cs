//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

using System;
using System.Linq;

class Program
{
    static readonly DateTime[] holidays =
	{
        // Holidays dates
		new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
		new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
		new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
		new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
	};

    static void Main()
    {
        DateTime dateNow = DateTime.Now;
        Console.WriteLine("Enter a date in the future between today and 31.12.2015 in format dd.MM.yyyy:");
        int[] futureDateInput = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
        DateTime futureDate = new DateTime(futureDateInput[2], futureDateInput[1], futureDateInput[0]);

        Console.WriteLine("This program will check how many workdays there are between {0:dd.MM.yyyy} and {1:dd.MM.yyyy}",dateNow,futureDate);
        Console.WriteLine("\nTotal workdays: {0}",CheckWorkingDays(dateNow, futureDate));        
    }

    private static int CheckWorkingDays(DateTime dateNow, DateTime futureDate)
    {
        int count = 0;
        if (dateNow > futureDate)
        {
            DateTime swap = dateNow;
            dateNow = futureDate;
            futureDate = swap;
        }
        while (dateNow <= futureDate)
        {
            if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
            {
                count++;
            }
            dateNow = dateNow.AddDays(1);
        }
        return count;
    }


}


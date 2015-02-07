//A beer time is after 1:00 PM and before 3:00 AM..Write a program that enters a time in format “hh:mm tt” 
//(an hour in range [01...12], a minute in range [00…59] and AM / PM designator) 
//and prints beer time or non-beer time according to the definition above or invalid time 
//if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

using System;
using System.Globalization;
using System.Threading;

class BeerTime
{
    static void Main()
    {
        Console.WriteLine("Please enter a time in format <hh:mm tt> :");
        string format = "hh:mm tt";
        string input = Console.ReadLine();
        DateTime dateTime;
        bool check = DateTime.TryParseExact(input, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
        if (check)
        {
            if (dateTime.Hour >= 13 || dateTime.Hour <= 3)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non beer");
            }
        }

    }
}


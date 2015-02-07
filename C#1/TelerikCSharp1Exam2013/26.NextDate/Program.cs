using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        int month = int.Parse(Console.ReadLine());
        int year = int.Parse(Console.ReadLine());
        DateTime date = new DateTime ( year,month,day );
        DateTime newDate = date.AddDays(1);
        Console.Write(newDate.Day + ".");
        Console.Write(newDate.Month + ".");
        Console.Write(newDate.Year);
        Console.WriteLine();
    }
}


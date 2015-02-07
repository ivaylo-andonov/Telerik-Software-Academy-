using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.WriteLine("Enter your birth date (dd.mm.yyyy) : ");
        DateTime Birthday = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        int age = today.Year - Birthday.Year;

        if (today.Month <= Birthday.Month)
        {
            if (today.Day < Birthday.Day)
            {
                age--;
            }
        }
        Console.WriteLine("You are {0} years old ", age);
        Console.WriteLine("After 10 years you will be {0}", age + 10);

    }
}


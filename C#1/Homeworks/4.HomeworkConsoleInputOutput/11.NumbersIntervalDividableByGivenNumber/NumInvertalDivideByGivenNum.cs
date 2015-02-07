//Write a program that reads two positive integer numbers and prints how many numbers 
//p exist between them such that the reminder of the division by 5 is 0.

using System;

class IntervalDividableByFive
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        Console.Write("Numbers: ");
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                Console.Write(i + ", ");
             }
         }
        if (count > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Count: " + count);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("-");
        }
        
    }
}


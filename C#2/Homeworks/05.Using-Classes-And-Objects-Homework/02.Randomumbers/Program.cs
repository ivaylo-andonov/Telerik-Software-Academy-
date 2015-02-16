//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class Program
{
    static void Main()
    {
        Random rnd = new Random();
        Console.WriteLine("10 different random numbers in range[100,200]:\n");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(rnd.Next(100,201) + " "); 
        }
        Console.WriteLine();
    }
}


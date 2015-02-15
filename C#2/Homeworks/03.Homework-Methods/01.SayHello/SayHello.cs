//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
using System;

class SayHello
{
    static void Main()
    {
        string yourName = Console.ReadLine();

        SayMyName(yourName);
    }
    private static void SayMyName(string name)
    {
        Console.WriteLine("\nHello {0}!",name);
    }
}


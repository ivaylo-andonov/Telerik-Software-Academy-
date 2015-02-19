//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	output
//sample	elpmas

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter some string:");
        string input = Console.ReadLine();
        char[] text = input.ToCharArray();
        Console.WriteLine("\nReversed: {0}",string.Join("",text.Reverse()));
    }
}


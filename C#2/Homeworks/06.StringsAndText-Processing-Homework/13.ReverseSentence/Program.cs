//Write a program that reverses the words in given sentence.
//Example:

//input	output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Linq;

class Program
{
    static void Main()    
    {
        Console.WriteLine("The normal text:\n");
        string input = Console.ReadLine();
        char sign = input[input.Length - 1];
        input = input.Remove(input.Length - 1, 1);

        string[] text = input.Split(' ');
               
        var reversed = text.Reverse();
        Console.WriteLine("\nReversed:\n{0}{1}",string.Join(" ",reversed),sign);
    }
}


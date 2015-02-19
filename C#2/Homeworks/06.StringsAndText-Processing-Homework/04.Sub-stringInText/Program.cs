//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:
//The target sub-string is "in"

//The text is as follows:
//We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter some text:\n");
        string input = Console.ReadLine();
        Console.WriteLine("Enter needed part from the text:\n");
        string subString = Console.ReadLine();
        int count = 0;

        for (int i = 0; i < input.Length - (subString.Length - 1); i++)
        {
            if (input.Substring(i,subString.Length).Equals(subString))
            {
                count++;
            }
        }
        Console.WriteLine("\nThe part {0} is founded {1} times in the text.",subString,count);

    }
}


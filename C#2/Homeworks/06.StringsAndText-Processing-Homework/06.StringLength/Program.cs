//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input:");
        string input = Console.ReadLine();
        string result = "";
        for (int i = 0; i < input.Length; i++)
        {
            if (i >= 20)
            {
                result += "*";
            }
            else
            {
                result += input[i];  
            } 
        }
        Console.WriteLine("\nResult:\n{0}",result);

        //SECOND WAY
        //Console.Write("Enter string: ");
        //string s = Console.ReadLine();
        //s = s.PadRight(20, '*');
        //Console.WriteLine("String filled with '*' to 20 pos is: {0}", s);
    }
}


//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the expression:\n");
        string input = Console.ReadLine();
        int countLeftBracket = 0;
        int countRightBracket = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                countLeftBracket++;
            }
            if (input[i] == ')')
            {
                countRightBracket++;
            }
        }
        Console.Write("Are the brackets put correctly? ");
        Console.WriteLine(countRightBracket != countLeftBracket ? "false" : "true");
       
        
        
    }
}


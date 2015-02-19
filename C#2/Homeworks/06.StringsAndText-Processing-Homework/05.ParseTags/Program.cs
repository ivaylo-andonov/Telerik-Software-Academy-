//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text:");
        string input = Console.ReadLine();
        StringBuilder upperCase = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '<')
            {
                i += 8;
                while (input[i] != '<')
                {
                    upperCase.Append(input[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                upperCase.Append(input[i]);
            }
        }
        Console.WriteLine("\nYour expected result:");
        Console.WriteLine(upperCase.ToString());
    }
}


//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: "in"

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string input = Console.ReadLine();
        Console.WriteLine("\nEnter a word from the text:");
        string substring = Console.ReadLine();
        string word = substring + " ";

        StringBuilder result = new StringBuilder();

        string[] text = input.Split('.');
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains(word))
            {
                result.Append(text[i] + ".");
            }
        }
        Console.WriteLine("\nThe result is:\n{0}",result.ToString());
        Console.WriteLine();
    }
}


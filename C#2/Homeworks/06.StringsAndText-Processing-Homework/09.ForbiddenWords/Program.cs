//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.
//Example text: Microsoft announced its next generation PHP compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//Forbidden words: PHP, CLR, Microsoft

//The expected result: ********* announced its next generation *** compiler today. 
//It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a text:");
        string text = Console.ReadLine();
        Console.WriteLine("\nEnter the forbidden words separeted by comma:");
        string[] forbiddenWords = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        bool isForbWOrd = false;

        string[] wordsOfText = text.Split(' ','.');
        for (int i = 0; i < wordsOfText.Length; i++)
        {
            for (int j = 0; j < forbiddenWords.Length; j++)
            {
                if (wordsOfText[i] == forbiddenWords[j])
                {
                    isForbWOrd = true;
                }               
            }
            if (isForbWOrd == true)
            {
                result.Append(new string('*',wordsOfText[i].Length) + " ");
            }
            else
            {
                result.Append(wordsOfText[i] + " ");
            }
            isForbWOrd = false;
        }
        Console.WriteLine("The result is:\n{0}",result.ToString());

    }
}


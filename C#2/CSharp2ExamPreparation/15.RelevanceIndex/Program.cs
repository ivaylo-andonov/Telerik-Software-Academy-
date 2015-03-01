using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string searchedWord = Console.ReadLine();
        int numberOfParagraphs = int.Parse(Console.ReadLine());

        string[] paragraphs = new string[numberOfParagraphs];
        Dictionary<string, int> result = new Dictionary<string, int>();
        int counter = 0;

        for (int i = 0; i < numberOfParagraphs; i++)
        {
            paragraphs[i] = Console.ReadLine();
        }

        for (int i = 0; i < paragraphs.Length; i++)
        {
            string[] paragraphsWords = paragraphs[i].Split(new char[] { ' ', ',', '.', '(', ')', ';', '-', '!', '?' },
                                                                                StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < paragraphsWords.Length; j++)
            {
                if (string.Equals(paragraphsWords[j], searchedWord, StringComparison.CurrentCultureIgnoreCase))
                {
                    paragraphsWords[j] = paragraphsWords[j].ToUpper();
                    counter++;
                }
            }
            result.Add(string.Join(" ", paragraphsWords), counter);
            counter = 0;
        }

        var newresult = result.OrderByDescending(x => x.Value).ToDictionary(t => t.Key, t => t.Value);

        Console.WriteLine(string.Join("\n", newresult.Keys));
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        
        var builder = new StringBuilder();
        var words = new List<string>();

        for (int i= 0; i < number; i++)
        {
            string word = Console.ReadLine();
            words.Add(word);
        }
        // Reorder
        for (int i = 0; i < words.Count; i++)
        {
            string currentWord = words[i];                    // Current word
            int nextPos = currentWord.Length % (number + 1);  // New position
            words[i] = null;                                 // Mark which one word has to be removed after inserts
            words.Insert(nextPos, currentWord);             // Insert the word into new position, now we have null for the same word but on the old position
            words.Remove(null);                           // Delete the word on the old position,marked like null
            
        }

        //  Check which word has max length
        int maxLenghtWord = 0;
        maxLenghtWord = words.Max(x => x.Length);

        // Print each first letter from each word and add it to result,after that each second letter from each word ...
        for (int i = 0; i < maxLenghtWord; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                // create a string current word,because to separate each word into separeted letters and add them to serult one by one
                string currentWord = words[j];
                if (i < currentWord.Length)
                {
                    builder.Append(currentWord[i]);
                }
                
            }
        }
        Console.WriteLine(builder.ToString());

    }
}


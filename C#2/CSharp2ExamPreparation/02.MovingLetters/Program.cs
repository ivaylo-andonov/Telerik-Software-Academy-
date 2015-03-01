using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] inputWords = Console.ReadLine().Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
        StringBuilder strangePiecesWords = new StringBuilder();
        int maxWordLength = 0;

        for (int i = 0; i < inputWords.Length; i++)
		{
			if (maxWordLength < inputWords[i].Length)
            {
		        maxWordLength = inputWords[i].Length;
            }
		}
        for (int i = 0; i < maxWordLength; i++)
        {
            for (int j = 0; j < inputWords.Length; j++)
            {
                string currentWord = inputWords[j];

                if (i < currentWord.Length)
                {
                    int lastLetter = currentWord.Length - i - 1;
                    strangePiecesWords.Append(currentWord[lastLetter]);
                }                               
            } 
        }

        for (int i = 0; i < strangePiecesWords.Length; i++)
        {
            char currentSymbol = strangePiecesWords[i];
            int position = char.ToLower(currentSymbol) - 'a' + 1;
            int nextPosition = (i + position) % strangePiecesWords.Length;
            strangePiecesWords.Remove(i, 1);
            strangePiecesWords.Insert(nextPosition, currentSymbol);
        }
        Console.WriteLine(strangePiecesWords);
    }
}


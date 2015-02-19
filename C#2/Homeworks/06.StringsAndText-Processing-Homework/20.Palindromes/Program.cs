//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Linq;

class Program
{    
    static void Main()
    {
        Console.WriteLine("Enter different words:\n");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ',', ' ', '.', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        int counter = 0;
        foreach (var word in words)
        {
            if (IsPalindrome(word))
            {
                Console.WriteLine(" - " + word);
                counter++;
            }
        }
        Console.WriteLine(counter == 0? "There aren`t palindromes in the text!" : "Those are the palindromes from the text" );

    }
    static bool IsPalindrome(string word)
    {
        return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
    }
}


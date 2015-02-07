/*Problem 12. Index of letters
Write a program that creates an array containing all letters from the alphabet (A-Z). 
Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class Program
{
    static void Main()
    {
        int[] letters = new int[26];
        for (char i = 'A'; i <= 'Z'; i++)
        {
            letters[i - 65] = i;
        }
        Console.Write("Enter a word with general letters(A-Z): ");
        string word = Console.ReadLine();

        foreach (var letter in word)
        {
            Console.WriteLine("Letter '{0}' - index in alphabet => {1,2} and ASCII code => {2}",letter,Array.IndexOf(letters,letter),(int)letter);
        }
    }
}


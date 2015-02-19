//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the 
//string with the first of the key, the second – with the second, etc. When the last key character is reached,
//the next is the first.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Toy can change the example below ( text or key)
        string text = "Hey,how is the best student in Telerik Academy?";
        string key = "key";
        char[] charArr = text.ToCharArray();
       
        for (int i = 0; i < charArr.Length; i++)
        {
            int letterOfKey = i % key.Length;
            charArr[i] ^= key[letterOfKey]; 
            
        }

        Console.WriteLine("Encoded :\n");
        text = new string(charArr);
        Console.WriteLine(text);
        
        
    }
}


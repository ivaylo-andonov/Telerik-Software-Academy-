//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	output
//.NET	platform for applications from Microsoft
//CLR	managed execution environment for .NET
//namespace	hierarchical organization of classes

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("WORD DICTIONARY");
        Console.Write("\nCheck  for:");
        bool isExist = false;
        string input = Console.ReadLine();

        var dictionary = new Dictionary<string, string>();
        // You can add so many different dictionary words, those are examples:
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("namespace", "hierarchical organization of classes");
        dictionary.Add("C#", "a multi-paradigm programming language encompassing strong typing, imperative,functional, generic object-oriented rogramming disciplines");
        dictionary.Add("Visual Studio", "IDE mostly used by corporate programmers to produce .NET code.");
        dictionary.Add("JAVA", "is a general-purpose programming language that is concurrent,class-based,object-oriented");

        foreach (var item in dictionary)
        {
            if (item.Key == input)
            {
                Console.WriteLine("\n{0} is {1}",input,item.Value);
                isExist = true;
            }          
        }
        Console.WriteLine(isExist == false? "This word doesn`t exist in the dictionary.\nAsk Gooogle" : "");
    }
}


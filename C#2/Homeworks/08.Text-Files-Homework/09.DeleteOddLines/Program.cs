using System;
using System.Collections.Generic;
using System.IO;

class OddLines
{
    /* Write a program that deletes from given text file all odd lines. 
     * The result should be in the same file. */

    static void Main()
    {
        try
        {
            GenerateTextFile();
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot create test file");
            return;
        }
        List<string> text = new List<string>();
        try
        {
            using (StreamReader reader = new StreamReader("testfile.txt"))
            {
                while (!reader.EndOfStream)
                {
                    text.Add(reader.ReadLine());
                }
            }
            using (StreamWriter writer = new StreamWriter("testfile.txt"))
                for (int i = 1; i < text.Count; i += 2)
                    writer.WriteLine(text[i]);
            
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input file mysteriously dissapeared...");
            return;
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot read file");
            return;
        }
    }

    static void GenerateTextFile()
    {
        using (StreamWriter writer = new StreamWriter("testfile.txt"))
        for (int i = 1; i < 101; i++)
        {
            writer.WriteLine("Line number {0}", i);
        }
    }
}

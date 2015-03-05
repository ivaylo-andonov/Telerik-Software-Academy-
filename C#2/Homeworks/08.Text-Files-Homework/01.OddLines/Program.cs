//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class Program
{
    static void Main()
    {
        const string path = "../../Input.txt";

        Console.WriteLine("Prints only odd lines of text file...\n");

        using (StreamReader reader = new StreamReader(path))
        {
            int lineCount = 1;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (lineCount++ % 2 != 0) Console.WriteLine(line);
            }
        }

        
    }
}


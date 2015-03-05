//Write a program that concatenates two text files into another text file.

using System;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        string firstPath = @"..\..\concatFirst.txt";
        string secondPath = @"..\..\concatSecond.txt";
        string concatenatedPath = @"..\..\concatenatedResult.txt";

        try
        {
            string firstString = File.ReadAllText(firstPath);
            string secondString = File.ReadAllText(secondPath);

            File.WriteAllText(concatenatedPath, firstString + Environment.NewLine + secondString);

            Console.WriteLine("{0} file named {1} has been created.",
                    Path.GetExtension(concatenatedPath), Path.GetFileNameWithoutExtension(concatenatedPath));
            Console.WriteLine(Environment.NewLine + "You can find it at " + Path.GetFullPath(concatenatedPath));
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }

    }
}


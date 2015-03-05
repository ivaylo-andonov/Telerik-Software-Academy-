//Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputPath = @"..\..\input.txt";
        string outputPath = @"..\..\output.txt";

        try
        {
            using (StreamReader reader = new StreamReader(inputPath))
            {
                string currentLine;
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    while (!reader.EndOfStream)
                    {
                        currentLine = reader.ReadLine();
                        currentLine = Regex
                            .Replace(currentLine, "start", "finish", RegexOptions.IgnoreCase);

                        writer.WriteLine(currentLine);
                    }

                    Console.WriteLine("DIRECTORY: " +
                    Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

                    Console.WriteLine("A file {0} has been created with the replaced text.",
                        Path.GetFileName(outputPath));
                }
            }
        }
        catch (DirectoryNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileNotFoundException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (FileLoadException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (EndOfStreamException exception)
        {
            Console.WriteLine(exception.Message);
        }
        catch (IOException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}


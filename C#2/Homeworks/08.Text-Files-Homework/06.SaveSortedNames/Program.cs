//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	  output.txt
//Ivan        George 
//Peter       Ivan 
//Maria       Maria 
//George	  Peter

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        string inputPath = @"..\..\names.";
        string outputPath = @"..\..\outputResult.txt";

        try
        {
            List<string> names = new List<string>();

            using (StreamReader stream = new StreamReader(inputPath))
            {
                names = stream.ReadToEnd()
                    .Split('\n')
                    .Select(x => x.Trim())
                    .OrderBy(x => x)
                    .ToList();

                File.WriteAllLines(outputPath, names);

                Console.WriteLine("DIRECTORY: " +
                    Path.GetFullPath(outputPath).Replace(Path.GetFileName(outputPath), String.Empty));

                Console.WriteLine("A file {0} has been created with the sorted names.",
                    Path.GetFileName(outputPath));
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
    }
}


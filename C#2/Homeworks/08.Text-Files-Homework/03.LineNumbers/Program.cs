//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        string outputPath = @"..\..\textWithNumbers.txt";
        string inputPath = @"..\..\firstText.txt";

        try
        {
            StringBuilder result = new StringBuilder();
            using (StreamReader stream = new StreamReader(inputPath))
            {
                string line;
                int lineNumber = 1;
                while ((line = stream.ReadLine()) != null)
                {
                    if (lineNumber > 2)
                    {
                        result.AppendLine(String.Format("{0,-5:D2}{1}", lineNumber, line));
                        
                    }
                    else
                    {
                        result.AppendLine(String.Format("{0,-5}",  line));
                    }
                    ++lineNumber;
                    
                }

                if (result.Length == 0)
                {
                    result.AppendLine("Sorry, no text!");
                }

                File.WriteAllLines(outputPath, result.ToString().Split('\n'));
                Console.WriteLine("Directory: " +
                    Path.GetFullPath(inputPath)
                    .Replace(Path.GetFileName(inputPath), String.Empty));

                Console.WriteLine("File without line numbers: " +
                    Path.GetFileNameWithoutExtension(inputPath));

                Console.WriteLine("File with line numbers created: "
                    + Path.GetFileNameWithoutExtension(outputPath));
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



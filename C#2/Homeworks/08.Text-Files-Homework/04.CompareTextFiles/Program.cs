/* Write a program that compares two text files line by line and prints the 
 * number of lines that are the same and the number of lines that are different. 
 * Assume the files have equal number of lines. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
    {
        static void Main()
        {
            string firstFile = @"..\..\test1.txt";
            string secondFile = @"..\..\test2.txt";
            int equalLines = 0;
            int differentLines = 0;
            
            try
            {
                var reader1 = new StreamReader(firstFile);
                var reader2 = new StreamReader(secondFile);

                using (reader1)
                using (reader2)
                {
                    string stringOne = reader1.ReadLine();
                    string stringTwo = reader2.ReadLine();
                    while (stringOne != null)
                    {
                        if (stringOne == stringTwo)
                            equalLines++;
                        else
                            differentLines++;
                        stringOne = reader1.ReadLine();
                        stringTwo = reader2.ReadLine();
                    }
                }
                Console.WriteLine("Number of identical lines: {0}", equalLines);
                Console.WriteLine("Number of different lines: {0}", differentLines);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Cannot open test file(s)");
                return;
            }
        }
    }


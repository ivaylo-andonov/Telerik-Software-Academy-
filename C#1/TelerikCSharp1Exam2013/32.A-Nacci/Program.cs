using System;

class Program
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int numberOfLines = int.Parse(Console.ReadLine());
        char firstLetter = Convert.ToChar(a);
        char secondLetter = Convert.ToChar(b);
        int aNacciNum = ((firstLetter - 64) + (secondLetter - 64));
        if (aNacciNum > 26)
        {
            aNacciNum %= 26;
        }
        char aNacciChar = (char)(aNacciNum + 64);

        if (numberOfLines > 0)
        {
            
            if (numberOfLines == 1)
            {
                Console.WriteLine(firstLetter);
            }
            else if (numberOfLines == 2)
            {
                Console.WriteLine(a);
                Console.WriteLine("{0}{1}", secondLetter, aNacciChar);
            }
            else if (numberOfLines > 2)
            {
                Console.WriteLine(firstLetter);
                Console.WriteLine("{0}{1}", secondLetter, aNacciChar);
                int whiteSpaces = 1;
                for (int i = 0; i < numberOfLines - 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        firstLetter = secondLetter;
                        secondLetter = aNacciChar;
                        aNacciNum = ((firstLetter - 64) + (secondLetter - 64));
                        if (aNacciNum > 26)
                        {
                            aNacciNum %= 26;
                        }
                        aNacciChar = (char)(aNacciNum + 64);
                        Console.Write(aNacciChar + new string(' ', whiteSpaces));
                    }
                    whiteSpaces++;
                    Console.WriteLine();
                }
            }
        }

    }
}


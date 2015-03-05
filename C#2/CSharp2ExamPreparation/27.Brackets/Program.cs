using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

class Brackets
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string indentation = Console.ReadLine();
        string[] input = new string[n];
        for (int i = 0; i < n; i++)
        {
            var list = Console.ReadLine().Split(' ').Where(s => !string.IsNullOrWhiteSpace(s)).ToArray();
            input[i] = String.Join(" ", list);
        }
        input = input.Where(x => !string.IsNullOrEmpty(x.ToString())).ToArray();
        List<string> separatedLines = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length == 1)
            {
                separatedLines.Add(input[i]);
            }
            else
            {
                StringBuilder part = new StringBuilder();
                for (int j = 0; j < input[i].Length; j++)
                {
                    if ((input[i][j] == '{' || input[i][j] == '}'))
                    {
                        if (part.Length > 0 && !String.IsNullOrWhiteSpace(part.ToString()))
                        {
                            separatedLines.Add(part.ToString());
                            part.Clear();
                        }
                        separatedLines.Add(input[i][j].ToString());
                        continue;
                    }
                    part.Append(input[i][j]);
                }
                if (part.Length > 0 && !String.IsNullOrWhiteSpace(part.ToString()))
                {
                    separatedLines.Add(part.ToString());
                    part.Clear();
                }
            }
        }
        int level = 0;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < separatedLines.Count; i++)
        {
            separatedLines[i] = separatedLines[i].Trim();
            if (separatedLines[i] == "{")
            {
                Console.WriteLine(Indent(separatedLines[i], indentation, level));
                level++;
                continue;
            }
            if (separatedLines[i] == "}")
            {
                level--;
                Console.WriteLine(Indent(separatedLines[i], indentation, level));
                continue;
            }
            Console.WriteLine(Indent(separatedLines[i], indentation, level));
        }
    }

    private static string Indent(string line, string indentation, int level)
    {
        StringBuilder fullLine = new StringBuilder();
        for (int i = 0; i < level; i++)
        {
            fullLine.Append(indentation);
        }
        fullLine.Append(line);
        return fullLine.ToString();
    }
}
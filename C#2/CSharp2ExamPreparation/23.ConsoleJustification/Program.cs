using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int numberLines = int.Parse(Console.ReadLine());
        int symbols = int.Parse(Console.ReadLine());
        var builder = new StringBuilder();
        var resultList = new List<string>();

        //int usingSymbols = 0;
        for (int i = 0; i < numberLines; i++)
        {
            string[] words = Console.ReadLine().Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < words.Length; j++)
			{
                builder.Append(words[j]);
                builder.Append(" ");               
			}           
        }
        builder.ToString().Trim();

        for (int i = 0; i < builder.Length; i++)
        {
            var resultBuilder = new StringBuilder();
            while (resultBuilder.Length == symbols)
            {
                resultBuilder.Append(builder[i]);
            }
            resultList.Add(resultBuilder.ToString());
            resultBuilder.Clear();
        }
        Console.WriteLine(string.Join("\n",resultList));
    }
}


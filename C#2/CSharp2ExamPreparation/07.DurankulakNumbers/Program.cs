using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        const int NUMBERALBASE = 168;
        string input = Console.ReadLine();
        var list = new List<string>();
        ulong result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            string currentNum = "";

            if (char.IsLower(input[i]))
            {
                currentNum = string.Format("{0}{1}", input[i], input[i + 1]);
                list.Add(currentNum);
                i++;
            }
            else
            {
                currentNum = string.Format("{0}", input[i]);
                list.Add(currentNum);
            }
        }

        for (int i = 0; i < list.Count ; i++)
        {
            char firstChar = list[i][0];
           
            result = result * NUMBERALBASE;

            if (firstChar >= 'A' && firstChar <= 'Z')
            {
                result = result + (ulong)(firstChar - 'A');
            }
            else
            {
                char secondChar = list[i][1];
                result = result + (ulong)(((firstChar - 'a' + 1) * 26) + secondChar - 'A');
            }
        }
        Console.WriteLine(result);
    }
}



using System;
using System.Text;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder strangeNum = new StringBuilder();
        string[] strangeNUmbers = new string[7] { "f", "bIN", "oBJEC", "mNTRAVL", "lPVKNQ", "pNWE", "hT" };
        ulong result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            strangeNum.Append(input[i]);
            for (int j = 0; j < strangeNUmbers.Length; j++)
            {
                if (strangeNum.ToString() == strangeNUmbers[j])
                {
                    result *= 7;
                    result += (ulong)j;
                    strangeNum.Clear();
                }
            }
        }
        Console.WriteLine(result);        
    }
}


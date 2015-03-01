using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // Input reading
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, int> codeTable = new Dictionary<string, int>();

        int numberLines = int.Parse(Console.ReadLine());

        // Get the code table (dictionary) with characters of each line from the input
        for (int i = 0; i < numberLines; i++)
        {
            string codeLine = Console.ReadLine();

            string charackter = codeLine.Substring(0, 1);
            int count = int.Parse(codeLine.Substring(1));

            codeTable.Add(charackter, count);
        }

        // Get binary number from the input
        StringBuilder binaryNumber = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            int number = int.Parse(input[i]);
            string binary = Convert.ToString(number, 2);
            binaryNumber.Append( binary.PadLeft(8, '0'));
        }
        binaryNumber.ToString();

        // Decrypt binary numbers( check how many '1' has the binarynumber equals to codetables values and append the key to the result)
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int onesCount = 0;

            for (int j = i; j < binaryNumber.Length; j++)
            {
                if (binaryNumber[j] == '1')
                {
                    onesCount++;
                    i++;
                }
                else
                {
                    break;
                }
            }
            foreach (var code in codeTable)
            {
                if (onesCount == code.Value)
                {
                    result.Append(code.Key);
                }  
            }
        }

        // Print the result as string
        Console.WriteLine(result.ToString());
    }
}


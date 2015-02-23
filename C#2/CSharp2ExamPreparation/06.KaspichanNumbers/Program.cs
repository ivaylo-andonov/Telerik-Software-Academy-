using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        ulong numberDecimal = ulong.Parse(Console.ReadLine());
        // We can change the numeral base system here, this code is valid foreach ones
        const int NUMERALBASE = 256;
        string result = string.Empty;
        // Fill the array with 256 strings on 256-based numeral system
        string[] array = new string[NUMERALBASE];
        for (int i = 0; i < array.Length; i++)
        {
            if (i < 26)
            {
                array[i] = string.Format("{0}", (char)(i % 26 + 'A' ));
            }
            else
            {
                array[i] = string.Format("{0}{1}",(char)(i / 26-1 +'a'),(char)((i % 26)+'A'));
            }
        }
        while (numberDecimal > 0)
        {
            ulong digit = numberDecimal % NUMERALBASE;
            result = array[digit] + result;        
            numberDecimal /= NUMERALBASE;
        }
        Console.WriteLine(result);

    }
}


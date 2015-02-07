using System;
using System.Numerics;
using System.Linq;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Contains('-'))
        {
            input = input.Remove(input.IndexOf('-'), 1);
        }
        char[] inputNumber = input.ToCharArray();
        string result = "";
        long specialNumber = 0;
        long power = 1;
        Array.Reverse(inputNumber);
        for (int i = 0; i < inputNumber.Length; i++)
        {
            if (i % 2 == 0)
            {
                specialNumber += (inputNumber[i] - 48) * (power*power);
            }
            else if (i % 2 != 0)
            {
                specialNumber += (inputNumber[i] - 48) * (inputNumber[i] - 48) * power;
            }
            power++;
        }
        long R = (specialNumber % 26) + 1;
        char letter = (char)(64 + R);
        int lastDigit = (int)specialNumber % 10;
        for (int i = 0; i < lastDigit; i++)
        {
            result += letter;
            if (letter == 'Z')
            {
                letter = '@';
            }
            letter++;
        }
        if ( specialNumber % 10 == 0)
        {
            Console.WriteLine(specialNumber);
            Console.WriteLine("{0} has no secret alpha-sequence", string.Join(string.Empty, input));
        }
        else
        {
            Console.WriteLine(specialNumber);
            Console.WriteLine(result);
        }
    }
}


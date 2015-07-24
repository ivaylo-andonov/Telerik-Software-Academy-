using System;

class Program
{
    static void Main()
    {
        //Console.Write("Enter M: ");
        int num = int.Parse(Console.ReadLine());
        //Console.Write("Enter string: ");
        string inputString = Console.ReadLine();

        int result = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == '@')
            {
                break;
            }

            if (inputString[i] > 47 && inputString[i] < 58)
            {
                result *= (inputString[i] - 48);
                continue;
            }

            if (inputString[i] > 64 && inputString[i] < 91 )
            {
                result += (inputString[i] - 65);
                continue;
            }

            if (inputString[i] > 96 && inputString[i] < 123 )
            {
                result += (inputString[i] - 97);
                continue;
            }

            result %= num;

        }
        Console.WriteLine(result);
    }
}
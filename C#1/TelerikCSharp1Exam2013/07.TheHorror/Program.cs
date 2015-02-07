using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        long sum = 0;
        int count = 0;
        int digit = 0;
        for (int i = 0; i < input.Length; i++)
        {
            bool check = int.TryParse(input[i].ToString(), out digit);
            if (i % 2 == 0 && check)
            {
                count++;
                sum += digit;
            }
        }Console.WriteLine("{0} {1}", count,sum);
    }
}


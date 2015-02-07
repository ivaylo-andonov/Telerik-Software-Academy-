using System;

class Program
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        long sum = 0;
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            bool check = char.IsDigit(input[i]);
            if (i % 2 != 0 && check)
            {
                count++;
                sum += input[i];
            }
        } Console.Write("{0} {1}", count, sum);
        Console.WriteLine();
    }
}


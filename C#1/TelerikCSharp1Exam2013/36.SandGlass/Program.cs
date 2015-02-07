using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int asterisks = n;
        int asterisksCount = 2;
        int dots = 0;
        int dotsCount = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('.', dots) + new string('*', asterisks) + new string('.', dots));
            asterisks -= asterisksCount;
            dots += dotsCount;
            if (asterisks ==-1)
            {
                asterisks = 3;
                dots = n / 2 - 1;
                asterisksCount *= -1;
                dotsCount *= -1;
            }
        }
    }
}


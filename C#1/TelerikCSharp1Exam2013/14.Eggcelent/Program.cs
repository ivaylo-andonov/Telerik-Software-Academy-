using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1));
        int upOuterDOts = n - 1;
        int upInnerDots = n + 1;
        for (int i = 0; i < n - 2; i++)
        {
            if (upOuterDOts < 1)
            {
                upOuterDOts = 1;
                Console.WriteLine(".*" + new string('.', n * 3 - 3) + "*.");
            }
            else
            {
                Console.WriteLine(new string('.', upOuterDOts) + '*' + new string('.', upInnerDots) + '*' + new string('.', upOuterDOts));
            }

            upOuterDOts -= 2;
            upInnerDots += 4;

        }
        Console.Write(".*");
        for (int i = 0; i < n * 3 - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('@');
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.WriteLine("*.");
        Console.Write(".*");
        for (int i = 0; i < n * 3 - 3; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('.');
            }
            else
            {
                Console.Write('@');
            }
        }
        Console.WriteLine("*.");
        int downOuterDots = 1;
        int downInnerDots = n * 3 - 3;
        for (int i = 0; i < n - 2; i++)
        {
            if (i < n / 2 - 2)
            {
                downOuterDots = 1;
                Console.WriteLine(".*" + new string('.', n * 3 - 3) + "*.");
            }
            else if (i >= n / 2 - 2)
            {
                Console.WriteLine(new string('.', downOuterDots) + '*' + new string('.', downInnerDots) + '*' + new string('.', downOuterDots));
                downInnerDots -= 4;
                downOuterDots += 2;
            }
        }
        Console.WriteLine(new string('.', n + 1) + new string('*', n - 1) + new string('.', n + 1));
    }
}


using System;

class Carpets
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dots = n / 2 - 1;
        int dotsMultiplier = 1;
        int dashes = 1;
        int dashesMultplier = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(new string('.', dots));
            for (int j = 0; j < n / 2 - dots; j++)
            {
                if (j % 2 == 0)
                {
                    Console.Write(i <= n / 2 ? '/' : '\\');
                }
                else
                {
                    Console.Write(" ");
                }
            }
            for (int j = 0; j < n/2 - dots; j++)
            {
                if (i <= n / 2)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(j % 2 == 0 ? '\\' : ' ');
                    }
                    else
                    {
                        Console.Write(j % 2 != 0 ? '\\' : ' ');
                    }
                }
                else if (i > n / 2)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(j % 2 == 0 ? '/' : ' ');
                    }
                    else
                    {
                        Console.Write(j % 2 == 0 ? ' ' : '/');
                    }
                }
            }
            Console.WriteLine(new string('.', dots));
            dots -= dotsMultiplier;
            dashes += dashesMultplier;

            if (dots == -1)
            {
                dots = 0;
                dashes = n / 2;
                dotsMultiplier *= -1;
                dashesMultplier *= -1;
            }
        }
    }
}



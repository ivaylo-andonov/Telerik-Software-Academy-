using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dotsEnd = n / 2;
        int length = 3 * n - 2;
        int dotsSide = 1;

        Console.WriteLine(new string('.', dotsEnd) + '*' + new string('.', length - (2 + 2 * dotsEnd)) + '*' + new string('.', dotsEnd));
        for (int i = 0; i < n - 2; i++)
        {
            dotsEnd--;

            if (dotsEnd < 0)
            {
                int middle = length - (2 + 2 * dotsSide);
                Console.WriteLine(new string('.', dotsSide) + '*' +
                 new string('.', middle) + '*' +
                     new string('.', dotsSide));
                dotsSide += 1;
                middle -= 2;
            }
            else
            {
                int middle = length - (4 + 2 * dotsEnd + 2 * dotsSide);
                Console.WriteLine(new string('.', dotsEnd) + '*' + new string('.', dotsSide) + '*' +
                new string('.', middle) + '*' +
                    new string('.', dotsSide) + '*' + new string('.', dotsEnd));
                middle -= 2;
                dotsSide += 2;
            }
        }
        Console.WriteLine(new string('.', length / 2) + '*' + new string('.', length / 2));

        int sideDots = length / 2 - 1;
        int sideDotsMultiplier = 1;
        int middleDots = 1;
        int middleDotsMultiplier = 2;

        for (int i = 0; i < n * 2 - 2; i++)
        {
            if (middleDots > 0)
            {
                Console.Write(new string('.', sideDots) + '*');
                for (int j = 0; j < middleDots; j++)
                {
                    Console.Write('.');
                }
                Console.WriteLine('*' + new string('.', sideDots));
                sideDots -= sideDotsMultiplier;
                middleDots += middleDotsMultiplier;
                if (sideDots == n / 2)
                {
                    sideDotsMultiplier = -1;
                    middleDotsMultiplier = -2;
                }
            }
            else if (middleDots <= 0)
            {
                Console.WriteLine(new string('.', sideDots) + '*' + new string('.', sideDots));
            }
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', n / 2 + 1) + new string('*',n) + new string('.',n/ 2 + 1));
        int outerDots = n / 2;
        int innerDots = n / 2;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', outerDots) + '*' + new string('.', innerDots) + '*' +
                              new string('.', innerDots) + '*' + new string('.', outerDots));
            outerDots--;
            innerDots++;
        }
        Console.WriteLine(new string('*', n * 2 + 1));
        int outerDownDOts = 1;
        int innerDownDots = n - 2;
        for (int i = 0; i < n - 1; i++)
        {
            Console.WriteLine(new string('.', outerDownDOts) + '*' + new string('.', innerDownDots) + '*' +
                              new string('.', innerDownDots) + '*' + new string('.', outerDownDOts));
            outerDownDOts++;
            innerDownDots--;
        }
        Console.WriteLine(new string('.',n) + '*' + new string('.',n));
    }
}


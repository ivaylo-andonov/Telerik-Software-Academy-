using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', i) + '\\' + new string('.', n / 2 - 1 - i) + '|' +
                             new string('.', n / 2 - 1 - i) + '/' + new string('.', i));
        }
        Console.WriteLine(new string('-', n / 2) + '*' + new string('-', n / 2));
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', n / 2 - 1 - i) + '/' + new string('.', i) + '|' +
                              new string('.', i) + '\\' + new string('.', n / 2 - 1- i));
        }
    }
}



using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('.', n) + "*" + new string('.', n));
        int dots = 0;
        for (int i = 0; i < n - 1; i++)
        {
            
            Console.WriteLine(new string('.', (n - 1) - 1 * i) + '*' + new string('.', dots) + '*'
                              + new string('.', dots) + '*' + new string('.', (n - 1) - 1 * i));
            dots++;
        }
        Console.WriteLine(new string('*', n * 2 + 1));
        int dots2 = 1;
        for (int i = 0; i < n / 2; i++)
        {
            Console.WriteLine(new string('.', dots2) + '*' + new string('.', (n - 2)-1*i) + '*' 
                             + new string('.', (n - 2)- 1*i) + '*' + new string('.', dots2));
            dots2++;
        }
        Console.WriteLine(new string('.', n / 2 + 1) + new string('*', n) + new string('.', n / 2 + 1));
    }
}


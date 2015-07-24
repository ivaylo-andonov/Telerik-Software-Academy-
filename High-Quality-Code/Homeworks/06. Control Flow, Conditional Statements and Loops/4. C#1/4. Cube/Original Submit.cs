using System;

class Cube
{
    static void Main()
    {        
        int n = int.Parse(Console.ReadLine());

        char line = ':';
        char top = '/';
        char side = 'X';
        char front = ' ';

        Console.WriteLine(new string(' ', n-1) + new string(line, n));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string(' ', n -2- i) + line + new string(top,n-2) + line + new string(side,i) + line);
        }

        Console.WriteLine(new string(line,n) + new string(side,n-2) + line);

        for (int i = 0; i < n-2; i++)
        {
            Console.Write(line + new string(front, n - 2) + line);
            Console.WriteLine(new string(side,n-3-i) + line);
        }

        Console.WriteLine(new string(line,n));
    }
}
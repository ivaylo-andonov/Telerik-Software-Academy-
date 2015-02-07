using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0,rowDash = 1,step = 2; i < n; i++)
        {
            Console.Write(new string('.', (n - 1) - i) + '/');
            if (i == rowDash)
            {
                Console.Write(new string('-',i*2));
                rowDash += step;
                step++;
            }
            else
            {
                Console.Write(new string('.', i*2));
            }
            Console.WriteLine('\\' + new string('.', (n - 1) - i));
        }
    }
}


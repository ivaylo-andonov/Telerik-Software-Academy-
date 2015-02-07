using System;

class Program
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());

        int min = Math.Min(A,(Math.Min(B,C)));
        int max = Math.Max(A, (Math.Max(B, C)));
        double averige = (A + B + C) / 3.0;
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine("{0:F2}",averige);
    }
}


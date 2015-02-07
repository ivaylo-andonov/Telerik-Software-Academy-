using System;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        long numberOfLines = long.Parse(Console.ReadLine());

        long nextTribonacciNum = a + b + c;
        long thirdLineDigits = 3;
        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b + " " + c);
        for (long i = 0; i < numberOfLines - 2; i++)
        {
           
            for (long j = 0; j < thirdLineDigits; j++)
            {
                Console.Write(nextTribonacciNum + " ");
                a = b;
                b = c;
                c = nextTribonacciNum;
                nextTribonacciNum = a + b + c;

            }
            thirdLineDigits++;
            Console.WriteLine();
        }
    }
}


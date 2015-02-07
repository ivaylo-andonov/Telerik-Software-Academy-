using System;

class Program
{
    static void Main()
    {
        long A = long.Parse(Console.ReadLine());
        long B = long.Parse(Console.ReadLine());
        long C = long.Parse(Console.ReadLine()); 
        long D = long.Parse(Console.ReadLine());

        long nominator = A * D + B * C;
        long dominator = B * D;

        decimal result = (decimal)nominator / dominator;
        if (result < 1)
        {
            Console.WriteLine("{0:F22}", result);
            Console.WriteLine("{0}/{1}", nominator, dominator);
        }
        else
        {
            Console.WriteLine((int)result);
            Console.WriteLine("{0}/{1}", nominator, dominator);
        }

    }
}


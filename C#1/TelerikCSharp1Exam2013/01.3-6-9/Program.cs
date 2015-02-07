using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        long result = 0;

        if (b == 3)
        {
            result = a + c;
            if (result % 3 == 0)
            {
                Console.WriteLine("{0}\n{1}", result / 3, result);
            }
            else
            {
                Console.WriteLine("{0}\n{1}", result % 3, result);
            }
        }
        else if (b == 6)
        {
            result =(long)a * c;
            if (result % 3 == 0)
            {
                Console.WriteLine("{0}\n{1}", result / 3, result);
            }
            else
            {
                Console.WriteLine("{0}\n{1}", result % 3, result);
            }
        }
        else if (b == 9)
        {
            result = a % c;
            if (result % 3 == 0)
            {
                Console.WriteLine("{0}\n{1}", result / 3, result);
            }
            else
            {
                Console.WriteLine("{0}\n{1}", result % 3, result);
            }
        }
    }
}


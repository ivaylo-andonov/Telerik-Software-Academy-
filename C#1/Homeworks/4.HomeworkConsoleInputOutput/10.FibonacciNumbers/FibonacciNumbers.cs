//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

using System;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int c;

        if (n >= 3)
        {
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < n - 2; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(c + " ");
            }
        }
        else if (n == 2)
        {
            Console.WriteLine(a+ " "+b);
        }
        else if (n ==1)
        {
            Console.WriteLine(a);
        }
        
        
    }
}


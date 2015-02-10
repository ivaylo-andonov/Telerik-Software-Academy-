//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
//Example:
//N	K	result
//5	2	{1, 2} 
//      {1, 3} 
//      {1, 4} 
//      {1, 5} 
//      {2, 3} 
//      {2, 4} 
//      {2, 5} 
//      {3, 4} 
//      {3, 5} 
//      {4, 5}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int[] result;
    static int k;
    static int n;

    static void Main()
    {
        Console.WriteLine("Enter number N:");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K:");
        k = int.Parse(Console.ReadLine());
        Console.WriteLine("Combinations:\n");

        result = new int[k];

        Combine(0, 1);
    }

    static void Combine(int index, int startValue)
    {
        if (index == k)
        {
            for (int i = 0; i < k; i++)
                Console.Write("{0,3}", result[i]);
            Console.WriteLine();
            return;
        }
        for (int i = startValue; i <= n; i++)
        {
            result[index] = i;
            Combine(index + 1, i + 1);
        }
    }
}


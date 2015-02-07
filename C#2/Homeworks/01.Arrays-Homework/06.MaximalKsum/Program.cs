//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array,and after that the elements:");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];      
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter number of elements to sum (elements from the array) :");
        int K = int.Parse(Console.ReadLine());
        
        if (K > N)
        {
            Console.WriteLine("The array must contains more elements than {0}\nPlease try again.\n",K);
        }
        array = array.OrderByDescending(x => x).ToArray();
        int sum = array.Take(K).Sum();
        Console.WriteLine("The maximal sum of {0} numbers in the array is {1}",K,sum);
        Console.WriteLine();
    }
}


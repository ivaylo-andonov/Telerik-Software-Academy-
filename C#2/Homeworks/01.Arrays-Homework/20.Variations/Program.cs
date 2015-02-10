//Problem 20.* Variations of set
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
// N:  K:	result:
// 3   2    {1, 1} 
//          {1, 2} 
//          {1, 3} 
//          {2, 1} 
//          {2, 2} 
//          {2, 3} 
//          {3, 1} 
//          {3, 2} 
//          {3, 3}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        int N = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number K:");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine("Permutatons:\n");

        int[] array = new int[N];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        Variations(array, new int[K], 0);

    }

    private static void Variations(int[] numbers, int[] array, int index)
    {
        if (index == array.Length)
        {
            Console.WriteLine(string.Join(", ",array));
            return;
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            array[index] = numbers[i];
            Variations(numbers,array ,index+1);
        }
    }
}


//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
//Example:
//    N:        result:
//    3	        {1, 2, 3} 
//              {1, 3, 2} 
//              {2, 1, 3} 
//              {2, 3, 1} 
//              {3, 1, 2} 
//              {3, 2, 1}

using System;
using System.Linq;

class Permutaion
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        Console.WriteLine();
        Permutation(arr,0);
    }

    private static void Permutation(int[] array, int index)
    {
        if (index == array.Length)
        {
            Console.WriteLine(string.Join(", ",array));
            return;
        }
        for (int i = index; i < array.Length; i++)
        {
            Swap(array, i, index);
            Permutation(array, index + 1);
            Swap(array, i, index);
        }
    }
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
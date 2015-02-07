//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
//find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
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

        array = SelectionSort(array);
        Console.WriteLine("{" + string.Join(", ", array) + "}");

    }
    private static int[] SelectionSort(int[] unsortedArray)
    {
        int[] sortedNumbers = new int[unsortedArray.Length];

        for (int i = 0; i < sortedNumbers.Length; i++)
        {
            int sortedIndex = Array.IndexOf(unsortedArray, unsortedArray.Min());
            sortedNumbers[i] = unsortedArray[sortedIndex];
            unsortedArray[sortedIndex] = int.MaxValue;
        }
        return sortedNumbers;
    }
}


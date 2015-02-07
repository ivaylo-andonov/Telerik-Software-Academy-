/*Problem 13.* Merge sort
Write a program that sorts an array of integers using the Merge sort algorithm (find it in Wikipedia).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array separeted by comma:\n");
        int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' },
                      StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        int[] tmp = new int[array.Length];

        Console.WriteLine("\nBefore sorting: {0}", string.Join(" ", array)); 

        MergeSort(array, tmp, 0, array.Length - 1);

        Console.WriteLine("\nAfter sorting: {0}\n", string.Join(" ", array)); 
    }

    static void MergeSort(int[] elements, int[] temp, int start, int end)
    {
        if (start >= end) return;  // Array with 1 element

        int middle = (start + end) / 2; // Define a middle of the array

        MergeSort(elements, temp, start, middle);
        MergeSort(elements, temp, middle + 1, end);

        CompareAndSort(elements, temp, start, middle, end);
    }

    static void CompareAndSort(int[] elements, int[] temp, int start, int middle, int end)
    {
        int i = start; // 'temp' index
        int l = start, m = middle + 1; // 'elements' indexes

        while (l <= middle && m <= end)
            temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];

        while (l <= middle) temp[i++] = elements[l++];

        while (m <= end) temp[i++] = elements[m++];

        for (int j = start; j <= end; j++) elements[j] = temp[j];
    }
    
}


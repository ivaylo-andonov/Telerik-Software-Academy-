using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter different strings separeted by comma or space:\n");
        string[] arrayStrings = Console.ReadLine().Split(',',' ');
                      
        Console.WriteLine("Before sorting: {0}", string.Join(", ", arrayStrings));

        QuickSort(arrayStrings, 0, arrayStrings.Length - 1);

        Console.WriteLine("After sorting: {0}", string.Join(", ", arrayStrings));
    }

    static void QuickSort(string[] elements, int left, int right)
    {
        if (left >= right) return; // Array with 1 element

        int leftPointer = left, rightPointer = right;

        string pivot = elements[(left + right) / 2];

        while (leftPointer <= rightPointer)
        {
            while (String.Compare(elements[leftPointer], pivot, StringComparison.Ordinal) < 0) leftPointer++;

            while (String.Compare(elements[rightPointer], pivot, StringComparison.Ordinal) > 0) rightPointer--;

            if (leftPointer <= rightPointer)
            {
                string swap = elements[leftPointer];
                elements[leftPointer] = elements[rightPointer];
                elements[rightPointer] = swap;

                leftPointer++; rightPointer--;
            }
        }
        if (left < rightPointer) QuickSort(elements, left, rightPointer);
        if (leftPointer < right) QuickSort(elements, leftPointer, right);
    }
}


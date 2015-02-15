//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma or space:");
        int[] array = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("\nEnter starting index:");
        int index = int.Parse(Console.ReadLine());

        Console.Write("Enter 'A' for ascending or 'D' for descending sorting: ");
        string answer = Console.ReadLine().ToUpper();
        bool ascending = answer == "A";

        Sorting(array, ascending);

        Console.WriteLine("\nSorted array:");
        Print(array);

              
    }

    public static int MaximalElement(int[] someArray , int startIndex,int endIndex)
    {
        int max = startIndex;
        if (startIndex > someArray.Length -1)
        {
            Console.WriteLine("Invalid index!");
            return 0;
        }
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (someArray[i] > someArray[max])
            {
                max = i;
            }
        }
        return max;
    }

    static void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    static void Sorting(int[] someArray, bool ascending)
    {
        if (ascending)
        {
            for (int i = someArray.Length - 1; i >= 0; i--)
            {
                Swap( someArray,i, MaximalElement(someArray,0,i));
            }
        }
        else
        {
            for (int i = 0; i < someArray.Length; i++)
            {
                Swap(someArray, i, MaximalElement(someArray, i, someArray.Length - 1));
            }
        }
    }

    private static void Print(int[] someArray)
    {
        foreach (var number in someArray)
        {
            Console.Write(number + " ");
        }
    }
}


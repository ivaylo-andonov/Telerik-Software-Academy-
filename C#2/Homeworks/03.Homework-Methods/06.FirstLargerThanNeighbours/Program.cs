//Write a method that returns the index of the first element in array that is larger than 
//its neighbours, or -1, if there’s no such element.Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma or space to create an array:");
        int[] array = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(x => int.Parse(x)).ToArray();

        Console.WriteLine("\nThe index of first larger number than neighbours is {0}", FirstLargerThanNeighbours(array));
    }
    private static int FirstLargerThanNeighbours(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                index = i;
                break;
            }
        } return index;
    }
}


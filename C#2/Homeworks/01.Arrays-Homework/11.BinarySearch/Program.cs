//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma:\n");
        int[] array = Console.ReadLine().Split(new char[] { ' ', ',', '\t' },
                      StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        Console.WriteLine("Enter the given integer:");
        int givenInteger = int.Parse(Console.ReadLine());

        Array.Sort(array);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(i == array.Length? array[i] + ", " : array[i] + " ");
        }
        Console.WriteLine("\n" + new string('-',20));

        if (!array.Contains(givenInteger))
        {
            Console.WriteLine("Number {0} not found !",givenInteger);
        }
        int rightIndex = BinarySearch(array, givenInteger, 0, array.Length);
        Console.WriteLine("The number {0} has index {1} in the array.",givenInteger,rightIndex);

    }
    private static int BinarySearch( int[] someArray, int number, int start, int end)
    {
        if (end < start)
        {
            return -1;
        }
        else
        {
            int middleIndex = (start + end) / 2;
            if (someArray[middleIndex] > number)
            {
                return BinarySearch(someArray, number, start, middleIndex - 1);
            }
            else if (someArray[middleIndex] < number)
            {
                return BinarySearch( someArray,number ,middleIndex + 1 , end );
            }
            else
	        {
                return middleIndex;
	        }
        }

        // BASIC WAY TO FIND SOME INDEX:

        //for (int i = 0; i < array.Length; i++)
        //{
        //    if (array[i].Equals(givenInteger))
        //    {
        //        Console.WriteLine("The index of {0} is ( {1} )",givenInteger,Array.IndexOf(array,array[i]));
        //    }
        //}

    }
}


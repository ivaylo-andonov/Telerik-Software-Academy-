//Write a method that checks if the element at given position in given array
//of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma or space to create an array:");
        int[] array = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("\nEnter a position of the array:");
        int position = int.Parse(Console.ReadLine());

        IsLargerThanNeighbours(array, position);

    }
    private static void IsLargerThanNeighbours(int[] array, int position)
    {
        bool isLarger = false;
        bool check = position > 0 && position < array.Length;
        if (position == 0)
        {
            isLarger =  array[0] > array[1] ? true : false;
        }
        else if (position == array.Length-1)
        {
            isLarger = array[position] > array[position - 1] ? true : false;
        }
        else if (array[position] > array[position - 1] && array[position] > array[position + 1] && check )
        {
            isLarger = true;
        }
        Console.WriteLine("\nIs number {0} larger than its neighbours in the array?\n-{1}", array[position], isLarger);
    }
}


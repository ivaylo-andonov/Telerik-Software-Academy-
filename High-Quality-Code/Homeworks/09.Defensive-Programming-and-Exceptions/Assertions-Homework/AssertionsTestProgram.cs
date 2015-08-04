namespace Assertions_Homework
{
    using System;

    internal class AssertionsTestProgram
    {          
        public static void Main()
        {
            int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
            Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
            Algorithms.SelectionSort(arr);
            Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

            Algorithms.SelectionSort(new int[0]); // Test sorting empty array
            Algorithms.SelectionSort(new int[1]); // Test sorting single element array

            Console.WriteLine(Algorithms.BinarySearch(arr, -1000));
            Console.WriteLine(Algorithms.BinarySearch(arr, 0));
            Console.WriteLine(Algorithms.BinarySearch(arr, 17));
            Console.WriteLine(Algorithms.BinarySearch(arr, 10));
            Console.WriteLine(Algorithms.BinarySearch(arr, 1000));
        }
    }
}
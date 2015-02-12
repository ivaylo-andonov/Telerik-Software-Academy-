//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
//using System;
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Enter number N size of the array:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers of array:", n);
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter number K:");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(array);

        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }
        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
    }
}


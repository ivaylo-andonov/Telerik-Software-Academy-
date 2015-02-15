//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers separeted by comma or space:");
        int[] array = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(x => int.Parse(x)).ToArray();
        Console.WriteLine("\nEnter a number ,which we have to check how many times appear in the array:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe number {0} appear {1} times in your array.",number,AppearanceCounter(array, number));

        Console.WriteLine("\nTest program checking:");
        TestTheMethod(array);
    }

    private static void TestTheMethod(int[] array)
    {
        Random rnd = new Random();
        int counter = 0;
        int number = rnd.Next(1, 201);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        Console.WriteLine("\nThe number {0} appear {1} times in your array.", number, counter);
    }

    private static int AppearanceCounter(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}


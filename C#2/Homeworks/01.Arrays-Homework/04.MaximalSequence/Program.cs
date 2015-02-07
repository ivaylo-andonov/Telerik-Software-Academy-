//Write a program that finds the maximal sequence of equal elements in an array.
//Example:
// input:	                     |    result:
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1   |	2, 2, 2

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array,and after that the elements:");
        int numberOfLength = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfLength];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        FindMaximalSequence(array);
        
    }
    private static void FindMaximalSequence(int[] someArray)
    {
        int maximalLength = 0 ,bestElement = 0 , currentLength = 0 ,currentElement = someArray[0];
        if (someArray.Length == 1)
        {
            maximalLength = 1;
            bestElement = currentElement;
            Console.WriteLine("The maximal sequence is:\n{0}",bestElement);
            return;
        }
        for (int i = 0; i < someArray.Length; i++)
        {
            if (someArray[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                currentElement = someArray[i];
                currentLength = 1;
            }
            if (currentLength >= maximalLength)
            {
                maximalLength = currentLength;
                bestElement = currentElement;
            }
        }
        Console.Write("The maximal sequence of the array is:\n");
        Console.Write("{");
        for (int i = 0; i < maximalLength; i++)
        {
            Console.Write(i != maximalLength - 1? bestElement + ", " : bestElement + "}\n");
        }
    } 
}


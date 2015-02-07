//Write a program that finds the maximal increasing sequence in an array.

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

        FindMaximalInceasingSequence(array);
        
    }
    private static void FindMaximalInceasingSequence(int[] someArray)
    {
        int maximalLength = 0, currentLength = 0, currentElement = someArray[0], firstElement = someArray[0], 
            bestElement = someArray[0];
        if (someArray.Length == 1)
        {
            maximalLength = 1;
            firstElement = currentElement;
            Console.WriteLine("The maximal sequence is:\n{0}",firstElement);
            return;
        }
        for (int i = 0; i < someArray.Length; i++)
        {
            if (someArray[i] == currentElement)
            {
                currentElement++;
                currentLength++;
            }
            else
            {                     
                bestElement = someArray[i];
                currentElement = someArray[i];
                currentLength = 1;
                i--;

            }
            if (currentLength >= maximalLength)
            {
                maximalLength = currentLength;
                firstElement = bestElement;
            }
        }
        Console.Write("The maximal sequence of the array is:\n");
        Console.Write("{");
        for (int i = 0; i < maximalLength -1; i++)
        {
            Console.Write(i != maximalLength - 2? firstElement+ ", " :firstElement + "}\n");
            firstElement++;
        }
    } 
}
  



//Write a program that finds the maximal increasing sequence in an array.

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the length of the array:\n");
        int numberOfLength = int.Parse(Console.ReadLine());
        int[] array = new int[numberOfLength];
        Console.WriteLine("Enter {0} numbers for the array:",numberOfLength);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        FindMaximalInceasingSequence(array);
        
    }
    private static void FindMaximalInceasingSequence(int[] someArray)
    {
        int maximalLength = 0, currentLength = 0, currentElement = someArray[0], firstElement = someArray[0],bestElement = someArray[0];
        
        if (someArray.Length == 1)
        {
            maximalLength = 1;
            firstElement = currentElement;
            Console.WriteLine("\nThe maximal inreasing sequence is:\n{0}",firstElement);
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
                bestElement = someArray[i];
                currentElement = someArray[i];
                currentLength = 1;
            }
            if (currentLength >= maximalLength)
            {
                maximalLength = currentLength;
                firstElement = bestElement;
            }
            currentElement++;
        }
        Console.Write("The maximal sequence of the array is:\n");
        Console.Write("{");
        for (int i = 0; i <= maximalLength -1; i++)
        {
            Console.Write(i != maximalLength - 1? firstElement+ ", " :firstElement + "}\n");
            firstElement++;
        }
        Console.WriteLine();
    } 
}
  



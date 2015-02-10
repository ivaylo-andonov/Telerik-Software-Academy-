//Write a program that reads an array of integers and 
//removes from it a minimal number of elements in such 
//way that the remaining array is sorted in increasing 
//order. Print the remaining sorted array. Example:
//{6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

//Problem 18.* Remove elements from array

using System;
using System.Collections.Generic;
using System.Linq;

class RemoveElements
{
    static void Main()
    {
        List<List<int>> sequences = new List<List<int>>();
        List<int> currentSequence = new List<int>();
        Console.Write("Enter an array of integers separeted by comma:");
        string input = Console.ReadLine();
        string[] numsStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[numsStr.Length];
        int counter = 1;
        int start = 0;
        int end = sequences.Count;
        int bestSequenceLength = 1;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(numsStr[i]);
        }

        Console.WriteLine("Initial array: [{0}]", string.Join(", ", array));

        for (int i = 0; i < array.Length; i++) //create a list containing lists of indeces of the elements of the array
        {
            List<int> temp1 = new List<int>(1);
            temp1.Add(i);
            sequences.Add(temp1);
        }

        while (counter <= array.Length) //create a loop, checking whether the next element of the array can be added to the 
        {                               //already found sequences, so that they remain nondecreasing
            end = sequences.Count;
            for (int i = start; i < end; i++)   //outer loop runs through the lists of already found sequences of length = counter
            {
                currentSequence = new List<int>();
                currentSequence.AddRange(sequences[i]);
                for (int j = currentSequence.Last() + 1; j < array.Length; j++) //inner loop runs from the element to the right of the
                {                                                               //last found element in the sequence to the end of the array
                    if (array[j] >= array[currentSequence.Last()])  //if element at index j is >= the element at index, corresponding to the last
                    {                                               //element of the current sequence, add the current index j to the sequence and
                        List<int> temp = new List<int>();           //add the sequence to the list of sequences;
                        temp.AddRange(currentSequence);             //at the end we will have a list of nondecreasing sequences, containing the indeces
                        temp.Add(j);                                //of the actual numbers in the given array.
                        sequences.Add(temp);
                    }
                }
            }
            start = end;
            counter++;
        }

        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count >= bestSequenceLength)
            {
                bestSequenceLength = sequences[i].Count; //find best sequences' length
            }
        }
        for (int i = 0; i < sequences.Count; i++)
        {
            if (sequences[i].Count == bestSequenceLength)
            {
                Console.Write("Best non-decreasing sequence: ");
                for (int j = 0; j < bestSequenceLength; j++)
                {
                    Console.Write(array[sequences[i][j]]);  //print the actual sequence of corresponding numbers in the array
                    if (j < bestSequenceLength - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
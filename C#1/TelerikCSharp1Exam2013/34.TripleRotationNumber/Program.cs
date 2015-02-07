using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string kNumber = Console.ReadLine();
        List<int> numberArray = new List<int>();
        for (int i = 0; i < kNumber.Length; i++)
        {
            numberArray.Add(kNumber[i] - 48);
        }
        for (int i = 0; i < 3; i++)
        {
            numberArray.Insert(0,numberArray[numberArray.Count-1]);
            numberArray.RemoveAt(numberArray.Count - 1);
            if (numberArray[0] == 0)
            {
                numberArray.Remove(0);
            }
        }
        for (int i = 0; i < numberArray.Count; i++)
        {
            Console.Write(numberArray[i]);
        }
        Console.WriteLine();

    }
}


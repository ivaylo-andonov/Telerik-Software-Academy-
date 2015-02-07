//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class Program
{   
    static void Main()
    {
        Console.WriteLine("Enter a lenght for the first array,and after that the elements: ");
        int n = int.Parse(Console.ReadLine());
        char[] arrayOne = new char[n];
        Initialize(arrayOne);

        Console.WriteLine("Enter a lenght for the second array,and after that the elements: ");
        int s = int.Parse(Console.ReadLine());
        char[] arrayTwo = new char[s];
        Initialize(arrayTwo);
       
        CompareTwoArrays(arrayOne, arrayTwo);
        
    }
    private static void Initialize(char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = char.Parse(Console.ReadLine());
        }
    }
    private static void CompareTwoArrays(char[] someArrayOne , char[] someArrayTwo)
    {
        if (someArrayOne.Length > someArrayTwo.Length)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The length of the first array is longer than the second array,so the are not equal.");
        }
        else if (someArrayOne.Length < someArrayTwo.Length)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("The length of the second array is longer than the first array,so the are not equal");
        }
        else

        {
            Console.Write("The arrays have equal length");
            for (int i = 0; i < someArrayOne.Length; i++)
            {
                if (someArrayOne[i] != someArrayTwo[i])
                {
                    Console.WriteLine(",but they have different elements.");
                    return;
                }   
            }
            Console.WriteLine(" and equals elements.");    
        }
    }    
}



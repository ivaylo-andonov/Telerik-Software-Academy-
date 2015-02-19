//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class Program
{
    static void Main()
    {
        const int START = 1;
        const int END = 1000;

        Console.WriteLine("Enter 10 numbers ,each next number should be bigger than previous in range [1 - 1000]:");
        int num = 0;
        int previousNum = 0;
        for (int i = 0; i < 10; i++)
        {           
            num = ReadNumber(START, END, previousNum);            
            previousNum = num;
        }
    }

    private static int ReadNumber(int start, int end, int previousNum)
    {
        int num = 0;
        try
        {
            num = int.Parse(Console.ReadLine());
            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (num < previousNum)
            {
                throw new InvalidOperationException();
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("\nError!\nNumber was out of the range [{0}..{1}]!\n", start, end);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error! Cannot convert this input to integer. Try again.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Input number is too big or too small to fit in int data type.Try again.");
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("The number is smaller than previous number.Please try again with bigger one.");
        }
        return num;
    }

}



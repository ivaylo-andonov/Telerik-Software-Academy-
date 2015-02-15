//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        // Check the lengths , if one of them is bigger than other => add zeroes to smaller length to be equal arrays later
        int numLen = (input1.Length > input2.Length) ? input1.Length : input2.Length;
        input1 = input1.PadLeft(numLen, '0');
        input2 = input2.PadLeft(numLen, '0');
    
        CreateArrayNumber(input1); CreateArrayNumber(input2);

        SumingTwoArrays(CreateArrayNumber(input1), CreateArrayNumber(input2));

        PrintTheNumber(SumingTwoArrays(CreateArrayNumber(input1), CreateArrayNumber(input2)));
        Console.WriteLine();
    }
    private static int[] CreateArrayNumber(string input)
    {
        int[] number = new int[input.Length];

        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }
        return number;
    }
    private static void PrintTheNumber(string number)
    {
        Console.Write("The summed number is: ");
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
    }
    private static string SumingTwoArrays(int[] numberOne, int[] numberTwo)
    {
        if (numberOne.Length > numberTwo.Length)
        {
            return SumingTwoArrays(numberTwo, numberOne);
        }

        string summedNumber = string.Empty;
        int rest = 0;
        
        for (int i = 0; i < numberTwo.Length ; i++)
        {
            summedNumber += ((numberOne[i] + numberTwo[i]) % 10 + rest).ToString();
            rest = (numberOne[i] + numberTwo[i]) / 10;
            if (rest > 0 && i == numberTwo.Length - 1)
            {
                summedNumber += rest;
            }               
        }        
        return summedNumber;
    }
    
}



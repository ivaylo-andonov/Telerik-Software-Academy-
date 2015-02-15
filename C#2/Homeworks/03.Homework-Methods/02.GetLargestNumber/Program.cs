//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter 2 for two numbers or 3 for three numbers:");
        int choose = int.Parse(Console.ReadLine());
        switch (choose)
        {
            case 2:
                Console.WriteLine("Enter the first number:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("\nThe larger number is {0}", GetMax(firstNumber, secondNumber));
                break;

            case 3:
                Console.WriteLine("Enter the first number:");
                double firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                double secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third number:");
                double thirdNum = double.Parse(Console.ReadLine());
                GetMax(firstNum, secondNum, thirdNum);
                break;
        }
    }
    private static double GetMax(double numOne, double numTwo)
    {
        double max = numOne;
        if (numTwo > numOne)
        {
            max = numTwo;
        }
        return max;
    }
    private static void GetMax(double numOne, double numTwo, double numThree)
    {
        double max = numOne;
        if (numTwo > numOne && numTwo > numThree)
        {
            max = numTwo;
        }
        else if (numThree > numOne && numThree > numTwo)
        {
            max = numThree;
        }
        Console.WriteLine("\nThe largest number is {0}",max);
    }
}


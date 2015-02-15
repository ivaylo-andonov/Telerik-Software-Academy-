//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Please choose the task which has to be solved:\n\n-for \"Reverses the digits of a number\" - press 'R'");
        Console.WriteLine("-for \"Calculates the average of a sequence of inteers\" - press 'C'");
        Console.WriteLine("-for \"Solves a linear equation a * x + b = 0\" - press 'S'\n");
        string input = Console.ReadLine().ToUpper();
        Console.Clear();
        Console.ResetColor();
        switch (input)
        {
            case "R": ReverseTheDIgits();  break;
            case "C": CalculateAverage();  break;
            case "S": SolveLinearEquation(); break;
            default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Invalid input data!\nTry again:\n"); Main(); break;
        }      
    }

    private static void SolveLinearEquation()
    {
        Console.WriteLine("Equation: a * x + b = 0\nFind x = ?");
        Console.WriteLine("\n{0}\n", new string('-', 40));
        decimal a = 0;
        do
        {
            Console.Write("Enter a non-zero number A: ");
            a = decimal.Parse(Console.ReadLine());
        }
        while (a == 0);

        Console.Write("Enter a number B: ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nResult -> x = -b / a = {0}\n{1}\n", -b / a, new string('-', 40));
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("If you want another task - press Y , for exit - press any key:");
        char input = char.Parse(Console.ReadLine().ToUpper());
        if (input == 'Y')
        {
            Console.Clear();
            Main();
        }
        else Console.WriteLine("Have a good day! :)"); return;
        
    }

    private static void CalculateAverage()
    {
        Console.WriteLine("\n{0}\n", new string('-', 40));
        Console.WriteLine("Enter a non-negative sequence of numbers separeted by comma or space:");
        int[] array = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(x => int.Parse(x)).ToArray();
        while (array.Length == 0 || array.Length < 2)
        {
            Console.WriteLine("Enter a non-negative sequence of numbers separeted by comma or space! :");
            array = Console.ReadLine().Split(new char[] { ',', ' ' }).Select(x => int.Parse(x)).ToArray();
        }
        Console.WriteLine("\n{0}\n", new string('-', 40));
        Console.WriteLine("The average value of the sequence is: {0}\n",array.Average());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("If you want another task - press Y , for exit - press any key:");
        char input = char.Parse(Console.ReadLine().ToUpper());
        if (input == 'Y')
        {
            Console.Clear();
            Main();
        }
        else Console.WriteLine("Have a good day! :)"); return;        
    }

    private static void ReverseTheDIgits()
    {
        Console.WriteLine("\n{0}\n", new string('-', 40));
        Console.WriteLine("Enter the number please:\n");
        int number = Math.Abs(int.Parse(Console.ReadLine()));
        string result = string.Empty;
        Console.WriteLine("\n{0}\n", new string('-', 40));
        Console.WriteLine("Your number reversed:\n");
        for (int i = 0; i < number; i++)
        {
            int digit = number % 10;
            result += digit;
            number /= 10;
        }
        Console.WriteLine(result);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nIf you want another task - press Y , for exit - press any key:");
        char input = char.Parse(Console.ReadLine().ToUpper());
        if (input == 'Y')
        {
            Console.Clear();
            Main();
        }
        else Console.WriteLine("Have a good day! :)"); return;
        
    }
}


//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOf5Num
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers separeted by space:");
        string[] numbers = Console.ReadLine().Split();
        double a = double.Parse(numbers[0]);
        double b = double.Parse(numbers[1]);
        double c = double.Parse(numbers[2]);
        double d = double.Parse(numbers[3]);
        double e = double.Parse(numbers[4]);

        Console.WriteLine(a + b + c + d + e);


        // Array for readLine numbers + loops 

        //string[] stringArray = Console.ReadLine().Split();
        //double[] numberArray = new double[stringArray.Length];
        //double sum = 0;
        //for (int i = 0; i < stringArray.Length; i++)
        //{
        //   numberArray[i] = int.Parse(stringArray[i]);
        //   sum += numberArray[i];
        //}
        //Console.WriteLine("The sum ot the numbers is " + sum);
        

    }
}


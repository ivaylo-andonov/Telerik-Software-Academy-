//Write a program that enters from the console a positive integer n and prints all the numbers
//from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NumbersNotDivisibleby3and7
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
        }
    }


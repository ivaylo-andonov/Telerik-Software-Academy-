//Write a Boolean expression that returns if the bit at 
//position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());  // Check if bit at position P is == 1 with boolean operator
            int p = int.Parse(Console.ReadLine());
            bool isOne = (n & (1 << p)) > 0;
            Console.WriteLine(isOne);

            // Second way with operator ? ; 
            //Console.WriteLine(( n & (1<< p)) > 0 ? "true" : "false");
        }
    }

             
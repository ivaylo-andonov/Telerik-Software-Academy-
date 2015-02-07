//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddEvenProduct
    {
        static void Main()
        {
            int productOdd = 1;
            int productEven = 1;

            string input = Console.ReadLine();
            string[] numbers = input.Split();
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                if (i % 2 != 0)
                {
                    productEven *= number;
                }
                else if (i % 2 == 0)
                {
                    productOdd *= number;
                }
            }
            if (productOdd == productEven)
            {
                Console.WriteLine("yes\nproduct = {0}", productEven);
            }
            else if ( productEven != productOdd)
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", productOdd,productEven);
            }

        }
    }


//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());  // Way to find prime number!
        bool isPrime = true;
        if (num >= 1)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }

            }
            Console.WriteLine(isPrime);
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}


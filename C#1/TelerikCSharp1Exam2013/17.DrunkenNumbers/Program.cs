using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int nRounds = int.Parse(Console.ReadLine());
        long vladkoBeers = 0;
        long mitkoBeers = 0;
        for (int i = 0; i < nRounds; i++)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            string digits = Convert.ToString(number);
            if (digits.Length % 2 == 0)
            {
                for (int j = 0; j < digits.Length / 2; j++)
                {
                    mitkoBeers += digits[j] - '0';
                }
                for (int j = digits.Length / 2; j < digits.Length; j++)
                {
                    vladkoBeers += digits[j] - '0';
                }
            }
            else
            {
                for (int j = 0; j < digits.Length / 2 + 1; j++)
                {
                    mitkoBeers += digits[j] - '0';
                }
                for (int j = digits.Length / 2; j < digits.Length; j++)
                {
                    vladkoBeers += digits[j] - '0';
                }
            }
        }
        if (vladkoBeers > mitkoBeers)
        {
            Console.WriteLine("V {0}", vladkoBeers - mitkoBeers);
        }
        else if (mitkoBeers > vladkoBeers)
        {
            Console.WriteLine("M {0}", mitkoBeers - vladkoBeers);
        }
        else
        {
            Console.WriteLine("No {0}", mitkoBeers + vladkoBeers);
        }
    }
}

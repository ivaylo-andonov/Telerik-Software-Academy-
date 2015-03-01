using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            int number = int.Parse(input);
            numbers.Add(number);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            var numbersAsString = new StringBuilder();

            BigInteger summedBunny = 0;
            BigInteger bunniesSum = 0;
            BigInteger bunniesProduct = 1;

            for (int j = 0; j <= i; j++)
            {
                summedBunny += numbers[j];
            }

            if (summedBunny > numbers.Count - i)
            {
                break;
            }

            for (int k = i + 1; k <= summedBunny + i; k++)
            {
                bunniesSum += numbers[k];
                bunniesProduct *= numbers[k];
            }

            // Add from list to string builder 

            numbersAsString.Append(bunniesSum);
            numbersAsString.Append(bunniesProduct);

            for (int j = (int)summedBunny + i + 1; j < numbers.Count; j++)
            {
                numbersAsString.Append(numbers[j]);
            }

            numbers.Clear();

            // CHeck for 0 or 1
            for (int m = 0; m < numbersAsString.Length; m++)
            {
                if (numbersAsString[m] == '0' || numbersAsString[m] == '1')
                {
                    numbersAsString.Remove(m, 1);
                    m--;
                }
            }
            // Return again to the list
            for (int z = 0; z < numbersAsString.Length; z++)
            {
                numbers.Add(int.Parse(numbersAsString[z].ToString()));
            }
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}



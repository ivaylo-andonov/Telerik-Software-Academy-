namespace Problem_2
{
    using System;
    using System.Linq;

   internal class EvenDifferences
    {
        static void Main()
        {
            long[] inputNumbers = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(x => long.Parse(x)).ToArray();
            long result = 0;

            for (int i = 1; i < inputNumbers.Length; i++)
            {
                long number = GetAbsolute(inputNumbers[i], inputNumbers[i - 1]);
                if (number % 2 == 0)
                {
                    i += 1;
                    result += number;
                }
                if (i >= inputNumbers.Length)
                {
                    break;
                }
            }
            Console.WriteLine(result);

        }
        static long GetAbsolute(long firstNum, long secondNum)
        {
            long result = 0;
            if (firstNum >= secondNum)
            {
                result = firstNum - secondNum;
            }
            else
            {
                result = secondNum - firstNum;
            }
            return result;
        }
    }
}

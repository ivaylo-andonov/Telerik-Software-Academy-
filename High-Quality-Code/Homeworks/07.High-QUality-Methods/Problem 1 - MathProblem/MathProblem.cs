namespace Problem_1
{
    using System;

    class MathProblem
    {
        static void Main()
        {
            string[] catNumbers = Console.ReadLine().Split();
            string newName = string.Empty;
            long sumResult = 0,
                 finalResult = 0,
                 currentResult = 0;

            for (int i = 0; i < catNumbers.Length; i++)
            {
                string currentNum = catNumbers[i];
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = currentNum[j] - 'a';
                    currentResult = currentResult * 19 + currentDigit;
                }
                sumResult += currentResult;
                currentResult = 0;
            }

            finalResult = sumResult;

            while (sumResult > 0)
            {
                long digit = sumResult % 19;
                newName = (char)(digit + 'a') + newName;
                sumResult /= 19;
            }
            Console.WriteLine("{0} = {1}", newName, finalResult);
        }
    }
}

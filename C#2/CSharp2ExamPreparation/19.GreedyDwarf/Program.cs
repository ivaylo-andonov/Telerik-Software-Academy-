using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static void Main()
    {
        //Input reading
        int[] valley = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
        long maxValue = long.MinValue;
        int numberPatterns = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberPatterns; i++)
        {
            long sum = FindMaxSum(valley);
            if (sum > maxValue)
            {
                maxValue = sum;
            }
        }
        Console.WriteLine(maxValue);
    }

    private static long FindMaxSum(int[] valley)
    {
        var pattern = Console.ReadLine().Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var valleyPath = new bool[valley.Length];
        long currentSum = valley[0];
        valleyPath[0] = true;
        int nextPosition = 0;
        int j = 0;

        while (true)
        {
            nextPosition += (pattern[j % pattern.Length]);

            if (nextPosition >= 0 && nextPosition < valley.Length && !valleyPath[nextPosition])
            {
                currentSum += valley[nextPosition];
                valleyPath[nextPosition] = true;
            }
            else
            {
                return currentSum;
            }
            j++;
        }
    }
}

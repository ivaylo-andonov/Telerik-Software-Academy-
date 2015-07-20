/* Task 2. Method PrintStatistics in C#
 * StyleCop settings: disabled: Documentation Rules
*/
namespace Task02.MethodPrintStatistics
{
    using System;
    using System.Linq;

    internal class Statistics
    {
        public void PrintStatisticsToConsole(double[] numbersCollection)
        {
            double maxNumber = this.FindMaxNumber(numbersCollection);
            Console.WriteLine(maxNumber);

            double minNumber = this.FindMinNumber(numbersCollection);
            Console.WriteLine(minNumber);

            double averageNumber = this.FindAverageNumber(numbersCollection);
            Console.WriteLine(averageNumber);
        }

        private double FindMaxNumber(double[] numbersCollection)
        {
            double max = numbersCollection.Max();
            return max;
        }

        private double FindMinNumber(double[] numbersCollection)
        {
            double min = numbersCollection.Min();
            return min;
        }

        private double FindAverageNumber(double[] numbersCollection)
        {
            double average = numbersCollection.Average();
            return average;
        }
    }   
}
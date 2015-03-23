namespace _04.DivisibleBy7And3
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class DivisibleBy7and3Program
    {
        static void Main()
        {

            // Example array
            int[] numbersArray = Enumerable.Range(1, 50).ToArray();

            Console.WriteLine("All numbers in the array:\n");
            foreach (var item in numbersArray)
            {
                Console.Write(item + " ");               
            }
            Console.WriteLine();

            // Cool way with lambda
            var divisibleBy3And7 = numbersArray.Where(x => x % 3 == 0 && x % 7 == 0).ToArray();

            // Old way with linq
            var divisibleBy3And7second =
                from number in numbersArray
                where number % 3 == 0 && number % 7 == 0
                select number;

            Console.WriteLine("\nNumbers which are divisible only by 3 and 7 (USING LAMBDA):\n");
            Console.WriteLine(string.Join(", ",divisibleBy3And7));

            Console.WriteLine("\nNumbers which are divisible only by 3 and 7 (USING LINQ):\n");
            Console.WriteLine(string.Join(", ", divisibleBy3And7second));
        }
    }
}

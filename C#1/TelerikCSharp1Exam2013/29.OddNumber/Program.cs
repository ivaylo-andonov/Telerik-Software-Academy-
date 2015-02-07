using System;
using System.Collections.Generic;
using System.Linq;


namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //List<string> numbers = new List<string>(n);

            //for (int i = 0; i < n; i++)
            //{
            //    numbers.Add(Console.ReadLine());
            //}
            //numbers.Sort();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    var answer = numbers.FindAll(s => s.Equals(numbers[i]));

            //    if (answer.Count % 2 == 1 || answer.Count == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //        break;
            //    }
            //}

             //Second way : 

            int n = int.Parse(Console.ReadLine());
            long number = long.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                number = number ^ long.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);


            //Trhird way : 

            //int n = int.Parse(Console.ReadLine());
            //long[] inputs = new long[n];
            //for (int i = 0; i < n; i++)
            //{
            //    inputs[i] = long.Parse(Console.ReadLine());
            //}
            //Array.Sort(inputs);
            //for (int i = 0; i < n-1; i= i+2)
            //{
            //    if (inputs[i] != inputs[i+1])
            //    {
            //        Console.WriteLine(inputs[i]);
            //        return;
            //    }
            //}
            //Console.WriteLine(inputs[n-1]);
        }
    }
}
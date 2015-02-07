//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenInt
{
    static void Main()  //Solution 1st way .Question : Is Odd?
    {
        int n = int.Parse(Console.ReadLine());   
        bool isOdd = (n % 2 != 0);
        Console.WriteLine(isOdd);
    }

    ////(Solution 2nd way.Question: Is Odd ?)

    //int i = int.Parse(Console.ReadLine());
    //    Console.WriteLine("{0}", i % 2 == 0 ? "false" : "true");  // Way to find even or odd number
}

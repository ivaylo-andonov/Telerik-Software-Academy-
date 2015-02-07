//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigit
{
    static void Main()
    {
        int num = Math.Abs(int.Parse(Console.ReadLine())); // Math.Abs returns only absolute (+) numbers
        int position = num / 100;        // Find the third digit of number
        bool thirdDigit = (position % 10 == 7);  // To find is the last digit is 7 
        Console.WriteLine(thirdDigit);
    }
}


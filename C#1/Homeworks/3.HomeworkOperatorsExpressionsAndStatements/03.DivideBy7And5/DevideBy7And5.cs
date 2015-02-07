//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DevideBy7And5
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        bool isDivide = num % 5 == 0 && num % 7 == 0;  //Way to find a number which can be devides by 5 and 7 
        Console.WriteLine(isDivide);
    }
}

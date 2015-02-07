//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNum
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int d = num % 10;                                 // find last digit
        int c = (num / 10) % 10;                         //find 3d digit
        int b = (num / 100) % 10;                       //find 2nd digit
        int a = (num / 1000) % 10;                     // find 1st digit
        int sum = a + b + c + d;
        Console.WriteLine("The sum of the digits: " + sum);
        Console.WriteLine("The reversed order: {0}{1}{2}{3}",d,c,b,a);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}",d,a,b,c);
        Console.WriteLine("Second and third digit exchanged: {0}{1}{2}{3}",a,c,b,d);

    }
}

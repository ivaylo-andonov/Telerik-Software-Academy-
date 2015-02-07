//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.WriteLine("Enter your name :");
        string name = (Console.ReadLine());
        Console.WriteLine("Enter your weight on the Earth :");
        double weightOnEarth = double.Parse(Console.ReadLine());
        double weightOnMoon = weightOnEarth * 0.17;
        Console.WriteLine("{0},your weiht on the Moon is: {1} ", name,weightOnMoon);

    }
}
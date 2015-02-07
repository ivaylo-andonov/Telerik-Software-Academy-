using System;

class Program
{
    static void Main()
    {
        int numberK = int.Parse(Console.ReadLine());
        int decimalNumber = 0;
        double power = 0;
        while (numberK != 0)
        {
            int digit = numberK % 10;
            decimalNumber += digit * (int)Math.Pow(7, power);
            power++;
            numberK /= 10;
        }
        decimalNumber ++;
        string result = "";
        while (decimalNumber != 0)
        {
            int digit = decimalNumber % 7;
            result = digit + result;
            decimalNumber /= 7;
        }
        Console.WriteLine(result);
    }
}


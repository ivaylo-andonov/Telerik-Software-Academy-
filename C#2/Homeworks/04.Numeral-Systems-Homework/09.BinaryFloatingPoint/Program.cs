/* Write a program that shows the internal binary representation of given 32-bit 
 * signed floating-point number in IEEE 754 format (the C# type float). Example: 
 * -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000. */

// This method calculate all bits himself.

using System;
using System.Text;


class FloatingPoint
{
    static void Main()
    {
        float input = 0.0f;
        bool IsFloat;
        do
        {
            Console.Write("Enter any floating point number: ");
            IsFloat = float.TryParse(Console.ReadLine(), out input);
            if (!IsFloat)
                Console.WriteLine("Invalid floating point number. Try again.");
        } while (!IsFloat);
        bool isNegative = false;
        if (input < 0.0f)
        {
            input = -input;
            isNegative = true;
        }

        byte mantissa = 127;
        double dInput = input;
        if (input > 2.0f)
        {
            while (dInput >= 2.0)
            {
                mantissa++;
                dInput = dInput / 2.0d;
            }
        }
        else
        {
            while (dInput < 1.0)
            {
                mantissa--;
                dInput = dInput * 2.0d;
            }
        }
        dInput = dInput - 1.0f;
        StringBuilder significant = new StringBuilder();
        for (int i = 0; i < 23; i++)
        {
            dInput = dInput * 2;
            if (dInput >= 1.0d)
            {
                significant.Append('1');
                dInput = dInput - 1.0f;
            }
            else
            {
                significant.Append('0');
            }
        }
        Console.WriteLine("Sign: {0}, mantissa: {1}, exponent: {2}", (isNegative ? "-" : "+"),
                                    Convert.ToString(mantissa, 2).PadLeft(8, '0'), significant);
    }
}
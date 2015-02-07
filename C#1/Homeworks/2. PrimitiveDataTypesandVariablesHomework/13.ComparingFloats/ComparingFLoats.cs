using System;

class ComparingFLoats
{
    static void Main()
    {
        Console.Write("Enter number A:");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        decimal b = decimal.Parse(Console.ReadLine());

        decimal eps = 0.000001M;
        if (a > b)
        {
            decimal diff1 = a - b;
            if (a - b < eps)
            {
                Console.WriteLine("The difference {0} < eps", diff1);
            }
            else if (a - b > eps)
            {
                Console.WriteLine("The difference of {0} is too big (>eps)", diff1);
            }
            else if (a - b == eps)
            {
                Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
            }
        }
        else if (a < b)
        {
            decimal diff2 = b - a;

            if (b - a < eps)
            {
                Console.WriteLine("The difference {0} < eps", diff2);
            }
            else if (b - a > eps)
            {
                Console.WriteLine("The difference of {0} is too big (>eps)", diff2);
            }
            else if (b - a == eps)
            {
                Console.WriteLine("Border case. The difference 0.000001 == eps. We consider the numbers are different.");
            }
        }
        Console.WriteLine();
    }
}
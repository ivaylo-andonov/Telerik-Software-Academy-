//Write a program that reads the coefficients a, b and c of a 
//quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        int caseOfDisc;
        double r1, r2, disc;

        disc = b * b - 4 * a * c;

        if (disc > 0)
        {
            caseOfDisc = 1;
        }
        else if (disc == 0)
        {
            caseOfDisc = 2;
        }
        else
        {
            caseOfDisc = 3;
        }

        switch (caseOfDisc)
        {
            case 1:
                r1 = (-b - Math.Sqrt(disc)) / (2 * a);
                r2 = (-b + Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine("x1 is {0}", r1);
                Console.WriteLine("x2 is {0}", r2);
                break;
            case 2:
                r1 = r2 = (-b) / (2 * a);
                Console.WriteLine("Roots are Equal");
                Console.WriteLine("\n x1 = x2 = {0:#.##}", r1);
                break;
            case 3:
                r1 = (-b) / (2 * a);
                r2 = Math.Sqrt(-disc) / (2 * a);
                Console.WriteLine("No real roots!");
                break;
        }
    }
}





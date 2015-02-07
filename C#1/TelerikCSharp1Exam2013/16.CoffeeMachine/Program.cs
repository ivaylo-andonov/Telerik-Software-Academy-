using System;
using System.Globalization;
using System.Threading;

class CoffeeMachine
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double n4 = double.Parse(Console.ReadLine());
        double n5 = double.Parse(Console.ReadLine());
        double A = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());

        double moneyInMachine = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5 * 1.0;
        double change = A - P;
        double restMoneyInMachine = moneyInMachine - change;

        if (P > A)
        {
            Console.Write("More ");
            Console.WriteLine("{0:0.00}", (P - A));
        }

        if (A >= P && restMoneyInMachine >= 0)
        {
            Console.Write("Yes ");
            Console.WriteLine("{0:0.00}", restMoneyInMachine);
        }

        if (A >= P && restMoneyInMachine < 0)
        {
            Console.Write("No ");
            Console.WriteLine("{0:0.00}", Math.Abs(restMoneyInMachine));
        }
    }
}

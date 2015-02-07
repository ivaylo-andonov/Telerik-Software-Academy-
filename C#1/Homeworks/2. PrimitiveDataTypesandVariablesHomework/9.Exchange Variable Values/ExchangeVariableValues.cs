using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a + " " +b);
        int c = a;
        a = b;
        b = c;
        Console.WriteLine(a + " " + b);


    }
}
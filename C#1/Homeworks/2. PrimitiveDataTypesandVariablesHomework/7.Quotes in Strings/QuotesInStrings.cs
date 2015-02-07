using System;

class QuotesInStrings
{
    static void Main()
    {
        string textFirstWay = "The \"use\" of quotations causes difficulties.";
        string textSecondWay = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine("{0}\n{1}",textFirstWay,textSecondWay);

    }
}

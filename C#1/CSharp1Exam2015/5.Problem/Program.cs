using System;
class Program
{
    static void Main()
    {
        int numberS = int.Parse(Console.ReadLine());
        int numberN = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 0; i < numberN; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int j = 0; j < 27; j++)
            {
                if (((number >> j) & 15) == (numberS & 15))
                //if ((number & (s & 15)<< j) == s << j)
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}
using System;

class LongSequence
{
    static void Main()
    {

        for (int i = 1; i < 1000; i++)
        {
            Console.Write("{0,-10},", i % 2 == 0 ? i : -i);
        }
    }
}

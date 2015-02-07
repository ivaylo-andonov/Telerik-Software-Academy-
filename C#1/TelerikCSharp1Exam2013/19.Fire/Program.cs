using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int upInnerDots = 0;
        for (int i = 0; i < n/2; i++)
        {
            Console.WriteLine(new string('.',n/2-1-(1*i)) + '#' + new string('.',upInnerDots)+ '#'+ 
                             new string('.', n /2 - 1-(1*i)));
            upInnerDots += 2;
        }
        int downOuterDOts = 0;
        for (int i = 0; i < n/4; i++)
        {
            Console.WriteLine(new string('.', downOuterDOts) + '#' + new string('.', n- (2*downOuterDOts) - 2) + '#' + new string('.', downOuterDOts));
            downOuterDOts++;
        }
        Console.WriteLine(new string('-',n));
        int downDots = 0;
        int slashes = n;
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.',downDots));
            for (int j = 0; j < slashes; j++)
            {
                if (j < slashes/2)
                {
                    Console.Write('\\');
                }
                else
                {
                    Console.Write('/');
                }
            }
            Console.WriteLine(new string('.', downDots));
            slashes -= 2;
            downDots++;
        }
    }
}


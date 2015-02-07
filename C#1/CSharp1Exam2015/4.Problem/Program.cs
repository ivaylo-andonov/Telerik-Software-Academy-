using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int Nspace = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int sharps = i;
            int space = n*2 + 1 - 2 - 2*sharps;
            int dotsss = (n * 2 + 1 - 4 - 2 * Nspace - 2 * sharps);
            if (Nspace <= n - 2)
            {
                if (dotsss >= 1)
                {
                    Console.WriteLine(new string('#', sharps) + '\\' + new string(' ', Nspace) + '\\' + new string('.', dotsss)
                        + '/' + new string(' ', Nspace) + '/' + new string('#', sharps));
                }
                else
                {
                    Console.WriteLine(new string('#', sharps) + '\\' + new string(' ', space) + '/' + new string('#', sharps));
                }
            }
            else
            {
                Console.WriteLine(new string('#', i) + '\\' + new string(' ', n * 2 - 1 - (2 * i)) + '/' + new string('#', i));
            }

        }

        Console.WriteLine(new string('#', n) + 'X' + new string('#', n));
        int slashes = 1;
        for (int i = 0; i < n; i++)
        {
            int sharps = n - 1 - i;
            int dotss = (n * 2 + 1 - 4 - 2 * Nspace - 2 * sharps);
            int space = n*2 + 1 - 2 - 2*sharps;
            if (Nspace <= n - 2)
            {
                if (dotss < 1)
	            {
                    Console.WriteLine(new string('#', sharps) + '/' + new string(' ', space) + '\\' + new string('#', sharps));
	            }
                else
                {
                    Console.WriteLine(new string('#',sharps) + '/' + new string(' ',Nspace) + '/' + new string('.',dotss)
                        + '\\' + new string(' ', Nspace) + '\\' + new string('#', sharps));
                }                       
            }
            else
            {
                Console.WriteLine(new string('#', n - 1 - i) + '/' + new string(' ', slashes) + '\\' + new string('#', n - 1 - i));
                slashes += 2;
            }

        }
    }
}


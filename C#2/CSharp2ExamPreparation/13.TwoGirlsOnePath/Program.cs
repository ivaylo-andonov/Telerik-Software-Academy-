using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
class Program
{
    static void Main()
    {
        BigInteger[] cells = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
        BigInteger dollyFlowers = 0;
        BigInteger mollyFlowers = 0;
        bool isDolly = false;
        bool isMolly = false;
        bool isDraw = false;

        int i = 0;
        int j = cells.Length - 1;

        while (true)
        {
            if (cells[i] == 0 && cells[j] == 0)
            {
                isDraw = true;
                break;
            }
            if (cells[i] == 0)
            {
                dollyFlowers += cells[j];
                isDolly = true;
                break;
            }
            if (cells[j] == 0)
            {
                mollyFlowers += cells[i];
                isMolly = true;
                break;
            }

            BigInteger currentCellMolly = cells[i];
            BigInteger currentCellDolly = cells[j];
            cells[i] = 0;
            cells[j] = 0;
            mollyFlowers += currentCellMolly;
            dollyFlowers += currentCellDolly;

            i = (int)((i + currentCellMolly) % (cells.Length));
            j = (int)((j - currentCellDolly) % (cells.Length));
            if (j < 0)
            {
                j += cells.Length;
            }

            if (i == j)
            {
                if (cells[j] % 2 == 0)
                {
                    mollyFlowers += cells[j] / 2;
                    dollyFlowers += cells[j] / 2;
                    cells[j] = 0;
                }
                else if (cells[j] % 2 != 0)
                {
                    mollyFlowers += cells[j] / 2;
                    dollyFlowers += cells[j] / 2;
                    cells[j] = 1;
                }
                i = (int)((i + currentCellMolly) % (cells.Length));
                j = (int)((j - currentCellDolly) % (cells.Length));
            }
        }

        // Print Result
        if (isDolly)
        {
            Console.WriteLine("Dolly");
            Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
        }
        else if (isMolly)
        {
            Console.WriteLine("Molly");
            Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
        }
        else if (isDraw)
        {
            Console.WriteLine("Draw");
            Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
        }
    }
}
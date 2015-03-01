using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        int[] terrainNumbers = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).
                                  Select(int.Parse).ToArray();
        int step;
        int Maxlength = 0;
        int length = 1;
        int currentPosition;
        int nextPosition = 0;

        for (int i = 0; i < terrainNumbers.Length; i++)
        {
            currentPosition = i;

            for (step = 1; step < terrainNumbers.Length; step++)
            {
                nextPosition = currentPosition + step;

                if (nextPosition >= terrainNumbers.Length)
                {
                    nextPosition %= terrainNumbers.Length;
                }

                while (terrainNumbers[currentPosition] < terrainNumbers[nextPosition])
                {
                    length++;
                    currentPosition = nextPosition;
                    nextPosition = currentPosition + step;

                    if (length > Maxlength)
                    {
                        Maxlength = length;
                    }

                    if (nextPosition >= terrainNumbers.Length)
                    {
                        nextPosition %= terrainNumbers.Length;
                    }
                }
                currentPosition = i;
                length = 1;
            }
        }
        Console.WriteLine(Maxlength);
    }
}


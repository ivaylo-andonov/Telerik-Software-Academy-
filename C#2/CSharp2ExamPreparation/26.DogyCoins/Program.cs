using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];

        int[,] coins = new int[rows,cols];

        int k = int.Parse(Console.ReadLine());
        for (int i = 0; i < k; i++)
		{
            string[] currentCordinates = Console.ReadLine().Split();
            int currentCoinsRow = int.Parse(currentCordinates[0]);
            int currentCoinsCol = int.Parse(currentCordinates[1]);

            coins[currentCoinsRow, currentCoinsCol]++;

		}

        int[,] dinamicProgram = new int[rows, cols];
        for (int row  = 0; row  < rows; row ++)
        {
            for (int col = 0; col < cols; col++)
            {
                int maxAbove = 0;
                int maxLeft = 0;

                if (row - 1 >=0)
                {
                    maxAbove = dinamicProgram[row - 1, col];
                }
                if (col - 1 >= 0)
                {
                    maxLeft = dinamicProgram[row, col - 1];
                }

                dinamicProgram[row, col] = Math.Max(maxLeft, maxAbove) + coins[row, col];
            }
        }
        Console.WriteLine(dinamicProgram[rows-1,cols-1]);
    }
}


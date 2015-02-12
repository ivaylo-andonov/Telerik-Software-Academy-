//Write a program that reads a rectangular matrix of size N x M
//and finds in it the square 3 x 3 that has maximal sum of its elements.
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter rows size (bigger than 3):");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cols size (bigger than 3):");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        FillTheMatrix(matrix);
        PrintTheMatrix(matrix);
        FindTheMaxSum(matrix);

    }

    private static void FindTheMaxSum(int[,] matrix)
    {
        int bestSum = int.MinValue;
        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1) - 2; cols++)
            {
                int currentBlock = matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 2] +
                                   matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] +
                                   matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];

                if (currentBlock > bestSum)
                {
                    bestSum = currentBlock;
                }
            }
        }
        Console.WriteLine("The maximal sum of element 3x3 from the matrix is: {0}", bestSum);
    }

    private static void PrintTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine("\n");
        }
    }

    private static void FillTheMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("matrix[{0},{1}] = ", row, col);
                int element = int.Parse(Console.ReadLine());
                matrix[row, col] = element;
            }
        }
        Console.WriteLine();
    }
}


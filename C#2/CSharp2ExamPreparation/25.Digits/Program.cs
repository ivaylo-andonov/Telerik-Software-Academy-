using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        // Input
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        long maxSum = 0;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            var numbersAsString = line.Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(numbersAsString[j]);
            }
        }

        // Going on each possible position in the matrix

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {

                // Check for patterns from 3 to 9
                switch (matrix[row, col])
                {

                    case 1: if ((isPatternOne(row, col, matrix))) maxSum += 1; break;
                    case 2: if ((isPatternTwo(row, col, matrix))) maxSum += 2; break;
                    case 3: if (isPatternThree(row, col, matrix)) maxSum += 3; break;
                    case 4: if (isPatternFour(row, col, matrix)) maxSum += 4; break;
                    case 5: if (isPatternFive(row, col, matrix)) maxSum += 5; break;
                    case 6: if (isPatternSix(row, col, matrix)) maxSum += 6; break;
                    case 7: if (isPatternSeven(row, col, matrix)) maxSum += 7; break;
                    case 8: if (isPatternEight(row, col, matrix)) maxSum += 8; break;
                    case 9: if (isPatternNine(row, col, matrix)) maxSum += 9; break;
                }
            }
        }
        Console.WriteLine(maxSum);
    }

    private static bool isPatternOne(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 3 && col <= matrix.GetLength(1) - 3 && row >= 2 && matrix[row, col] == 1 
            && matrix[row - 1, col + 1] == 1 && matrix[row - 2, col + 2] == 1 && matrix[row - 1, col + 2] == 1
            && matrix[row, col + 2] == 1 && matrix[row + 1, col + 2] == 1 && matrix[row + 2, col + 2] == 1;
    }

    private static bool isPatternTwo(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 4 && col <= matrix.GetLength(1) - 3 && row >= 1 && matrix[row, col] == 2 
            && matrix[row - 1, col + 1] == 2 && matrix[row, col + 2] == 2
            && matrix[row + 1, col + 2] == 2 && matrix[row + 2, col + 1] == 2
            && matrix[row + 3, col] == 2 && matrix[row + 3, col + 1] == 2 && matrix[row + 3, col + 2] == 2;
    }

    private static bool isPatternThree(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 1] == 3
            && matrix[row, col + 2] == 3 && matrix[row + 1, col + 2] == 3
            && matrix[row + 2, col + 1] == 3 && matrix[row + 2, col + 2] == 3
             && matrix[row + 2, col + 1] == 3 && matrix[row + 3, col + 2] == 3
             && matrix[row + 4, col] == 3 && matrix[row + 4, col + 1] == 3 && matrix[row + 4, col + 2] == 3;
    }
    private static bool isPatternFour(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 2] == 4
            && matrix[row + 1, col] == 4 && matrix[row + 1, col + 2] == 4
            && matrix[row + 2, col] == 4 && matrix[row + 2, col + 1] == 4
             && matrix[row + 2, col + 2] == 4 && matrix[row + 4, col + 2] == 4
             && matrix[row + 3, col + 2] == 4 && matrix[row + 4, col + 2] == 4;
    }
    private static bool isPatternFive(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 1] == 5
            && matrix[row, col + 2] == 5 && matrix[row + 1, col] == 5
            && matrix[row + 2, col] == 5 && matrix[row + 2, col + 1] == 5
             && matrix[row + 2, col + 2] == 5 && matrix[row + 3, col + 2] == 5
             && matrix[row + 4, col] == 5 && matrix[row + 4, col + 1] == 5 && matrix[row + 4, col + 2] == 5;
    }

    private static bool isPatternSix(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 1] == 6
            && matrix[row, col + 2] == 6 && matrix[row + 1, col] == 6
            && matrix[row + 2, col] == 6 && matrix[row + 2, col + 1] == 6
             && matrix[row + 2, col + 2] == 6 && matrix[row + 3, col] == 6 && matrix[row + 3, col + 2] == 6
             && matrix[row + 4, col] == 6 && matrix[row + 4, col + 1] == 6 && matrix[row + 4, col + 2] == 6;
    }

    private static bool isPatternSeven(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 1] == 7
            && matrix[row, col + 2] == 7 && matrix[row + 1, col + 2] == 7
           && matrix[row + 2, col + 1] == 7 && matrix[row + 3, col + 1] == 7
            && matrix[row + 4, col + 1] == 7;
    }

    private static bool isPatternEight(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 1] == 8
            && matrix[row, col + 2] == 8 && matrix[row + 1, col] == 8
            && matrix[row + 1, col + 2] == 8 && matrix[row + 2, col + 1] == 8
             && matrix[row + 3, col] == 8 && matrix[row + 3, col + 2] == 8
             && matrix[row + 4, col] == 8 && matrix[row + 4, col + 1] == 8 && matrix[row + 4, col + 2] == 8;
    }

    private static bool isPatternNine(int row, int col, int[,] matrix)
    {
        return row <= matrix.GetLength(0) - 5 && col <= matrix.GetLength(1) - 3 && matrix[row, col + 1] == 9
            && matrix[row, col + 2] == 9 && matrix[row + 1, col] == 9
            && matrix[row + 1, col + 2] == 9 && matrix[row + 2, col + 1] == 9
             && matrix[row + 2, col + 2] == 9 && matrix[row + 3, col + 2] == 9
             && matrix[row + 4, col] == 9 && matrix[row + 4, col + 1] == 9 && matrix[row + 4, col + 2] == 9;
    }
}



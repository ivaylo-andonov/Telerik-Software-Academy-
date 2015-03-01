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

        long maxSum = long.MinValue;
        bool foundPattern = false;

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            var numbersAsString = line.Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(numbersAsString[j]);
            }
        }

        // You can change tha pattern in different size and form
        bool[,] pattern = new bool[,]
        {
            {true, true, true,false,false},
            {false,false,true,false,false},
            {false,false,true, true, true},
        };

        // All posiblle positions for pattern in matrix
        for (int patternStartXinMatrix = 0; patternStartXinMatrix <= matrix.GetLength(0) - pattern.GetLength(0); patternStartXinMatrix++)
        {
            for (int patternStartYinMatrix = 0; patternStartYinMatrix <= matrix.GetLength(1) - pattern.GetLength(1); patternStartYinMatrix++)
            {

                // Create list to save each pattern numbers
                List<int> numbersInPattern = new List<int>();

                // Positions int the pattern
                for (int patternX = 0; patternX < pattern.GetLength(0); patternX++)
                {
                    for (int patternY = 0; patternY < pattern.GetLength(1); patternY++)
                    {
                        // Positions in the matrix
                        int x = patternStartXinMatrix + patternX;
                        int y = patternStartYinMatrix + patternY;

                        //Chech which positions in the pattern are true,if they are -> add the corresponding number[x,y] from matrix to list
                        if (pattern[patternX,patternY])
                        {
                            numbersInPattern.Add(matrix[x, y]);
                        }
                    }
                }
                // Check for the numbers in each pattern whether they increasing by 1 ( 1,2,3,4...)
                bool isCorrectPattern = true;
                for (int i = 1; i < numbersInPattern.Count; i++)
                {
                    if (numbersInPattern[i] - 1 != numbersInPattern[i - 1])
                    {
                        isCorrectPattern = false;
                        break;
                    }                              
                }

                // If they are increasing sequence, find the sum  
                long currentPatternSum = 0;
                if (isCorrectPattern)
                {
                    foundPattern = true;
                    for (int j = 0; j < numbersInPattern.Count; j++)
                    {
                        currentPatternSum += numbersInPattern[j];
                    }
                }

                // Check for the max sum
                if (currentPatternSum > maxSum)
                {
                    maxSum = currentPatternSum;
                }
            }
        }
        // Print the max sum !
        if (foundPattern)
        {
            Console.WriteLine("YES {0}",maxSum);
        }
        else
        {
            Console.WriteLine("NO {0}", SumOfDiagonal(matrix));
        }       
    }

    private static long SumOfDiagonal(int[,] matrice)
    {
        long diagonalSum = 0;

        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            diagonalSum += matrice[i, i];
        }
        return diagonalSum;
    }
}


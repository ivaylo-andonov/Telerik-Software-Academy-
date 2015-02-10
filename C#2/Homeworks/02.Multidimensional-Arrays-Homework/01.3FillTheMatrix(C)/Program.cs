using System;

class DiagonalIngreasingMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter N size of the matrix:");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int counter = 1;
        int rowBackCounter = 1;
        int colBackCounter = 0;
        int maxCount = size * size;

        for (int row = size - 1; row >= 0; row--)
        {
            for (int col = 0; col < matrix.GetLength(1); )
            {
                matrix[row, col] = counter;

                if (counter == maxCount)
                {
                    break;
                }
                else if (row == size - 1 && col != size - 1)
                {
                    row -= rowBackCounter;
                    col -= colBackCounter;
                    rowBackCounter++;
                    colBackCounter++;
                }
                else if (row == size - 1 || col == size - 1)
                {
                    colBackCounter--;
                    rowBackCounter--;
                    col -= colBackCounter;
                    row -= rowBackCounter;
                }
                else
                {
                    row++;
                    col++;
                }
                counter++;
            }       
        }
        // Print the matrix with nice format and cool color :)
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("My matrix for you:\n");         
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3} ", matrix[row, col]);
            }
            Console.WriteLine("\n");
        }
    }
}



using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N size of the matrix:");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int counter = 1;

        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                if (col % 2 == 0)
                {
                    matrix[row, col] = counter++;
                }
                else
                {
                    matrix[row, col] = --counter;
                }
            }
            counter += size;
        }
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("My matrix for you:\n");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("{0,-3} ", matrix[row, col]);
            }
            Console.WriteLine("\n");

        }
    }
}



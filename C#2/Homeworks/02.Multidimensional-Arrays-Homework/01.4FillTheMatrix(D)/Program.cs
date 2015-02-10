using System;

class FilTheMatrixD
{
    static void Main()
    {
        Console.Write("Enter a size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "right";
        int maxRotations = n * n;

        for (int i = 1; i <= maxRotations; i++)
        {
            if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
            {
                direction = "down";
                col--;
                row++;
            }
            if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
            {
                direction = "left";
                row--;
                col--;
            }
            if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            {
                direction = "up";
                col++;
                row--;
            }

            if (direction == "up" && row < 0 || matrix[row, col] != 0)
            {
                direction = "right";
                row++;
                col++;
            }

            matrix[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            if (direction == "down")
            {
                row++;
            }
            if (direction == "left")
            {
                col--;
            }
            if (direction == "up")
            {
                row--;
            }
        }
        // Display Matrix
        Console.WriteLine("My matrix for you:\n");
        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,-3}", matrix[c, r]);
            }
            Console.WriteLine("\n");
        }

        // SECOND WAY:

        //int offset = 0;
        //int ROW = 0;
        //int COL = 0;
        //while (digit <= n * n)            //Filling matrix
        //{
        //    for (ROW = offset; ROW < n - offset; ROW++)
        //    {
        //        COL = offset;
        //        matrix[ROW, COL] = digit;
        //        digit++;
        //    }
        //    for (COL = 1 + offset; COL < n - offset; COL++)
        //    {
        //        ROW = n - 1 - offset;
        //        matrix[ROW, COL] = digit;
        //        digit++;
        //    }
        //    for (ROW = n - 2 - offset; ROW >= offset; ROW--)
        //    {
        //        COL = n - 1 - offset;
        //        matrix[ROW, COL] = digit;
        //        digit++;
        //    }
        //    for (COL = n - 2 - offset; COL >= offset + 1; COL--)
        //    {
        //        ROW = offset;
        //        matrix[ROW, COL] = digit;
        //        digit++;
        //    }
        //    offset++;
        //}

        //for (int irow = 0; irow < n; irow++)           //Printing
        //{
        //    for (int column = 0; column < n; column++)
        //    {
        //        Console.Write("{0, 4}", matrix[irow, column]);
        //    }
        //    Console.WriteLine();
        //}
    }
}
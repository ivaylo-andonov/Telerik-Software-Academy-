//We are given a matrix of strings of size N x M. Sequences in the matrix
//we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Examples:
 //matrix:	          |  result:	|	matrix:	   |  result:
 //ha	 fi   ho  hi  | ha, ha, ha  |    s	qq	s  |  s, s, s
 //fo	 ha	  hi  xx                |    pp	pp	s  |
 //xx	 ho	  ha  xx                |    pp	qq	s  |                         
                                    
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter rows size:");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cols size:");
        int cols = int.Parse(Console.ReadLine());

        string[,] stringMatrix = new string[rows,cols];

        // Fill the matrix by reading from console
        for (int row = 0; row < stringMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1); col++)
            {
                Console.Write("stringMatrix[{0},{1}] = ", row, col);
                string element = Console.ReadLine();
                
                stringMatrix[row, col] = element;
            }
        }
        Console.WriteLine();

        FindLongestSequenceAndPrintMatrix(stringMatrix);
   
    }
    private static void FindLongestSequenceAndPrintMatrix(string[,]matrix)
    {
        bool onVertical = false;
        bool onHorizontal = false;
        bool onDiagonal = false;
        string bestElement = "";
        int currentLength = 0;
        int maxLength = 0;     

        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            // Check horizontally 
            currentLength = 0;
            for (int i = 0; i < matrix.GetLength(1) - 1; i++)
            {
                if (matrix[col, i] == matrix[col, i + 1])
                {
                    currentLength++;
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestElement = matrix[col, i];   
                    onHorizontal = true; onVertical = false; onDiagonal = false;
                }
            }
            //Check for verticcaly
            currentLength = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                if (matrix[i, col] == matrix[i + 1, col])
                {
                    currentLength++;
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestElement = matrix[i, col];
                    onHorizontal = false; onVertical = true; onDiagonal = false;
                }
            }
            //Check for diagonals
            currentLength = 0;
            for (int i = 0, j = 0; (i < matrix.GetLength(0)-1) && (j < matrix.GetLength(1)-1); i++, j++)
            {
                if (matrix[ i , j] == matrix[i + 1,j + 1])
                {
                    currentLength++;
                }
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    bestElement = matrix[i , j];
                    onHorizontal = false; onVertical = false; onDiagonal = true;
                }                                    
            }
        }
        // Print the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-4}", matrix[row, col]);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine("\n");
        }

        // Print the result
        Console.Write("The maximal sequence in the matrix is :\n");
        if (onHorizontal)
        {
            for (int i = 0; i < maxLength + 1; i++)
            {
                Console.Write("{0}, ", bestElement);
            }
            Console.WriteLine("from left to right on horizontal");
   
        }
        if (onVertical)
        {
            for (int i = 0; i < maxLength + 1; i++)
            {
                Console.Write("{0}, ", bestElement);
            }
            Console.WriteLine("from up to down on vertical");   
        }
        if (onDiagonal)
        {
            for (int i = 0; i < maxLength + 1; i++)
            {
                Console.Write("{0}, ", bestElement);
            }
            Console.WriteLine("on diagonal");   
        }    
    }
}


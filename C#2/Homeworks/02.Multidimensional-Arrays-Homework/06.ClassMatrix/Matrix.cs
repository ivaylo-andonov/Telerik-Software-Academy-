//06  * Class Matrix 
//Write a class Matrix, to hold a matrix of integers. Overload the operators for adding,
//subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
using System;

class Matrix
{
    static void Main()
    {
        // You are free to change the sizes of the matrices. That is just example to preview how it works :)

        ClassMatrix matrix1 = new ClassMatrix(2,2);
        for (int rows = 0; rows < matrix1.Rows; rows++)
        {
            for (int cols = 0; cols < matrix1.Cols; cols++)
            {
                Console.Write("matrix1 index[{0},{1}] = ",rows,cols);
                matrix1[rows, cols] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();

        ClassMatrix matrix2 = new ClassMatrix(2,2);
        for (int rows = 0; rows < matrix2.Rows; rows++)
        {
            for (int cols = 0; cols < matrix2.Cols; cols++)
            {
                Console.Write("matrix2 index[{0},{1}] = ", rows, cols);
                matrix2[rows, cols] = int.Parse(Console.ReadLine());
            }
        }

        // You can change the names,sizes and actions of the matrices.This is just example to preview how it works
        ClassMatrix sumOfMatrices = matrix1 + matrix2;
        ClassMatrix substractMatrices = matrix1 - matrix2;
        ClassMatrix multipliedMatrices = matrix1 * matrix2;

        Console.WriteLine("\nThe new summed matrix is:\n");
        Console.WriteLine(sumOfMatrices.ToString());

        Console.WriteLine("\nThe new substracted matrix is:\n");
        Console.WriteLine(substractMatrices.ToString());

        Console.WriteLine("\nThe new multiplied matrix is:\n");
        Console.WriteLine(multipliedMatrices.ToString());
    }
}


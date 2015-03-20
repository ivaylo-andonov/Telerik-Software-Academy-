namespace _03.MatrixT_8_10_
{
    using System;

    class MatrixTest
    {
        static void Main()
        {
            // You are free to change the sizes of the matrices. That is just example to preview how it works :)

            MatrixT<int> matrix1 = new MatrixT<int>(3, 3);
            FillTheMatrix(matrix1);
            Console.WriteLine(Environment.NewLine);

            MatrixT<int> matrix2 = new MatrixT<int>(3, 3);
            FillTheMatrix(matrix2);
            Console.WriteLine(Environment.NewLine);

            // You can change the names,sizes and actions of the matrices.This is just example to preview how it works
            MatrixT<int> sumOfMatrices = matrix1 + matrix2;
            MatrixT<int> substractMatrices = matrix1 - matrix2;
            MatrixT<int> multipliedMatrices = matrix1 * matrix2;
            //Console.Clear();

            Console.WriteLine("\nThe new summed matrix is:\n");
            Console.WriteLine(sumOfMatrices.ToString());

            Console.WriteLine("\nThe new substracted matrix is:\n");
            Console.WriteLine(substractMatrices.ToString());

            Console.WriteLine("\nThe new multiplied matrix is:\n");
            Console.WriteLine(multipliedMatrices.ToString());
        }

        public static MatrixT<int> FillTheMatrix(MatrixT<int> matrix)
        {
            for (int row = 0; row < matrix.Rows ; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    Console.Write("matrix1 index[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
    }

}

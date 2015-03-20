namespace _03.MatrixT_8_10_
{
    using System;
    using System.Text;

    public class MatrixT<T> where T: IComparable
    {
        // Fields
        private T[,] matrix;
        private int rows;
        private int cols;

        //Constructor
        public MatrixT (int row,int col)
        {
            this.Rows = row;
            this.Cols = col;
            this.matrix = new T[ Rows,Cols];
        }
        
        // INDEXATOR
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0 || row > this.Rows) || (col < 0 || col > this.Cols))
                {
                    throw new ArgumentException("Invalid values.Out of range indexes");
                }
                return this.matrix[row, col];
            }
            set
            {
                if ((row < 0 || row > this.Cols) || (col < 0 || col > this.Cols))
                {
                    throw new ArgumentException("Invalid values.Out of range indexes");
                }
                this.matrix[row, col] = value;
            }
        }

        // PROPERTY
        public int Rows
        {
            get
            {
                return this.rows;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rows count must be greater than 0");
                }
                this.rows = value;
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Colums count must be greater than 0");
                }
                this.cols = value;
            }
        }

        // Create operator ' + '
        public static MatrixT<T> operator +(MatrixT<T> matrixOne, MatrixT<T> matrixTwo)
        {
            MatrixT<T> resultMatrix = new MatrixT<T>(matrixOne.Rows, matrixOne.Cols);

            if (matrixOne.Rows == matrixTwo.Rows && matrixOne.Cols == matrixTwo.Cols)
            {
                for (int rows = 0; rows < matrixOne.Rows; rows++)
                {
                    for (int cols = 0; cols < matrixOne.Cols; cols++)
                    {
                        resultMatrix[rows, cols] = (dynamic)matrixOne[rows, cols] + matrixTwo[rows, cols];
                    }
                }
            }
            else
            {
                throw new ArgumentException("\nThe matrices have different sizes!\nThey must be equals.");
            }

            return resultMatrix;
        }

        // Create operator ' - '
        public static MatrixT<T> operator -(MatrixT<T> matrixOne, MatrixT<T> matrixTwo)
        {
            MatrixT<T> resultMatrix = new MatrixT<T>(matrixOne.Rows, matrixOne.Cols);

            if (matrixOne.Rows == matrixTwo.Rows && matrixOne.Cols == matrixTwo.Cols)
            {
                for (int rows = 0; rows < matrixOne.Rows; rows++)
                {
                    for (int cols = 0; cols < matrixOne.Cols; cols++)
                    {
                        resultMatrix[rows, cols] = (dynamic)matrixOne[rows, cols] - matrixTwo[rows, cols];
                    }
                }
            }
            else
            {
                throw new ArgumentException("\nThe matrices have different sizes!\nThey must be equal.");
            }
            return resultMatrix;
        }

        //Create operator for multiplying
        public static MatrixT<T> operator *(MatrixT<T> matrixOne, MatrixT<T> matrixTwo)
        {
            MatrixT<T> resultMatrix = new MatrixT<T>(matrixOne.Rows, matrixTwo.Cols);

            if (matrixOne.Cols != matrixTwo.Rows)
            {
                throw new ArgumentException("Imposibble operation:\nThe colums of first matrice are not equal to rows of second matrice!");
            }

            else if (matrixOne.Cols == matrixTwo.Rows)
            {
                for (int rows = 0; rows < resultMatrix.Rows; rows++)
                {
                    for (int cols = 0; cols < resultMatrix.Cols; cols++)
                    {
                        for (int i = 0; i < matrixOne.Cols; i++)
                        {
                            resultMatrix[rows, cols] += (dynamic)matrixOne[rows, i] * matrixTwo[i, cols];
                        }
                    }
                }
            }
            return resultMatrix;
        }

        // Create operator TRUE
        public static bool operator true(MatrixT<T> matrix)
        {

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        // Create operator FALSE
        public static bool operator false(MatrixT<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //Make override method ToString(). This method visualize the matrix,like own made mathod PrintMatrix;
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    result.Append(matrix[i, j] + "\t");
                }
                result.Append(Environment.NewLine);
                result.Append(Environment.NewLine);

            }
            return result.ToString();
        }
    }
}

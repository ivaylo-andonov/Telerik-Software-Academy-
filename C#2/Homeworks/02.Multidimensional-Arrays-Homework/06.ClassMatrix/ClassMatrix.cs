using System;

class ClassMatrix
{
    // Declare name of matrice in our class
    private int[,] myMatrix;

    //Create Constructor for class ClassMatrix to define his parameters,
    //in this case we need out ClassMatrix to has rows and cols: [rows , cols]
    public ClassMatrix(int rows, int cols)
    {
        this.myMatrix = new int[rows, cols];
    }

    // Create a indexator for class ClassMatrix,when we want to initialize some index
    //of our ClassMatrix with value ( ClassMatrix[row,col] = Console.ReadLine();)
    public int this[int row, int col]
    {
        get
        {
            return this.myMatrix[row, col];
        }
        set
        {
            this.myMatrix[row, col] = value;
        }
    }

    //Create a property Rows
    public int Rows
    {
        get
        {
            return this.myMatrix.GetLength(0);
        }       
    }

    //Create a preperty Cols
    public int Cols
    {
        get
        {
            return this.myMatrix.GetLength(1);
        }
    }

    //Create property MaxLength ( count of cells int the matrice )
    public int MaxLength
    {
        get
        {
            return this.Rows * this.Cols;
        }
    }

    // Create operator ' + '
    public static ClassMatrix operator +( ClassMatrix matrixOne , ClassMatrix matrixTwo)
    {
        ClassMatrix resultMatrix = new ClassMatrix(matrixOne.Rows,matrixOne.Cols);

        if (matrixOne.Rows == matrixTwo.Rows && matrixOne.Cols == matrixTwo.Cols)
        {
            for (int rows = 0; rows < matrixOne.Rows; rows++)
            {
                for (int cols = 0; cols < matrixOne.Cols; cols++)
                {
                    resultMatrix[rows, cols] = matrixOne[rows, cols] + matrixTwo[rows, cols];
                }
            } 
        }
        else
        {
            Console.WriteLine("\nThe matrices have different sizes");
        }
        
        return resultMatrix;
    }

    // Create operator ' - '
    public static ClassMatrix operator -(ClassMatrix matrixOne, ClassMatrix matrixTwo)
    {
        ClassMatrix resultMatrix = new ClassMatrix(matrixOne.Rows, matrixOne.Cols);

        if (matrixOne.Rows == matrixTwo.Rows && matrixOne.Cols == matrixTwo.Cols)
        {
            for (int rows = 0; rows < matrixOne.Rows; rows++)
            {
                for (int cols = 0; cols < matrixOne.Cols; cols++)
                {
                    resultMatrix[rows, cols] = matrixOne[rows, cols] - matrixTwo[rows, cols];
                }
            }
        }
        else
        {
            Console.WriteLine("\nThe matrices have different sizes");
        }

        return resultMatrix;
    }

    //Create operator for multiplying
    public static ClassMatrix operator *(ClassMatrix matrixOne, ClassMatrix matrixTwo)
    {
        ClassMatrix resultMatrix = new ClassMatrix(matrixOne.Rows, matrixTwo.Cols);

        if (matrixOne.Cols != matrixTwo.Rows)
        {            
            Console.WriteLine("\nImposibble operation:\nThe colums of first matrice are not equal to rows of second matrice");
        }

        else if (matrixOne.Cols == matrixTwo.Rows)
        {
            for (int rows = 0; rows < resultMatrix.Rows; rows++)
            {
                for (int cols = 0; cols < resultMatrix.Cols; cols++)
                {
                    for (int i = 0; i < matrixOne.Cols; i++)
                    {
                        resultMatrix[rows, cols] += matrixOne[rows, i] * matrixTwo[i, cols];                       
                    }
                }
            }             
        }
        return resultMatrix;       
    }

    //Make override method ToString(). This method visualize the matrix,like own made mathod PrintMatrix;
    public override string ToString()
    {
        string result = null;
        for (int i = 0; i < this.Rows; i++)
        {
            for (int j = 0; j < this.Cols; j++)
            {
                result += myMatrix[i, j] + " ";
            }
            result += Environment.NewLine;
        }
        return result;   
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());        
        int[][] field = new int[rows][];
        long max = long.MinValue;

        ReadInput(field);
       
        bool[][] used = new bool[rows][];
        for (int i = 0; i < rows; i++)
        {
            used[i] = new bool[field[i].Length];
        }
        
        for (int i = 0; i < field[0].Length; i++)
        {
            long specialValue = FindCurrentSpecialValue(field,i, used);

            if (max < specialValue)
            {
                max = specialValue;
            }
        }
        Console.WriteLine(max);
    }

    private static long FindCurrentSpecialValue(int[][] field, int col, bool[][] used)
    {
        long result = 0;
        int currentRow = 0;

        for (int i = 0; i < used.GetLength(0); i++)
        {
            used[i] = new bool[field[i].Length];
        }

        while (true)
        {
            result++;

            if (field[currentRow][col] < 0)
            {
                result += Math.Abs(field[currentRow][col]);
                return result;
            }

            int nextCol = field[currentRow][col];
            used[currentRow][col] = true;
            col = nextCol;  
         
            currentRow++;

            if (currentRow == field.GetLength(0))
            {
                currentRow = 0;
            }
        }
    }

    private static int[][] ReadInput(int[][] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            field[i] = new int[currentLine.Length];

            for (int j = 0; j < currentLine.Length; j++)
            {
                field[i][j] = int.Parse(currentLine[j]);
            }
        }
        return field;
    }
}


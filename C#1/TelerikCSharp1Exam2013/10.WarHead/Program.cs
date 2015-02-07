using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[,] board = new int[16, 16];

        for (int i = 0; i < 16; i++)
        {
            string currentLine = Console.ReadLine();
            for (int j = 0; j < 16 ; j++)
            {
                char currentSymbol = currentLine[j];
                board[i, j] = currentSymbol - '0';
            }
        }
        while (true)
        {
            string currentOperatio = Console.ReadLine();
            if (currentOperatio == "hover" || currentOperatio == "operate")
            {

            }
        }

        //Console.WriteLine();
        //for (int i = 0; i < 16; i++)
        //{
        //    for (int j = 0; j < 16; j++)
        //    {

        //        Console.Write(board[i,j]);
        //    }
        //    Console.WriteLine();
        //}
         
    }
}


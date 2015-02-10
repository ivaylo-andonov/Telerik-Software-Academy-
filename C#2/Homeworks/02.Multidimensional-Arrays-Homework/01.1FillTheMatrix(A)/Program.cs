using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter N size of the matrix:");
        int size = int.Parse(Console.ReadLine());

        int[,] matrix = new int[size, size];
        int counter = 1;
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                matrix[row, col] = counter;
                counter++;
            }
            
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("My matrix for you:\n");
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("{0,-3} ",matrix[col,row]);
            }
            Console.WriteLine("\n");
        }
    }
}


namespace Problem_3
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

   internal class MatrixGame
    {
       public static void Main()
        {
            int[] sizeOfMatrix = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            int row = sizeOfMatrix[0];
            int col = sizeOfMatrix[1];

            long resultSum = 0;

            // Set's the starting row and col 
            int startRow = row - 1;
            int startCol = 0;

            int amountOfMoves = int.Parse(Console.ReadLine());
            // Contains all the commands(RU 10, LD 5....)
            string[] playCommands = new string[amountOfMoves];

            for (int i = 0; i < amountOfMoves; i++)
            {
                playCommands[i] = Console.ReadLine();
            }

            int[,] playField = new int[row, col];
            GenerateMatrix(sizeOfMatrix, row, playField);

            int currentRow = startRow;
            int currentCol = startCol;
            for (int i = 0; i < amountOfMoves; i++)
            {
                // A regex that extracts the number (amount of moves)
                string resultString = Regex.Match(playCommands[i], @"\d+").Value;
                int amountOfSteps = int.Parse(resultString);
                // Extracts the first two letters (direction)
                string directionToMove = playCommands[i].Substring(0, 2);
                // Gives the abillity to work with only 4 string commands
                if (directionToMove == "UR")
                {
                    directionToMove = "RU";
                }
                else if (directionToMove == "UL")
                {
                    directionToMove = "LU";
                }
                else if (directionToMove == "DR")
                {
                    directionToMove = "RD";
                }
                else if (directionToMove == "DL")
                {
                    directionToMove = "LD";
                }

                switch (directionToMove)
                {
                    case "RU": // Moving right up
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            currentRow--;
                            currentCol++;
                            if (!InRange(currentRow, currentCol, row, col))
                            {
                                // Before breaking the switch-case the row and col are set back to the previous location
                                currentRow++;
                                currentCol--;
                                break;
                            }

                            // Adds the number to the final result
                            resultSum += playField[currentRow, currentCol];
                            // sets the number at [row,col] to 0 to ensure it doesn't get added again in a future move
                            playField[currentRow, currentCol] = 0;
                        }
                        break;
                    case "LU": // Moving left up
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            currentRow--;
                            currentCol--;
                            if (!InRange(currentRow, currentCol, row, col))
                            {
                                currentRow++;
                                currentCol++;
                                break;
                            }

                            resultSum += playField[currentRow, currentCol];
                            playField[currentRow, currentCol] = 0;
                        }

                        break;
                    case "RD": // Moving right down                                    
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            currentRow++;
                            currentCol++;
                            if (!InRange(currentRow, currentCol, row, col))
                            {
                                currentRow--;
                                currentCol--;
                                break;
                            }

                            resultSum += playField[currentRow, currentCol];
                            playField[currentRow, currentCol] = 0;
                        }
                        break;
                    case "LD": // Moving left down 
                        for (int j = 0; j < amountOfSteps - 1; j++)
                        {
                            currentRow++;
                            currentCol--;
                            if (!InRange(currentRow, currentCol, row, col))
                            {
                                currentRow--;
                                currentCol++;
                                break;
                            }

                            resultSum += playField[currentRow, currentCol];
                            playField[currentRow, currentCol] = 0;
                        }
                        break;
                }
            }
            // After the for loop runs thru all the moves the result is printed
            Console.WriteLine(resultSum);
        }

        private static bool InRange(int currentRow, int currentCol, int maxRow, int maxCol)
        {
            bool inRange = currentRow < 0 || currentRow > maxRow || currentCol < 0 || currentCol >= maxCol;
            return inRange;
        }

        private static void GenerateMatrix(int[] sizeOfMatrix, int row, int[,] matrix)
        {
            // Top left number in the matrix
            int number = (row - 1) * 3;
            for (int currentRow = 0; currentRow < sizeOfMatrix[0]; currentRow++)
            {
                int finalNum = number;
                for (int currentCol = 0; currentCol < sizeOfMatrix[1]; currentCol++)
                {
                    matrix[currentRow, currentCol] = finalNum;
                    finalNum += 3;
                }
                number -= 3;
            }
        }
    }
}
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        int numberOfGames = int.Parse(Console.ReadLine());
        BigInteger playerOneTotalScore = 0;
        BigInteger playerTwoTotalScore = 0;
        int player1gamesWon = 0;
        int player2gamesWon = 0;
        bool playerOneHasXcard = false;
        bool playerTwoHasXcard = false;

        for (int i = 0; i < numberOfGames; i++)
        {
            BigInteger playerOneHandScore = 0;
            BigInteger playerTwoHandScore = 0;

            for (int k = 0; k < 3; k++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": playerOneHandScore += 1; break;
                    case "K": playerOneHandScore += 13; break;
                    case "Q": playerOneHandScore += 12; break;
                    case "J": playerOneHandScore += 11; break;
                    case "X": playerOneHasXcard = true; break;
                    case "Y": playerOneTotalScore -= 200; break;
                    case "Z": playerOneTotalScore *= 2; break;
                     default: playerOneHandScore += 12 - int.Parse(card); break;
                }       
            }
            for (int j = 0; j < 3; j++)
            {
                string card = Console.ReadLine();
                switch (card)
                {
                    case "A": playerTwoHandScore += 1; break;
                    case "K": playerTwoHandScore += 13;break;
                    case "Q": playerTwoHandScore += 12; break;
                    case "J": playerTwoHandScore += 11; break;
                    case "X": playerTwoHasXcard = true; break;
                    case "Y": playerTwoTotalScore -= 200; break;
                    case "Z": playerTwoTotalScore *= 2; break;
                     default: playerTwoHandScore += 12 - int.Parse(card); break;
                }
            }
            if (playerTwoHasXcard && playerOneHasXcard)
            {
                playerOneTotalScore += 50;
                playerTwoTotalScore += 50;
            }
            else if (playerOneHasXcard)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (playerTwoHasXcard)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            if (playerOneHandScore > playerTwoHandScore)
            {
                playerOneTotalScore += playerOneHandScore;
                player1gamesWon++;
            }
            else if (playerTwoHandScore > playerOneHandScore)
            {
                playerTwoTotalScore += playerTwoHandScore;
                player2gamesWon++;
            }
        }
        if (playerOneTotalScore == playerTwoTotalScore)
        {
            Console.WriteLine(@"It's a tie!
Score: {0}

",playerTwoTotalScore);
        }
        else if (playerOneTotalScore > playerTwoTotalScore)
        {
            Console.WriteLine(@"First player wins!
Score: {0}
Games won: {1}
",playerOneTotalScore,player1gamesWon);
           
        }
        else if (playerOneTotalScore < playerTwoTotalScore)
        {
            Console.WriteLine(@"Second player wins!
Score: {0}
Games won: {1}
",playerTwoTotalScore,player2gamesWon);
            
        }

    }
}



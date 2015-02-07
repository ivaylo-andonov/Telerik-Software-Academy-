using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        byte[] playCards = new byte[13];
        bool isFourIfKind = false, isThreeOfKind = false, isOnePair = false, isTwoPairs = false, isFullHouse = false,
             Impossible = false, isStraight = false;

        for (int i = 0; i < 5; i++)
        {
            string card = Console.ReadLine();
            switch (card)
            {
                case "A": playCards[0]++;  break;
                case "2": playCards[1]++;  break;
                case "3": playCards[2]++;  break;
                case "4": playCards[3]++;  break;
                case "5": playCards[4]++;  break;
                case "6": playCards[5]++;  break;
                case "7": playCards[6]++;  break;
                case "8": playCards[7]++;  break;
                case "9": playCards[8]++;  break;
                case "10":playCards[9]++;  break;
                case "J": playCards[10]++; break;
                case "Q": playCards[11]++; break;
                case "K": playCards[12]++;  break;
            }
        }
        for (int i = 0; i < playCards.Length; i++)
        {
            if (playCards[i] == 2 )
            {
                for (int k = i + 1; k < playCards.Length; k ++)
                {
                    if (playCards[k] == 2)  isTwoPairs = true; 
                }
                for (int j = i + 1; j <playCards.Length; j++)
                {
                    if (playCards[j] != 2) isOnePair = true;
                }  
            }
            if (playCards[i] == 5) Impossible = true;
            else if (playCards[i] == 4) isFourIfKind = true;
            else if (playCards[i] == 3) isThreeOfKind = true;
            else if (isThreeOfKind && isOnePair) isFullHouse = true;
            else if (( i<=8 && playCards[i]==1 && playCards[i+1]==1 && playCards[i+2]==1 && playCards[i+3]==1 && playCards[i+4]==1)
                || (playCards[9] == 1 && playCards[10] == 1 && playCards[11] == 1 && playCards[12] == 1 && playCards[0] == 1))
            {
                isStraight = true;
                break;
            }
        }
        if (Impossible) Console.WriteLine("Impossible");
        else if (isStraight) Console.WriteLine("Straight");
        else if (isFourIfKind) Console.WriteLine("Four of a Kind");
        else if (isFullHouse) Console.WriteLine("Full House");
        else if (isThreeOfKind) Console.WriteLine("Three of a Kind");
        else if (isTwoPairs) Console.WriteLine("Two Pairs");
        else if (isOnePair) Console.WriteLine("One Pair");
        else  Console.WriteLine("Nothing"); 
    }
}
 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        List<int> result = new List<int>();
        char signUsedSecretNum = '*';
        char signUsedGuessNum = '@';

        for (int currentNumber = 1111; currentNumber <= 9999; currentNumber++)
        {
            int foundedBUlls = 0;
            int foundedCows = 0;
            char[] secretNum = secretNumber.ToString().ToCharArray();
            char[] guessNum = currentNumber.ToString().ToCharArray();

            if (guessNum[0] >= '1' && guessNum[1] >= '1' && guessNum[2] >= '1' && guessNum[3] >= '1')
            {
                for (int i = 0; i < secretNum.Length; i++)
                {
                    if (secretNum[i] == guessNum[i])
                    {
                        foundedBUlls++;
                        secretNum[i] = signUsedSecretNum;
                        guessNum[i] = signUsedGuessNum;
                    }
                }
                for (int i = 0; i < secretNum.Length; i++)
                {
                    for (int j = 0; j < guessNum.Length; j++)
                    {
                        if (guessNum[j] == secretNum[i])
                        {
                            foundedCows++;
                            secretNum[i] = signUsedSecretNum;
                            guessNum[j] = signUsedGuessNum;
                        }
                    }
                }
                if (bulls == foundedBUlls && cows == foundedCows)
                {
                    result.Add(currentNumber);
                }
            }
        }
        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " " );
            }
        }
    }
}


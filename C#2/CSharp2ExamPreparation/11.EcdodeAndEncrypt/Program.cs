using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        // Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
        string message = Console.ReadLine();
        string cypher = Console.ReadLine();
        var result = new StringBuilder();

        result.Append(Encrypt(message, cypher));
        result.Append(cypher);

        Console.WriteLine(Encoder(result.ToString()) + cypher.Length);
    }

    private static string Encoder(string encodedMassage)
    {
        string encodingMassage = "";
        int countOfDigit = 1;
        for (int i = 0; i < encodedMassage.Length - 1; i++)
        {
            if (encodedMassage[i] == encodedMassage[i + 1])
            {
                if (i == encodedMassage.Length - 2 && countOfDigit > 1)
                {
                    encodingMassage += countOfDigit + 1;
                    encodingMassage += encodedMassage[i];
                }
                if (i == encodedMassage.Length - 2 && countOfDigit <= 1)
                {
                    encodingMassage += encodedMassage[i];
                    encodingMassage += encodedMassage[i];
                }
                countOfDigit++;
            }
            else if (encodedMassage[i] != encodedMassage[i + 1])
            {
                if (i == encodedMassage.Length - 2)
                {
                    if (countOfDigit == 1)
                    {
                        encodingMassage += encodedMassage[i];
                        encodingMassage += encodedMassage[i + 1];
                    }
                    else if (countOfDigit == 2)
                    {
                        encodingMassage += encodedMassage[i];
                        encodingMassage += encodedMassage[i];
                        encodingMassage += encodedMassage[i + 1];
                    }
                    else if (countOfDigit > 2)
                    {
                        encodingMassage += countOfDigit;
                        encodingMassage += encodedMassage[i];
                        encodingMassage += encodedMassage[i + 1];
                    }
                }
                else
                {
                    if (countOfDigit > 2)
                    {
                        encodingMassage += countOfDigit;
                        encodingMassage += encodedMassage[i];
                    }
                    else
                    {
                        if (countOfDigit > 1)
                        {
                            encodingMassage += encodedMassage[i];
                            encodingMassage += encodedMassage[i];
                        }
                        else if (countOfDigit == 1)
                        {
                            encodingMassage += encodedMassage[i];
                        }
                    }
                }
                countOfDigit = 1;
            }
        }
        return encodingMassage;
    }

    private static string Encrypt(string message, string cypher)
    {
        var encryptedResult = new StringBuilder(message);
        int steps = Math.Max(message.Length, cypher.Length);
        for (int i = 0; i < steps; i++)
        {
            var messageIndex = i % message.Length;
            var cypherIndex = i % cypher.Length;
            encryptedResult[messageIndex] = (char)(((encryptedResult[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
        }

        return encryptedResult.ToString();
    }
}


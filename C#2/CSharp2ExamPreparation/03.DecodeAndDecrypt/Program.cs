using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {

        // Encode(Encrypt(message, cypher) + cypher) + lengthOfCypher
        string input = Console.ReadLine();

        // Find length ot the cypher
        var digits = new List<int>();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                digits.Add(input[i] - '0');
            }
            else
            {
                break;
            }
        }
        digits.Reverse();
        int lengthOfCypher = 0;
        foreach (var digit in digits)
        {
            lengthOfCypher *= 10;
            lengthOfCypher += digit;
        }

        // Encode(Encrypt(message, cypher) + cypher)
        var encodedMassage = input.Substring(0, input.Length - digits.Count);

        //Encrypt(message, cypher) + cypher
        var decodedMassage = Decoder(encodedMassage);

        //Encrypt(massage,cypher);
        var encryptedMassage = decodedMassage.Substring(0, decodedMassage.Length - lengthOfCypher);

        //cypher
        var cypher = decodedMassage.Substring( decodedMassage.Length - lengthOfCypher, lengthOfCypher);

        var message = Encrypt(encryptedMassage, cypher);
        Console.WriteLine(message);

    }

    private static string Encrypt(string message, string cypher)
    {
        var result = new StringBuilder(message);
        int steps = Math.Max(message.Length, cypher.Length);
        for (int i = 0; i < steps; i++)
        {
            var messageIndex = i % message.Length;
            var cypherIndex = i % cypher.Length;
            result[messageIndex] = (char)(((result[messageIndex] - 'A') ^ (cypher[cypherIndex] - 'A')) + 'A');
        }
        return result.ToString() ;
    }

    private static string Decoder(string encodedMassage)
    {
        var result = new StringBuilder();
        int countOfDigit = 0;
        foreach (var ch in encodedMassage)
        {
            if (char.IsDigit(ch))
	        {
                countOfDigit *= 10;
                countOfDigit += ch - '0';
	        }
            else
            {
                if (countOfDigit == 0)
                {
                    result.Append(ch);
                }
                else
                {
                    result.Append(ch, countOfDigit);
                    countOfDigit = 0;
                }
            }            
        }
        return result.ToString();
        
    }
}


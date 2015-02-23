using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        long result = 0;
        long temp = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            string zergNUm = input.Substring(i, 3);
            temp = 0;
            switch (zergNUm)
            {
                case "CHU": temp = 0; break;
                case "TEL": temp = 1; break;
                case "OFT": temp = 2; break;
                case "IVA": temp = 3; break;
                case "EMY": temp = 4; break;
                case "VNB": temp = 5; break;
                case "POQ": temp = 6; break;
                case "ERI": temp = 7; break;
                case "CAD": temp = 8; break;
                case "K-A": temp = 9; break;
                case "IIA": temp = 10; break;
                case "YLO": temp = 11; break;
                case "PLA": temp = 12; break;

            }
            result = result * 13 + temp;
        }
        Console.WriteLine(result);
    }
}






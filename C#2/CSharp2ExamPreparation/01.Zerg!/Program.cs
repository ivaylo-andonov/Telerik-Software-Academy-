using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        long result = 0;
        long temp = 0;
        for (int i = 0; i < input.Length; i += 4)
        {
            string zergNUm = input.Substring(i , 4);
            temp = 0;
            switch (zergNUm)
            {
                case "Rawr": temp = 0; break;
                case "Rrrr": temp = 1; break;
                case "Hsst": temp = 2; break;
                case "Ssst": temp = 3; break;
                case "Grrr": temp = 4; break;
                case "Rarr": temp = 5; break;
                case "Mrrr": temp = 6; break;
                case "Psst": temp = 7; break;
                case "Uaah": temp = 8; break;
                case "Uaha": temp = 9; break;
                case "Zzzz": temp = 10; break;
                case "Bauu": temp = 11; break;
                case "Djav": temp = 12; break;
                case "Myau": temp = 13; break;
                case "Gruh": temp = 14; break;
            }
            result = result * 15 + temp;
        }
        Console.WriteLine(result);
    }
}






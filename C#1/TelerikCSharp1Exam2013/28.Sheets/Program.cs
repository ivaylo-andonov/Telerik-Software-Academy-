using System;


class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int[] sheetsValues = new int[11] { 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

        for (int i = 0; i < sheetsValues.Length; i++)
        {
            if (N < sheetsValues[i])
            {
                Console.WriteLine("A" + i);
            }
            else
            {
                N -= sheetsValues[i];
            }
        }
    }
}


using System;

class Program
{
    static void Main()
    {
        long S = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        long[] numbers = new long[N];
        int count = 0;
        long currentSum = 0;

        for (int i = 0; i < N; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= Math.Pow(2, N) - 1; i++)
        {
            currentSum = 0;
            string binatyNumber = Convert.ToString(i, 2).PadLeft(N, '0');
            for (int j = 0; j < binatyNumber.Length; j++)
            {
                if (binatyNumber[j].ToString() == "1")
                {
                    currentSum += numbers[j];
                }
            }
            if (currentSum == S)
            {
                count++;
            }

        }
        Console.WriteLine(count);
    }

}




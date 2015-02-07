using System;

class Program
{
    static void Main()
    {
        
        string stringNumber = Console.ReadLine();
        long oddSUm = 0;
        long EvenSum = 0;
        for (int i = 0; i < stringNumber.Length; i++)
        {
            bool check = char.IsDigit(stringNumber[i]);
            if ((stringNumber[i]) % 2 == 0 && check)
            {
                EvenSum += stringNumber[i] - '0';
            }
            else if (stringNumber[i] % 2 != 0 && check)
            {
                oddSUm += stringNumber[i] -'0';
            }
        }
        if (EvenSum > oddSUm)
        {
            Console.WriteLine("right {0}", EvenSum);
        }
        else if (oddSUm > EvenSum)
        {
            Console.WriteLine("left {0}", oddSUm);
        }
        else
        {
            Console.WriteLine("straight {0}", oddSUm);
        }
    }
}


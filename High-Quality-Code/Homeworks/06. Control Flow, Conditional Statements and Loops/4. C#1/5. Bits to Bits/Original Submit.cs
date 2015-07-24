using System;

class Bits2Bits
{
    static void Main()
    {
        //Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        string number = "";
        char[] bits = new char[n*30];
        int charCount = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
            number = Convert.ToString(nums[i], 2).PadLeft(30,'0');

            for (int ii = 0; ii < 30; ii++)
            {
                bits[charCount] = number[ii];
                charCount++;
            }
        }

        int zeroCount = 0;
        int maxZero = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '0')
            {
                zeroCount++;
                maxZero = (maxZero >= zeroCount) ? maxZero : zeroCount;
            }
            else
            {
                zeroCount = 0;
            }
        }

        int oneCount = 0;
        int maxOne = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i] == '1')
            {
                oneCount++;
                maxOne = (maxOne >= oneCount) ? maxOne : (oneCount);
            }
            else
            {
                oneCount = 0;
            }
        }

        Console.WriteLine(maxZero);
        Console.WriteLine(maxOne);
    }
}

namespace Bits2Bits
{
    using System;

    public class Start
    {
        private const int BitsToExtractCount = 30;

        public static void Main()
        {
            // Console.Write("Enter N: ");
            int numbersCount = int.Parse(Console.ReadLine());
            char[] allBits = new char[numbersCount * BitsToExtractCount];
            int allExtractedBitsCount = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                string currentNumberExtractedBits = Convert.ToString(currentNumber, 2).PadLeft(BitsToExtractCount, '0');

                for (int j = 0; j < BitsToExtractCount; j++, allExtractedBitsCount++)
                {
                    allBits[allExtractedBitsCount] = currentNumberExtractedBits[j];
                }
            }

            int currentZerosSequenceCount = 0;
            int maxZerosSequenceCount = 0;
            int currentOnesSequenceCount = 0;
            int maxOnesSequenceCount = 0;

            for (int i = 0; i < allBits.Length; i++)
            {
                if (allBits[i] == '0')
                {
                    currentZerosSequenceCount++;
                    maxZerosSequenceCount = (maxZerosSequenceCount >= currentZerosSequenceCount) ? maxZerosSequenceCount : currentZerosSequenceCount;
                }
                else
                {
                    currentZerosSequenceCount = 0;
                }

                if (allBits[i] == '1')
                {
                    currentOnesSequenceCount++;
                    maxOnesSequenceCount = (maxOnesSequenceCount >= currentOnesSequenceCount) ? maxOnesSequenceCount : currentOnesSequenceCount;
                }
                else
                {
                    currentOnesSequenceCount = 0;
                }
            }

            Console.WriteLine(maxZerosSequenceCount);
            Console.WriteLine(maxOnesSequenceCount);
        }
    }
}

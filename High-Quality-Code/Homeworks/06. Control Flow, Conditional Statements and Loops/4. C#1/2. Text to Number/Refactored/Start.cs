namespace Text2Num
{
    using System;

    public class Start
    {
        private const int BreakCharCode = (int)'@';

        private const int FirstDigitCode = (int)'0';
        private const int LastDigitCode = (int)'9';

        private const int FirstCapitalLetterCode = (int)'A';
        private const int LastCapitalLetterCode = (int)'Z';

        private const int FirstLowerLetterCode = (int)'a';
        private const int LastLowerLetterCode = (int)'z';

        public static void Main()
        {
            // Console.Write("Enter M: ");
            int moduleDivider = int.Parse(Console.ReadLine());

            // Console.Write("Enter string: ");
            string inputString = Console.ReadLine();

            int result = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                int currentCharCode = (int)inputString[i];

                // Console.WriteLine(currentCharCode);
                if (currentCharCode == BreakCharCode)
                {
                    break;
                }
                else if (FirstDigitCode <= currentCharCode && currentCharCode <= LastDigitCode)
                {
                    int digit = currentCharCode - FirstDigitCode;
                    result *= digit;
                }
                else if (FirstCapitalLetterCode <= currentCharCode && currentCharCode <= LastCapitalLetterCode)
                {
                    int letterNumber = currentCharCode - FirstCapitalLetterCode;
                    result += letterNumber;
                }
                else if (FirstLowerLetterCode <= currentCharCode && currentCharCode <= LastLowerLetterCode)
                {
                    int letterNumber = currentCharCode - FirstLowerLetterCode;
                    result += letterNumber;
                }
                else
                {
                    result %= moduleDivider;
                }
            }

            Console.WriteLine(result);
        }
    }
}

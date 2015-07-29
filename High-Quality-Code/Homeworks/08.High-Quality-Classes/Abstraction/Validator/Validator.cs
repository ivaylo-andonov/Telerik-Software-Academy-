namespace Abstraction.Validator
{
    using System;

    public class Validator
    {
        public static void CheckForNegativeValue(double number, string message)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string input, string message)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}

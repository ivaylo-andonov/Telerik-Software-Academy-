namespace _01.StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class StringBuilderSubstring
    {     
        public static StringBuilder Substring(this StringBuilder strb ,int index, int length)
        {

            var result = new StringBuilder();

            if (index < 0 || index > strb.Length)
            {
                throw new ArgumentException("Invalid index!");
            }
            if (length > index + strb.Length || length < 0)
            {
                throw new ArgumentException("Invalid length!");
            }

            for (int pos = 0; pos < length; pos++)
            {
                result.Append(strb[index + pos]);
            }

            return result;
        }

    }
}

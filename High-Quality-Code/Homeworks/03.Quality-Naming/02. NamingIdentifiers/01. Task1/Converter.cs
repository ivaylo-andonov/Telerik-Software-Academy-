namespace BoolToString
{
    using System;

    internal class Converter
    {
        internal void ConvertBoolToString(bool value)
        {
            string valueToString = value.ToString();
            Console.WriteLine(valueToString);
        }
    }
}

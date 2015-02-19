//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada. 

using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        string input = "I was born at 28.05.1992 .In 1995 I felt down on the street from my bike.At 3.03.2014 I got married.";
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            try
            {
                DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy",
                            CultureInfo.InvariantCulture);
                Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());        
            }
            catch (FormatException)
            {
            }
        }
    }
}


//Write a method that returns the last digit of given integer as an English word.
//Examples:
//input:	output:
//512	    two
//1024	    four
//12309	    nine

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter some integer:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe last digit of {0} is {1}",number,GetEnglishDigit(number));
    }
    private static string GetEnglishDigit(int number)
    {
        string digitAsWord = string.Empty;
        int lastDigit = number % 10;
        switch (lastDigit)
        {
            case 0: digitAsWord += "zero"; break;
            case 1: digitAsWord += "one"; break;
            case 2: digitAsWord += "two"; break;
            case 3: digitAsWord += "three"; break;
            case 4: digitAsWord += "four"; break;
            case 5: digitAsWord += "five"; break;
            case 6: digitAsWord += "six"; break;
            case 7: digitAsWord += "seven"; break;
            case 8: digitAsWord += "eight"; break;
            case 9: digitAsWord += "nine"; break;
        }
        return digitAsWord;
    }
}


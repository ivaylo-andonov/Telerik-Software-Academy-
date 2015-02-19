//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        string[] emails = text.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
        string[] validEmails = Array.FindAll(emails, IsValidEmail);

        PrintEmails(validEmails);
    }

    static bool IsValidEmail(string email)
    {
        const string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        return new Regex(pattern).IsMatch(email);
    }

    static void PrintEmails(string[] validEmails)
    {
        Console.WriteLine("Extracted e-mail addresses from the sample text: ");

        foreach (string email in validEmails)
            Console.WriteLine("- " + email);

        Console.WriteLine();
    }
}



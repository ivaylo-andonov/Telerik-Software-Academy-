using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var text = new StringBuilder();
        var result = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            text.Append(Console.ReadLine());
            text.Append("\n");
        }
            while (text.ToString().Contains('<'))
            {
                int closesOpenTag = text.ToString().IndexOf("</");
                int closesCloseTag = text.ToString().IndexOf(">", closesOpenTag);
                string tagNameEnd = text.ToString().Substring(closesOpenTag + 2, closesCloseTag - closesOpenTag - 2);
                int opensCloseTag = text.ToString().LastIndexOf(">", closesOpenTag);
                string word = text.ToString().Substring(opensCloseTag + 1, closesOpenTag - opensCloseTag - 1);
                int opensOpenTag = text.ToString().LastIndexOf("<", opensCloseTag);
                string tagNameStart = text.ToString().Substring(opensOpenTag + 1, opensCloseTag - opensOpenTag - 1);

                switch (tagNameStart)
                {
                    case "upper": word = word.ToUpper();
                        text.Remove(opensOpenTag, tagNameStart.Length * 2 + word.Length + 5);
                        text.Insert(opensOpenTag, word); break;

                    case "lower": word = word.ToLower();
                        text.Remove(opensOpenTag, tagNameStart.Length * 2 + word.Length + 5);
                        text.Insert(opensOpenTag, word); break;

                    case "toggle": text.Remove(opensOpenTag, tagNameStart.Length * 2 + word.Length + 5);
                        text.Insert(opensOpenTag, Toggle(word));break;

                    case "rev": text.Remove(opensOpenTag, tagNameStart.Length * 2 + word.Length + 5);
                        text.Insert(opensOpenTag, Reversing(word)); break;

                    case "del": text.Remove(opensOpenTag, tagNameStart.Length * 2 + word.Length + 5); break;

                }    
            }
            result.Append(text.ToString());
               
        Console.WriteLine(result.ToString());
    }

    private static string Toggle(string word)
    {
        StringBuilder toggleWord = new StringBuilder();
        for (int i = 0; i < word.Length; i++)
        {
            if (char.IsLetter(word[i]))
            {
                if (char.IsUpper(word[i]))
                {
                   toggleWord.Append(char.ToLower(word[i]));
                }
                else if (char.IsLower(word[i]))
                {
                  toggleWord.Append(char.ToUpper(word[i]));
                }
            }
            else
            {
                toggleWord.Append(word[i]);
            }
        }
        return toggleWord.ToString();

    }

    private static string Reversing(string word)
    {
        StringBuilder reversedWord = new StringBuilder();
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord.Append(word[i]);
        }
        return reversedWord.ToString();
    }
}


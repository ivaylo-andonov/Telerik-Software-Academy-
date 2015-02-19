//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
//Example:

//input:
//<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course.
//Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	

//output:
//<p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
//Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>

using System;

class Program
{
    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.";
        Console.WriteLine("Input string:");
        Console.WriteLine(input);
        input = input.Replace("<a href=\"", "[URL=");
        input = input.Replace("</a>", "[/URL]");
        input = input.Replace("\">", "]");
        Console.WriteLine();
        Console.WriteLine("Output string:");
        Console.WriteLine(input);
    }
}


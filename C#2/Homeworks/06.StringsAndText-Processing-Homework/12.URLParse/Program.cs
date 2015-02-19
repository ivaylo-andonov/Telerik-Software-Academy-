//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
//and extracts from it the [protocol], [server] and [resource] elements.
//Example:
//URL	Information
//http://telerikacademy.com/Courses/Courses/Details/212	
//[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212

using System;

class Program
{
    static void Main()
    {        
        char[] text = Console.ReadLine().ToCharArray();
        string protocol = "";
        string server = "";
        string resouce = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (i == 0)
            {
                while ( text[i] != ':')
                {
                    protocol += text[i];
                    i++;
                }
            }                     
            if (text[i] == '/' && text[i + 1] == '/')
            {
                i += 2;
                while (text[i] != '/')
                {
                    server += text[i];
                    i++;
                }
                i--;               
            }
            else if (text[i] == '/' && text[i + 1] != '/')
            {
                while (i != text.Length)
                {
                    resouce += text[i];
                    i++;
                }               
            }
        }
        Console.WriteLine("\n[protocol]: {0}\n[server]: {1}\n[resource]: {2}",protocol,server,resouce);
        Console.WriteLine();


        //SECOND WAY WITH REGEX

        //const string URL = @"http://telerikacademy.com/Courses/Courses/Details/212";
        //var fragments = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;

        //Console.WriteLine("URL Address: {0}", URL);
        //Console.WriteLine("\n[protocol] = {0}", fragments[1]);
        //Console.WriteLine("[server] = {0}", fragments[2]);
        //Console.WriteLine("[resource] = {0}\n", fragments[3]);
    }
}


using System;
using System.IO;

class ExtractXMLData
{

    /* Write a program that extracts from given XML file all the text without the tags. 
     * Example: <?xml version="1.0">
     * <student>
     *    <name>Pesho</name>
     *    <age>21</age>
     *    <interests count="3">
     *       <interest> Games</instrest>
     *       <interest>C#</instrest>  
     *       <interest> Java</instrest>
     *       </interests>
     * </student> */

    static void Main()
    {
        string s;
        int closedBrackedPos = 0;
        int openBrackedPos = 0;
        try
        {

            using (StreamReader reader = new StreamReader("sample.xml"))
            {
                while (!reader.EndOfStream)
                {
                    closedBrackedPos = 0;
                    openBrackedPos = 0;
                    s = reader.ReadLine().Trim();
                    while (!s.EndsWith(">")) // if data continue on next line then concat with next line(s)
                        s = s + " " + reader.ReadLine().Trim(); // .Trim to remove leading or trailing spaces
                    closedBrackedPos = s.IndexOf('>');
                    while (closedBrackedPos > -1 && closedBrackedPos < s.Length - 1)
                    {
                        openBrackedPos = s.IndexOf('<', closedBrackedPos + 1);
                        if (s[closedBrackedPos + 1] != '<')
                        {
                            Console.WriteLine(s.Substring(closedBrackedPos + 1, openBrackedPos - closedBrackedPos - 1));
                            Console.WriteLine(new string('-', 50));
                        }
                        s = s.Substring(openBrackedPos);
                        closedBrackedPos = s.IndexOf('>');
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {

            Console.WriteLine("Cannot fint input file.");
            return;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("ERROR!!!. Wrong file format.");
        }
    }
}
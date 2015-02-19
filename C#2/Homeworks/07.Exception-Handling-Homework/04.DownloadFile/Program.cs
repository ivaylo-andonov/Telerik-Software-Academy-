//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.IO;
using System.Net;

class Program
{
    static void Main()
    {
        string sourceResource = "http://telerikacademy.com/Content/Images/news-img01.png";
        string localFileName = Path.GetFileName(sourceResource);
        using (WebClient myWebClient = new WebClient())
        {
            try
            {
                Console.WriteLine("Start downloading {0}", sourceResource);
                myWebClient.DownloadFile(sourceResource, localFileName);
                Console.WriteLine("Download succesfull.");
                Console.WriteLine("You can see downloaded file in: local folder of this program\\bin\\Debug\\");
            }
            catch (WebException ex)
            {
                Console.Write(ex.Message);
                if (ex.InnerException != null)
                    Console.WriteLine(" " + ex.InnerException.Message);
                else
                    Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something going wrong. Details: " + ex.Message);
            }
        }
    }
}


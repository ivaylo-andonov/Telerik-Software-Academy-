namespace JSON_Processing_Telerik_Videos
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml;
    using System.Collections.Generic;

    class Program
    {
        const string RssUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
        const string XmlDownloadLocation = "../../rss.xml";

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var data = GetDataRSS(RssUrl);

            XmlDocument xmlDocument = ConvertStringDataIntoXMLDocument(data);

            xmlDocument.Save(XmlDownloadLocation);

            var jsonObject = ConvertXmlIntoJSON(xmlDocument);

            PrintVideoTitlesToConsole(jsonObject);

            //Used LINQ to select all of videos tokens
            var videos = jsonObject["feed"]["entry"].Select(token => JsonConvert.DeserializeObject<Video>(token.ToString()));

            GenerateHtml(videos);
        }


        private static void PrintVideoTitlesToConsole(JObject jsonObject)
        {
            var videoTitles = jsonObject["feed"]["entry"].Select(token => token["title"]);
            Console.WriteLine("Video titles from the RSS Feed:\n");
            foreach (var title in videoTitles)
            {
                Console.WriteLine(title);
            }
        }

        private static void GenerateHtml(IEnumerable<Video> videos)
        {
            StringBuilder resultHtml = new StringBuilder();

            resultHtml.Append("<!DOCTYPE html><html><body style=\"background-color:silver\"><h1 style=\"text-align:center;\">Telerik Video Channel</h1>");

            foreach (var video in videos)
            {
                resultHtml.AppendFormat("<div style=\"float:left; width: 370px; height: 320px; padding:10px;" +
                                  "margin:15px; background-color:#FFCC99; border:3px inset grey; border-radius:10px\">" +
                                  "<iframe width=\"365\" height=\"225\" " +
                                  "src=\"http://www.youtube.com/embed/{1}?autoplay=0\" " +
                                  "frameborder=\"0\" allowfullscreen></iframe>" +
                                  "<h3>{2}</h3><span><b>Date:</b>{3}</span><a style=\"color:black;text-decoration:none;" +
                                  "text-align:right;font-weight: bold;color:grey; \" href=\"{0}\">YouTube link</a></div>",
                                  video.Link.Href, video.Id, video.Title, video.Date);
            }
            resultHtml.Append("</body></html>");

            using (StreamWriter writer = new StreamWriter("../../index.html",false,Encoding.UTF8))
            {
                writer.Write(resultHtml);
                writer.Close();
            }
            Console.WriteLine("\nNew file index.html is created in current project folder. ");

        }

        private static JObject ConvertXmlIntoJSON(XmlDocument xmlDocument)
        {
            var jsonString = JsonConvert.SerializeXmlNode(xmlDocument, Newtonsoft.Json.Formatting.Indented);
            var jsonObject = JObject.Parse(jsonString);

            return jsonObject;
        }

        private static XmlDocument ConvertStringDataIntoXMLDocument(byte[] data)
        {
            var xml = Encoding.UTF8.GetString(data);
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            return doc;
        }

        private static byte[] GetDataRSS(string url)
        {
            var webClient = new WebClient();
            var data = webClient.DownloadData(url);

            return data;
        }
    }
}
